using System;


namespace Revisao 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            
            int indiceAluno = 0;
            
            while (true)
            {
                             
                string opcaoUsuario = GetOpcao();

                if (opcaoUsuario.ToUpper() == "X")
                {
                    break;
                }
                else if (opcaoUsuario == "1") //adicionar alunos
                {
                    Console.WriteLine("Informe o nome do aluno");
                    Aluno aluno = new Aluno();
                    aluno.Nome = Console.ReadLine();
                    Console.WriteLine("Informe a nota final do aluno");
                    
                    if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                    {
                        aluno.Nota = nota;
                    }
                    else
                    {
                        throw new ArgumentException("Indicar valor da nota em forma decimal ");
                    }
                    
                    alunos[indiceAluno] = aluno;
                    indiceAluno ++;
                    
                    
                }
                else if (opcaoUsuario == "2")//listar alunos
                {
                    foreach(var estudante in alunos)
                    {
                        if (!string.IsNullOrEmpty(estudante.Nome)) //se a string () nao for nula ou vazia
                        {
                            Console.WriteLine($"NOME ALUNO: {estudante.Nome} - NOTA FINAL: {estudante.Nota}");
                        }
                        
                    }
                }
                else if (opcaoUsuario == "3")//calcular media geral
                {
                    decimal somaTotal = 0;
                    int nrAlunos = 0;
                    for (int i = 0; i<alunos.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(alunos[i].Nome))
                        {
                            somaTotal+=alunos[i].Nota;
                            nrAlunos++;
                        }
                    }
                    decimal mediaGeral = somaTotal / nrAlunos;
                    
                    Conceitos conceito;

                    if(mediaGeral <= 4)
                    {
                        conceito = Conceitos.F;
                    }
                    else if(mediaGeral <= 6)
                    {
                         conceito = Conceitos.D;
                    }
                    else if(mediaGeral <= 8)
                    {
                         conceito = Conceitos.C;
                    }
                    else if(mediaGeral <= 9)
                    {
                         conceito = Conceitos.B;
                    }
                    else
                    {
                      conceito = Conceitos.A;  
                    }

                    Console.WriteLine($"MEDIA GERAL: {mediaGeral} CONCEITO {conceito}");

                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }

            }
        }

        private static string GetOpcao()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a ação desejada: ");
            Console.WriteLine("1 - Inserir novo aluno. ");
            Console.WriteLine("2 - Listar alunos. ");
            Console.WriteLine("3 - Calcular a media geral ");
            Console.WriteLine("X - Sair ");

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}