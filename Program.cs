using ContaBancaria.SistemaBanco;
using System;

namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            var conta = new Conta();
            conta.NomeConta = "Conta Teste";
            conta.NumeroConta = 1000;
            conta.Agencia = 001;
            conta.Saldo = 1000;

            conta.Titular = new Titular()
            {
                Cpf = "06532165498",
                Rg = "8954566",
                Endereco = "Avenida Centro",
                Nome = "Antonio"
            };

            Console.WriteLine($"O saldo atual é: { conta.VerSaldo()}");

            conta.Depositar(150);

            Console.WriteLine($"O saldo atual, após o deposito é: { conta.VerSaldo()}");

            conta.Sacar(900);

            Console.WriteLine($"O saldo atual, após o saque é: { conta.VerSaldo()}");

            conta.Sacar(2000);

            Console.ReadKey();

        }
    }

 
}
