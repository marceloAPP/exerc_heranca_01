using System;
using Exemp_126.Entities;

namespace Exemp_126
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaEmpresa contaEmpresarial = new ContaEmpresa(4116, "Marcelo Souza", 100.0, 500.0);

            Console.WriteLine(contaEmpresarial.Saldo);
            
        }
    }
}
