# Task API - Gerenciador de Tarefas

API REST desenvolvida em ASP.NET Core para gerenciamento de tarefas.

Projeto criado com foco em organização de código, boas práticas e documentação automática via Swagger.

---

## Sobre o Projeto

Esta API permite realizar operações de:

- Criar tarefas  
- Listar tarefas  
- Atualizar tarefas  
- Remover tarefas  

Estruturado utilizando:

- ASP.NET Core
- Controllers
- Models
- Swagger (Swashbuckle)
- Organização limpa para portfólio

---

## Tecnologias Utilizadas

- .NET 7+
- ASP.NET Core
- Swagger

---

## Como Executar o Projeto

### Pré-requisitos

- .NET SDK 7 ou superior instalado  
https://dotnet.microsoft.com/download

---

### Passo a Passo

1. Clone o repositório:

git clone https://github.com/Barbaroto01/TaskApi-.git

2. Acesse a pasta do projeto:

cd TaskApi-

3. Execute a aplicação:

dotnet run

4. Acesse a documentação Swagger no navegador:

http://localhost:5203/swagger

---

## Caso a Porta Esteja em Uso

Se aparecer erro informando que a porta 5203 está ocupada, execute:

dotnet run --urls "http://localhost:5300"

E acesse:

http://localhost:5300/swagger

---

## Estrutura do Projeto

TaskApi-
│
├── Controllers/
├── Models/
├── Program.cs
├── appsettings.json
└── TaskApi.csproj

---

## Objetivo do Projeto

Este projeto foi desenvolvido como parte do meu portfólio para demonstrar:

- Conhecimento em APIs REST
- Organização de código
- Uso de Swagger para documentação
- Estruturação básica de backend com .NET

---
