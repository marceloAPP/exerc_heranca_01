using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exemp_126.Entities
{
    class ContaEmpresa : Conta
    {
        public double LimiteEmprestimo { get; set; }

        public ContaEmpresa()
        {
        }

        public ContaEmpresa(int numero, string titular, double saldo, double limiteEmprestimo)
            : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

         public void Emprestimo(double valor)
        {

            if (valor <= LimiteEmprestimo)
            {
                Saldo += valor;
            }
        }

        // incluiundo SEALED no método para que seja restrido subscrever o método da superclasse
        public sealed override void Saque(double valor)
        {
            Saldo += valor - 5.0;
        }
    }
}
