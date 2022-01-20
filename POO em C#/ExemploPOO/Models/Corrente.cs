namespace ExemploPOO.Models
{
    public class Corrente : Conta
    {
        public override void Creditar(double valor) //tem que sobrescrever o metodo da classe pai
        {
           base.saldo = valor; //base. saldo é da classe pai
        }
    }
}