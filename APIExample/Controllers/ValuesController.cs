using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace APIExample.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        static List<string> values = new List<string>();

        // GET api/values
        [HttpGet]
        public List<string> Get()
        {
            return values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if (values.Count-1 < id)
                return "Index Out of bound";
            return values[id];
        }

        // POST api/values/6
        [HttpPost]
        public void Post([FromBody]JObject req)
        {
            if(req.ContainsKey("value"))
                values.Add(req.SelectToken("value").ToString());
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]JObject req)
        {
            if (values.Count-1 < id)
                return "Index Out of bound";
            if (req.ContainsKey("value"))
                values[id] = req.SelectToken("value").ToString();

            return "Success";
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            if (values.Count-1 < id)
                return "Index Out of bound";
            values.RemoveAt(id);
            return "Success";
        }
    }
}
