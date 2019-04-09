@Library('demo-shared-lib@development')_

stage('Demo') {
    withCredentials([usernamePassword(credentialsId: 'keypair', passwordVariable: 'password', usernameVariable: 'username')]) {
        sayHello usernameVariable
    }

    echo "Hello world"
    sayHello 'Dave'
}