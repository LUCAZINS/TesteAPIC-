📞 Sistema de Atendimento - API (.NET + SQL)
🚀 Desafio de Projeto

Este projeto foi desenvolvido com base nos conhecimentos adquiridos em .NET, API e integração com banco de dados, com o objetivo de simular um sistema real de atendimento.

🧩 Contexto

A proposta é construir um sistema de atendimento onde seja possível:

✔️ Cadastrar clientes
✔️ Registrar atendimentos
✔️ Consultar históricos
✔️ Organizar dados em banco SQL

A aplicação foi desenvolvida como uma Web API, permitindo integração com outros sistemas futuramente.

🏗️ Estrutura da Aplicação

O projeto segue uma arquitetura organizada:

📂 Controllers → Controle das requisições
📂 Models → Estrutura dos dados
📂 Context → Conexão com banco de dados
📂 Services → Regras de negócio

🧠 Regras de Negócio

🔹 Um cliente pode ter vários atendimentos
🔹 Cada atendimento possui data, descrição e status
🔹 Os dados são persistidos no banco SQL
🔹 O sistema possui operações completas de CRUD

⚙️ Tecnologias Utilizadas

💻 .NET (C#)
🗄️ SQL Server
🧩 Entity Framework Core
📑 Swagger
📊 Planilhas (Excel)
🔗 n8n (automação - em desenvolvimento)
🤖 Integração com IA

🔄 Status do Projeto

🚧 Em desenvolvimento

✔️ Conexão com banco de dados
✔️ Estrutura inicial da API
✔️ Testes de inserção e consulta

📡 Endpoints da API
🔹 Verbo	🔹 Endpoint	🔹 Parâmetro	🔹 Body
GET	/Atendimento/{id}	id	N/A
GET	/Atendimento/ObterTodos	N/A	N/A
POST	/Atendimento	N/A	Schema Atendimento
PUT	/Atendimento/{id}	id	Schema Atendimento
DELETE	/Atendimento/{id}	id	N/A
📄 Schema (Model) Atendimento
{
  "id": 0,
  "cliente": "string",
  "descricao": "string",
  "data": "2026-01-01T10:00:00",
  "status": "Aberto"
}
🧪 Testes

Os testes estão sendo realizados com:

🔸 Swagger
🔸 Banco de dados SQL
🔸 Planilhas para simulação

🛠️ Configuração do Projeto

Execute os comandos abaixo para criar o banco:

dotnet ef migrations add InitialCreate
dotnet ef database update

📌 Não esqueça de configurar corretamente a string de conexão no appsettings.json.

🎯 Objetivo do Projeto

🎓 Praticar desenvolvimento com .NET
🧠 Aprender integração com banco de dados
📊 Simular um sistema real
📁 Construir portfólio

🚀 Próximos Passos

🔐 Implementar autenticação
⚙️ Melhorar regras de negócio
🔗 Integrar com n8n
🤖 Aplicar IA no atendimento
🎨 Criar front-end

📎 Observação

Este projeto faz parte do meu processo de aprendizado e está em constante evolução 🚀
