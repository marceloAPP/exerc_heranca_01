namespace Exemp_126.Entities
{
    // incluiundo SEALED na classe para que seja restrido que a classe seja herdada
    sealed class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }

        public ContaPoupanca() { }

        public ContaPoupanca(int numero, string titular, double saldo, double taxaJuros) : base(numero, titular, saldo)
        {
            TaxaJuros = taxaJuros;
        }

        public void AtualizaSaldo()
        {
            Saldo += Saldo + TaxaJuros;
        }

        public override void Saque(double valor)
        {
            base.Saque(valor);
            Saldo += 3.0;
        }

    }


}
