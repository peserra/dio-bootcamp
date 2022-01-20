namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int x { get; set; }
        public int y { get; set; }

        public Matematica(int x, int y)
        {
            this.x = x;
            this.y = y; 
            Calculadora.EventoCalculadora+=EventHandler;  //inscreve o metodo no evento em Calculadora
        }

        public void Somar()
        {
            Calculadora.Somar(this.x,this.y);
        }

        public void EventHandler()//método que será executado quando o evento for chamado
        {
            System.Console.WriteLine("Metodo executado");
        }
    }
}