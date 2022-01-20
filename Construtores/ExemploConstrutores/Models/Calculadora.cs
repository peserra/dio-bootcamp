namespace ExemploConstrutores.Models
{
    //EXEMPLO DE DELEGATE E EVENTO
    public class Calculadora
    {
        //antes de declarar um evento, precisa declarar um delegate:
        public delegate void DelegateCalculadora();

        //declarando evento:
        public static event DelegateCalculadora EventoCalculadora;

        public static void Somar(int x, int y)
        {   
            if (EventoCalculadora != null) //se eu tiver inscritos
            {
                System.Console.WriteLine($"Adição: {x+y}");
                EventoCalculadora(); //executa todos os metodos inscritos no evento
            }
            else
            {
                System.Console.WriteLine("Nenhum Inscrito");
            }

            
        }
        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x-y}");
        }
    }
}