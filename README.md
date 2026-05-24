# 📚 Gestão Escolar

Uma API REST desenvolvida com **.NET 10** e **MySQL**, responsável pelo gerenciamento de alunos, oferecendo operações de cadastro, consulta, atualização e remoção de registros. A aplicação também conta com um sistema de autenticação e autorização baseado em **JWT (JSON Web Token)**, garantindo segurança no acesso aos recursos protegidos.

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

---

## ⚙️ Requisitos

Antes de executar o projeto, certifique-se de possuir os seguintes requisitos instalados:

- [.NET SDK 10](https://dotnet.microsoft.com/)
- MySQL 
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
POST /api/auth/login
```

**Request**

```json
{
  "email": "joao@email.com",
  "password": "123456"
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
GET /api/alunos
```

---

#### Buscar Aluno por ID

```http
GET /api/alunos/{id}
```

---

#### Cadastrar Aluno

```http
POST /api/alunos
```

**Request**

```json
{
  "nome": "Maria Oliveira",
  "email": "maria@email.com",
  "idade": 20
}
```

---

#### Atualizar Aluno

```http
PUT /api/alunos/{id}
```

**Request**

```json
{
  "nome": "Maria Oliveira",
  "email": "maria@email.com",
  "idade": 21
}
```

---

#### Remover Aluno

```http
DELETE /api/alunos/{id}
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
git clone https://github.com/seu-usuario/api-gerenciamento-alunos.git
```

```bash
cd api-gerenciamento-alunos
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
dotnet ef database update
```

---

### 4. Executar a Aplicação

```bash
dotnet run
```

A API estará disponível em:

```text
https://localhost:5001
```

ou

```text
http://localhost:5000
```

---

### 5. Acessar o Swagger

Após iniciar a aplicação, acesse:

```text
https://localhost:5001/swagger
```

---

## 📂 Estrutura do Projeto

```text
src/
├── Controllers/
├── Services/
├── Repositories/
├── Entities/
├── DTOs/
├── Data/
├── Migrations/
├── Configurations/
└── Program.cs
```

---

## 🔮 Futuras Melhorias

- Implementação de Refresh Token
- Controle de perfis e permissões (Roles)
- Paginação de resultados
- Filtros e ordenação de alunos
- Testes unitários e de integração
- Logs centralizados
- Deploy automatizado com CI/CD
- Containerização completa com Docker Compose
- Monitoramento e observabilidade

---

## 🤝 Contribuição

Contribuições são bem-vindas.

1. Faça um Fork do projeto
2. Crie uma branch para sua feature

```bash
git checkout -b feature/minha-feature
```

3. Faça commit das alterações

```bash
git commit -m "Minha nova feature"
```

4. Faça push para a branch

```bash
git push origin feature/minha-feature
```

5. Abra um Pull Request

---

## 👨‍💻 Desenvolvedores

| Nome | Função |
|--------|--------|
| Seu Nome | Desenvolvedor Back-end |

---

## 📄 Licença

Este projeto está sob a licença MIT.

Consulte o arquivo `LICENSE` para mais informações.

---

## 📞 Contato

Caso tenha dúvidas ou sugestões, entre em contato através dos canais abaixo:

- Email: seuemail@exemplo.com
- LinkedIn: https://linkedin.com/in/seu-perfil
- GitHub: https://github.com/seu-usuario

---

⭐ Se este projeto foi útil para você, considere deixar uma estrela no repositório.
