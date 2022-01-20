namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá sou o aluno {Nome} e tive nota {Nota} ");
        }
    }
}