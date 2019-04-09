@Library('demo-shared-lib@development')_

stage('Demo') {
    withCredentials([usernamePassword(credentialsId: 'keypair', passwordVariable: 'password', usernameVariable: 'username')]) {
        sayHello username
    }

    echo "Hello world"
    sayHello 'Dave'
}