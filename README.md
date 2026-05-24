# 📚 Gestão Escolar

Uma API REST desenvolvida com **.NET 10** e **MySQL com front-end desenvolvido em React**, responsável pelo gerenciamento de alunos, oferecendo operações de cadastro, consulta, atualização e remoção de registros. A aplicação também conta com um sistema de autenticação e autorização baseado em **JWT (JSON Web Token)**, garantindo segurança no acesso aos recursos protegidos.

---

## 📖 Sobre o Projeto

Este projeto foi desenvolvido para a avaliação do primerio bimestre para a disciplina de Back-end com objetivo de fornecer uma solução simples e eficiente para o gerenciamento de alunos através de uma API REST.

A aplicação permite que usuários autenticados realizem operações de CRUD (Create, Read, Update e Delete) sobre os registros de alunos, utilizando boas práticas de desenvolvimento e segurança.

### Tecnologias Utilizadas

- .NET 10
- ASP.NET Core Web API
- Entity Framework Core
- MySQL (última versão)
- JWT (JSON Web Token)
- Swagger
- Node 24.x
- Yarn 1.22.x
- React 19.2.x
- 8.0.x

---

## ⚙️ Requisitos

Antes de executar o projeto, certifique-se de possuir os seguintes requisitos instalados:

- [.NET SDK 10](https://dotnet.microsoft.com/)
- MySQL
- Node
- Yarn
- Git
- IDE de sua preferência:
  - Visual Studio 2022+
  - Visual Studio Code
  - JetBrains Rider

---

## 🚀 Funcionalidades

### Autenticação
- Login com usuário fixo
- Geração de Token JWT
- Rotas protegidas por autenticação

### Gerenciamento de Alunos

- Cadastrar aluno
- Consultar todos os alunos
- Consultar aluno por ID
- Atualizar informações do aluno
- Remover aluno

### Documentação

- Interface Swagger para testes e documentação dos endpoints

---

## 🔗 Endpoints

### Autenticação

#### Registrar Usuário

#### Login

```http
POST /api/Auth/login
```

**Request**

```json
{
  "usuario": "string",
  "senha": "string"
}
```

**Response**

```json
{
  "token": "jwt_token_aqui"
}
```

---

### Alunos

> Todas as rotas abaixo exigem autenticação via Bearer Token.

---

#### Listar Alunos

```http
GET /api/Alunos
```

---

#### Buscar Aluno por ID

```http
GET /api/Alunos/{id}
```

---

#### Cadastrar Aluno

```http
POST /api/Alunos
```

**Request**

```json
{
  "Nome": "Jonh Doe",
  "Email": "jhondoe@email.com",
  "Curso": "Sistemas para internet"
  "DataNascimento": 2006-11-8
}
```

---

#### Atualizar Aluno

```http
PUT /api/Alunos/{id}
```

**Request**

```json
{
  "Nome": "Jonh Doe",
  "Email": "jhondoe@email.com",
  "Curso": "Sistemas para internet"
  "DataNascimento": 2006-11-8

}
```

---

#### Remover Aluno

```http
DELETE /api/Alunos/{id}
```

---

## 🔒 Autenticação

A API utiliza autenticação baseada em JWT.

Após realizar o login, utilize o token retornado no cabeçalho das requisições:

```http
Authorization: Bearer seu_token_jwt
```

---

## 🛠️ Como Executar o Projeto

### 1. Clonar o Repositório

```bash
git clone https://github.com/dev-jefferson-matheus-ifrn/avaliacao1.git
```

```bash
cd avaliacao1
```

```bash
cd backend
```

```bash
cd gestaoEscolar
```
---

### 2. Configurar Banco de Dados

Crie um banco de dados MySQL:

```sql
CREATE DATABASE db_alunos;
```

Configure a string de conexão no arquivo:

```json
appsettings.json
```

Exemplo:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "server=localhost;database=db_alunos;user=root;password=sua_senha;"
  }
}
```

---

### 3. Executar as Migrations

```bash
dotnet ef migrations add Initial
```

```bash
dotnet ef database update
```

---

### 4. Executar a Aplicação

```bash
dotnet run
```

A API estará disponível em:

```text
https://localhost:5025
```
---

### 5. Acessar o Swagger

Após iniciar a aplicação, acesse:

```text
https://localhost:5025/swagger
```

---

## 📂 Estrutura do Projeto

```text
├── backend
│   └── gestaoEscolar
│       ├── Controllers
│       ├── Data
│       ├── DTOs
│       ├── Migrations
│       ├── Model
│       ├── Program.cs
│       └── appsettings.json
│
└── frontend
    ├── public
    ├── src
    │   ├── assets
    │   ├── App.tsx
    │   └── main.tsx
    ├── package.json
    └── vite.config.ts
```

---

## 🔮 Futuras Melhorias

- Implementação de Refresh Token
- Controle de perfis e permissões (Roles)
- Paginação de resultados
- Filtros e ordenação de alunos
- Implementação de perfis(Alunos, professores, diretor)
- Banco de dados normalizado

---
## 🚧 `Front-end em andamento`
---

## 👨‍💻 Desenvolvedores

| Nome | Função |
|--------|--------|
| Jefferson Matheus Ferreira de Lima | Desenvolvedor Back-end |
| Letícia Geovana Lopes dos Santos   | Desenvolvedora Front-end|
