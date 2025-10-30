using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace ValidadorCPF.Functions
    {
    public static class ValidarCPF
        {
        [FunctionName("ValidarCPF")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
            {
            string cpf = req.Query["cpf"];

            if (string.IsNullOrWhiteSpace(cpf))
                return new BadRequestObjectResult("Parâmetro 'cpf' é obrigatório.");

            bool valido = CpfValido(cpf);
            return new OkObjectResult(new { cpf, valido });
            }

        private static bool CpfValido(string cpf)
            {
            // Remove caracteres não numéricos
            cpf = Regex.Replace(cpf, "[^0-9]", "");

            // Verifica se tem 11 dígitos e não é uma sequência repetida
            if (cpf.Length != 11 || new string(cpf[0], 11) == cpf)
                return false;

            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            string digito = resto.ToString();

            tempCpf += digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito += resto.ToString();

            return cpf.EndsWith(digito);
            }
        }
    }