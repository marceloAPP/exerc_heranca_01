using System;
using Exemp_126.Entities;

namespace Exemp_126
{
    class Program
    {
        static void Main(string[] args)
        {

            Conta conta = new Conta(4116, "Marcelo Souza", 0.0);
            ContaEmpresa contaEmpresarial = new ContaEmpresa(4117, "Elaine", 0.0, 500.0);


            // UPCASTING
            Conta conta1 = contaEmpresarial;
            Conta conta2 = new ContaEmpresa(4117, "Alex", 0.0, 200.00);
            Conta conta3 = new ContaPoupanca(4118, "Anna", 0.0, 0.01);

            // DOWNCASTING
            ContaEmpresa conta4 = (ContaEmpresa)conta2;
            conta4.Emprestimo(200.00);

            //ContaEmpresa conta5 = (ContaEmpresa)conta3;
            if (conta3 is ContaEmpresa)
            {
                //ContaEmpresa conta5 = (ContaEmpresa)conta3;
                ContaEmpresa conta5 = conta3 as ContaEmpresa;
                conta5.Emprestimo(190.0);
                Console.WriteLine("Emprestimo realizado!");
            }

            if (conta3 is ContaPoupanca)
            {
                //ContaPoupanca conta5 = conta3 as ContaPoupanca;
                ContaPoupanca conta5 = (ContaPoupanca)conta3;
                conta5.AtualizaSaldo();
                Console.WriteLine("ATUALIZA");
            }
        }
    }
}
