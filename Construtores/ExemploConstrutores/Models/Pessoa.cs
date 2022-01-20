namespace ExemploConstrutores.Models
{
    public class Pessoa
    {   //Construtores e diferentes conceitos
        private readonly string nome, sobrenome; //exemplo do modificador readonly
        
        // public Pessoa() //construtor sem parametros que atribui uma string vazia as variaveis 
        // {
        //    nome = string.Empty;
        //    sobrenome = string.Empty;  
        // }

        public Pessoa(string nome, string sobrenome) //construtor que atribui nome e sobrenome informados às variaveis
        {   
            this.nome = nome;
            this.sobrenome = sobrenome;
        }

        public void Apresentar()
        {
            System.Console.WriteLine ($"Olá meu nome é {nome} {sobrenome}");
        }
    }
}