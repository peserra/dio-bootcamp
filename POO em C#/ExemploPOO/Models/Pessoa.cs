namespace ExemploPOO.Models
{
    public class Pessoa
    {
        // quais as principais características de uma pessoa ?

        public string Nome{ get; set;}
        public int Idade { get; set; }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos!");
        }
    }
}