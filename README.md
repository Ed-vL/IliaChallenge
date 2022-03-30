# IliaChallenge

### Ferramentas Necessárias

Este projeto é desenvolvido em .Net Core 5 e MongoDb para a persistência dos dados. Para executar o projeto em conjunto com o banco de dados é necessário possuir a ferramenta
[Docker](https://docs.docker.com/get-docker/) e [docker-compose](https://docs.docker.com/compose/install/).

### Como rodar

Para rodar o projeto atrelado a um terminal, execute o comando:

``` $ sudo docker-compose up --build```

Para encerrar o projeto, execute o comando:

``` $ sudo docker-compose down ```

### Endpoints
Os endpoints desta aplicação estão listados e descritos no swagger, disponível em:

``` http://localhost:5000/swagger/index.html ```