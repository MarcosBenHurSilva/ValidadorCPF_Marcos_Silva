# 🧾 Validador de CPF - Azure Functions

Link: https://cpfvalidadorapp.azurewebsites.net/api/ValidarCPF?cpf=00000000191&code=CHAVE_AQUI

CHAVE_DE_ACESSO = dOASghjIcOOQv7LlDMlS1bp9B_CdTxVi3iBB8ubuFubsAzFuNbPdwg==

Este projeto é um microsserviço serverless desenvolvido com **Azure Functions** e **.NET 8**, com o objetivo de validar CPFs brasileiros de forma eficiente, escalável e econômica.

## 🚀 Funcionalidade

A função recebe um CPF como parâmetro via HTTP e retorna se ele é válido ou não, com base nos dígitos verificadores e regras oficiais.

### 🔗 Endpoint público

Você pode testar diretamente com o seguinte link:
https://cpfvalidadorapp.azurewebsites.net/api/ValidarCPF?cpf=00000000191&code=CHAVE_AQUI

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



