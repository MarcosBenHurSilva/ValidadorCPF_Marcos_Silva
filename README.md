# 🧾 Validador de CPF - Azure Functions

Este projeto é um microsserviço serverless desenvolvido com **Azure Functions** e **.NET 8**, com o objetivo de validar CPFs brasileiros de forma eficiente, escalável e econômica.

## 🚀 Funcionalidade

A função recebe um CPF como parâmetro via HTTP e retorna se ele é válido ou não, com base nos dígitos verificadores e regras oficiais.

### 🔗 Endpoint público

Você pode testar diretamente com o seguinte link:
https://cpfvalidadorapp.azurewebsites.net/api/ValidarCPF?cpf=00000000191

Retorno esperado:

{
  "cpf": "00000000191",
  "valido": true
}

## 🛠️ Tecnologias Utilizadas

- **Azure Functions**
- **.NET 8**
- **Azure CLI**
- **GitHub**

## 📄 Licença

Este projeto está sob a licença **MIT**.

