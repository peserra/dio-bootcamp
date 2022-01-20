using ExemploConstrutores.Models;
class Program
{
    public delegate void Operacao(int x, int y);  //declaração do delegate deve ter o mesmo numero de parametros que o metodo que quero usar
    static void Main(string[] args)
    {
        //  Pessoa p = new Pessoa("Pedro", "Serra");
        //  p.Apresentar();

        //CONSTRUTORES E SINGLETONS
        //  Log log = new Log(); //nao conseguimos instanciar com o construtor privado
        //  Log log = Log.GetInstance(); //como criar a instancia do singleton
        //  log.PropriedadeLog = "Teste Instancia";
        //  Log log2 = Log.GetInstance();
        //  System.Console.WriteLine(log2.PropriedadeLog);

        //GETTERS E SETTERS
        //  Data d = new Data();
        //  d.setMes(2); //valor válido de mes
        //  d.ApresentarMes();
        //  d.setMes(39); // valor invalido de mes
        //  d.Mes = 12; //Usamos propriedades, entao é mais facil de usar get e set
        //  d.ApresentarMes();

        //CONSTANTE
        // const double pi = 3.14;
        // System.Console.WriteLine(pi);
        // pi = 0; //nao consigo alterar, apenas na inicialização

        //DELEGATE
        //maneiras de instar o delegate:
        //  Operacao op = Calculadora.Somar; 
        //  Operacao op = new Operacao(Calculadora.Somar); // Calculadora.Somar é o metodo puxado pelo delegate
        //maneiras para chamar o delegate:
        //  op(10,10)
        //  op.Invoke(10, 10);
        //Multi Cast Delegate
        //op += Calculadora.Subtrair; //estou adicionando mais um metodo ao mesmo delegate com o "+="

        //EVENT
        Matematica m = new Matematica(10,20);
        m.Somar();
    }
}
