namespace ExemploConstrutores.Models
{
    public class Log
    {
        private static Log _log; //propriedade privada da classe 
        public string PropriedadeLog { get; set; }
        private Log()
        {

        }

        public static Log GetInstance() //caso precise usar a calsse
        {
            if (_log == null) //se nao houver instancia em _log
            {
                _log = new Log(); //cria uma propria instancia, porem apenas 1
            }
            return _log;
        }
    }
}