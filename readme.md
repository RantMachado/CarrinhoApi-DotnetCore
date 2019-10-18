Projeto de Web API Rest usando C# .NET Core 2.2, mongoDb, DDD e repository pattern.

Dentro do projeto existe o arquivo Modelo.json que foi a base de criacao do banco no mongoDb
basta abrir o terminal na pasta do projeto e executar o comando de criacao do banco e a collection: 

mongoimport --host=127.0.0.1 -d ingressoDotCom -c Cart --type json --file Modelo.json --jsonArray

A aplicação roda em https://localhost:44233/api/Cart/
