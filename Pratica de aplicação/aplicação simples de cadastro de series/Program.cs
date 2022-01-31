using System;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            
			FuncoesSeries s = new FuncoesSeries();
			FuncoesFilmes f = new FuncoesFilmes();
            System.Console.WriteLine("Qual tipo de cadastro deseja fazer? (1)-Series (2)-Filmes");
            int tipo = int.Parse(Console.ReadLine());
            switch(tipo)
			{
				case 1:
					string opcaoUsuario = ObterOpcaoUsuarioSerie();
					while (opcaoUsuario.ToUpper() != "X")
					{
						s.Run(opcaoUsuario);
						opcaoUsuario = ObterOpcaoUsuarioSerie();
					}
					break;
				case 2:
					string opcaoUsuario2 = ObterOpcaoUsuarioFilme();
					while (opcaoUsuario2.ToUpper() != "X")
					{
						f.Run(opcaoUsuario2);
						opcaoUsuario2 = ObterOpcaoUsuarioFilme();
					}
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}


            Console.WriteLine("Obrigado por utilizar nossos serviços.");
            Console.ReadLine();
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------
        private static string ObterOpcaoUsuarioSerie()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar séries");
            Console.WriteLine("2- Inserir nova série");
            Console.WriteLine("3- Atualizar série");
            Console.WriteLine("4- Excluir série");
            Console.WriteLine("5- Visualizar série");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }

		private static string ObterOpcaoUsuarioFilme()
        {
            Console.WriteLine();
            Console.WriteLine("DIO Filmes a seu dispor!!!");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Listar filmes");
            Console.WriteLine("2- Inserir novo filme");
            Console.WriteLine("3- Atualizar flme");
            Console.WriteLine("4- Excluir filme");
            Console.WriteLine("5- Visualizar filme");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
        


    }
}
