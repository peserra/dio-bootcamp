namespace ExemploConstrutores.Models
{   
    //construtores com herança
    public class Aluno : Pessoa
    {   
        //indica que estamos pasando "nome" e "sobrenome" pela classe Aluno para a classe Pessoa, em base ()
        public Aluno(string nome, string sobrenome) : base (nome, sobrenome) 
        {
            
        }
    }
}