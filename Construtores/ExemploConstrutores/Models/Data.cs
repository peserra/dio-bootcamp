namespace ExemploConstrutores.Models
{
    public class Data
    {
        //Getters e Setters
        private int mes;
        private bool mesValido;
        public int GetMes()
        {
            return this.mes;
        }

        public void setMes(int mes)
        {
            if (mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }

        public void ApresentarMes()
        {
            if (this.mesValido)
            {
                System.Console.WriteLine(this.mes);
            }
            else
            {
                System.Console.WriteLine("Mês Invalido");
            }
        }

        //PROPRIEDADES -> usado para facilitar o uso do get e set
        public int Mes
        {
            get
            {
                return this.mes;
            }

            set
            {
                if (value > 0 && value <= 12) //value é o valor recebido passado no programa
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            }
        }
    }
}