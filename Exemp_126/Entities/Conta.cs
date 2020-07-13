﻿namespace Exemp_126.Entities
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public Conta()
        {
        }   

        public Conta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }

        public virtual void Saque(double valor)
        {
            Saldo -= valor + 5.0;
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
    }
}
