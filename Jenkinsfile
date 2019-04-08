@Library('demo-shared-lib')
pipeline{
    agent{
        label "node"
    }
    stages{
        stage("one"){
            steps{
                echo "Stage echo"
                sayHello 'Dan'
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