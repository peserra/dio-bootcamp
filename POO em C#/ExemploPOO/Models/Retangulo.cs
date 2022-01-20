namespace ExemploPOO.Models
{
    public class Retangulo
    {
        private double comprimento, largura;
        private bool valido;

        //metodo para alterar as propriedades acima
        public void DefinirMedidas(double comprimento, double largura)
        {
            if (comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento;
                this.largura = largura;
                this.valido = true;
            }
            else 
            {
                System.Console.WriteLine("Valores inválidos");
            }
            
        }

        public double ObterArea()
        {
         if (valido)
         {
            return comprimento*largura;
         }
         else
         {
             System.Console.WriteLine("Preencha valores válidos [maiores que zero]");
             return 0;
         }
           
        }
    }
}