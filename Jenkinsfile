@Library('demo-shared-lib@development')_


pipeline{
    agent{
        label "master"
    }
    stages{
        stage("A"){
            steps{
                    withCredentials([usernamePassword(credentialsId: 'keypair', passwordVariable: 'password', usernameVariable: 'username')]) {
                        sayHello username
                    }

                    echo "Hello world"
                    sayHello 'Dave'
            }
            post{
                always{
                    echo "========always========"
                }
                success{
                    echo "========A executed successfully========"
                }
                failure{
                    echo "========A execution failed========"
                }
            }
        }
        stage("B") {
            steps {
                checkout scm
                bat label: '', script: 'dotnet build'
            }
        }
    }
    post{
        always{
            echo "========always========"
        }
        success{
            echo "========pipeline executed successfully ========"
        }
        failure{
            echo "========pipeline execution failed========"
        }
    }
}