using APIExample.Controllers;
using System;
using System.Collections.Generic;
using Xunit;

namespace APIExampleFixtures
{
    public class ValuesControllerFixtures
    {
        [Fact]
        public void Get_Test()
        {
            ValuesController controller = new ValuesController();
            List<string> list = controller.Get();
            Assert.Equal(new List<string>(), list);
        }
    }
}
