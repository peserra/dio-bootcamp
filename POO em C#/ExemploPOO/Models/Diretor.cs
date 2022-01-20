namespace ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
           System.Console.WriteLine($"Olá sou o Diretor {Nome} e tenho salario de {Salario}R$");
        }
    }
}