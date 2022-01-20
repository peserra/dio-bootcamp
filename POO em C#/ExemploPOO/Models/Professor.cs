namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá sou o professor {Nome} e tenho salario de {Salario}R$");
        }
    }
}