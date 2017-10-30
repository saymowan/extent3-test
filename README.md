# extent3-test (em construção)
Projeto com exemplo da aplicação do recurso ExtentX e ExtentReport3


Installation

If MongoDB and ExtentX server will run on the same host, follow the directions below, otherwise see the subsequent section to setup ExtentX to detect MongoDB on another host.

  - MongoDB & NodeJS on same host
  - Download and install NodeJS
  - Download and install MongoDB
  - Run Mongo daemon
  - Open Console
  - Navigate to MongoDB folder
  - Run mongod
  - Create C:\data\db
  - Download ExtentX, unzip, navigate to its folder and run:
  - npm install
  - npm install -g sails
  - sails lift
  - Open browser and navigate to the NodeJS server URL + port. Ex: localhost:1337

Me ajudou: https://stackoverflow.com/questions/22290143/mongodb-error-error-failed-to-connect-to-localhost27017

Tudo funcionando! 

Execução do MongoDB: 
  - Deixar o prompt executando o serviço
  - Entrar na pasta do MongoDB e executar “mongod” 
  - Verificar atualizações do serviço ao executar os testes

Execução do Sails: 
   - Deixar o prompt executando o serviço
   - Entrar na pasta do extent community e executar “sails lift”
   - Irá gerar a porta do serviço - acessar para ver relatório ExtentX



Java example: https://github.com/saikrishna321/extent_reports/blob/master/src/test/java/com/test/sample/ExtentManager.java
