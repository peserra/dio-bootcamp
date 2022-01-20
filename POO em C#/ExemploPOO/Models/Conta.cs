namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor); //abstrato, nao tem implementação

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo é: {saldo}");
        }

        
    }
}