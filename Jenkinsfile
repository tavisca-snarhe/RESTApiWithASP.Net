pipeline {
    agent any

    stages {
	stage('Restore') {
            steps {
                dotnet restore
            }
        }
        stage('Build') {
            steps {
                dotnet build
            }
        }
        stage('Test') {
            steps {
                dotnet test
            }
        }
	stage('publish') {
            steps {
                dotnet build
            }
        }
    }
}