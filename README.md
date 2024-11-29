Funcionalidades

 - Obter todos os celulares: Retorna uma lista de todos os celulares cadastrados.
 - Obter celular por ID: Retorna os detalhes de um celular específico, utilizando seu ID.
 - Criar novo celular: Permite adicionar um novo celular à coleção.
 - Atualizar celular: Permite atualizar as informações de um celular existente.
 - Remover celular: Remove um celular da coleção.
 - Pré-requisitos
 - Antes de rodar a aplicação, certifique-se de que você tenha os seguintes requisitos instalados:

A aplicação foi desenvolvida utilizando o .NET 8.0. 

  - Como abrir o projeto

git clone https://github.com/seu-usuario/LojaCelularAPI.git
cd LojaCelularAPI

Configure as variáveis de ambiente
No arquivo appsettings.json, configure a string de conexão do MongoDB para o banco de dados que você está utilizando:

{
  "LojaCelularDatabase": {
    "ConnectionString": "mongodb://localhost:27017", // Altere para a URL do seu MongoDB
    "DatabaseName": "LojaCelularDB",
    "CelularesCollectionName": "Celulares"
  }
}


A API agora está rodando e você pode usar o Swagger para testar as funcionalidades. Acesse a interface Swagger da API em:

 - https://localhost:5001/swagger
Através da interface Swagger, você pode testar os seguintes endpoints:

 - GET /api/celulares: Retorna todos os celulares.
 - GET /api/celulares/{id}: Retorna um celular específico, utilizando o ID.
 - POST /api/celulares: Cria um novo celular. Envie um corpo JSON com os dados do celular.
 - PUT /api/celulares/{id}: Atualiza um celular existente.
 - DELETE /api/celulares/{id}: Remove um celular da coleção.
