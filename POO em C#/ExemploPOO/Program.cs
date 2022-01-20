// See https://aka.ms/new-console-template for more information
using ExemploPOO.Models;
using ExemploPOO.Interfaces;
using ExemploPOO.Helper;
using System.IO;
using System.Collections.Generic;

// Abstracao

//Pessoa p1 = new Pessoa();
// p1.Nome = "Bob";
// p1.Idade = 20;
// p1.Apresentar();

//Encapsulamento

// Retangulo r = new Retangulo();
// r.DefinirMedidas(0,30);
// var area = r.ObterArea();
// System.Console.WriteLine($"ÁREA: {area}");

//Heranca

// Aluno a1 = new Aluno(); //aluno herda pessoa
// a1.Nome = "Joao";
// a1.Idade = 15;
// a1.Apresentar();


//Polimorfismo Override

// Aluno a1 = new Aluno();
// a1.Nome = "Pedro";
// a1.Idade = 12;
// a1.Nota = 9.5;
// a1.Apresentar();

// Professor p2 = new Professor();
// p2.Nome = "Joao";
// p2.Idade = 48;
// p2.Salario = 5000;
// p2.Apresentar();

// Polimorfismo Overload

// Calculadora calc = new Calculadora();
// System.Console.WriteLine("Resultado da 1 soma: " + calc.Somar(10,10));
// System.Console.WriteLine("Resultado da 2 soma: " + calc.Somar(10,10,10));

//Classes Abstratas

// Corrente conta = new Corrente();
// conta.Creditar(100);
// conta.ExibirSaldo();

//Classe Object

// Computador cp = new Computador();
// System.Console.WriteLine(cp.ToString()); //mesmo sem metodos posso colocar aqueles que Object tem


//Interface
// ICalculadora calc = new Calculadora(); //nao posso fazer new <interface> e sim a classe que a implementa
// System.Console.WriteLine(calc.Somar(10,20));

//Interface com métodos implementados
//Se eu implementar o método padrão na criação da interface, nao sou obrigado a implementar na classe que herda o metodo


//Arquivos


// var caminho = "C:\\TrabalhandoComArquivos";
// var caminhoCombine = Path.Combine(caminho,"Pasta Teste 1"); ->metodo path.combine para que eu possa lidar melhor com as /
// var caminhoArquivo = Path.Combine(caminho, "arquivo teste.txt");
// var caminhoArquivoBckp = Path.Combine(caminho, "arquivo teste-bckp.txt");
// var novoCaminhoArquivo = Path.Combine(caminho, "Pasta Teste 2","arquivo-teste-stream-mudado.txt");
// List<string> listaString = new List<string>();
// List<string> listaStringContinuacao = new List<string>();

// listaString.Add("Linha 1");
// listaString.Add("Linha 2");
// listaString.Add("Linha 3");
// listaStringContinuacao.Add("Linha 4");
// listaStringContinuacao.Add("Linha 5");
// listaStringContinuacao.Add("Linha 6");


// FileHelper helper = new FileHelper(); -> instancia da classe que tem os metodos dos arquivos
//helper.ListarDiretorios(caminho);
//helper.ListarArquivos(caminho);
//System.Console.WriteLine("Criando diretorio :");
//helper.CriarDiretorio(Path.Combine(caminho,"Pasta teste 3","Subpasta teste 3")); //.Combine -> facilita para criar recursivamente
//helper.ApagarDiretorio(caminhoCombine,true);
//helper.CriarArquivoTexto(caminhoArquivo, "Olá esse é um teste");
// helper.CriarTxtStream(caminhoArquivo,listaString);
// helper.AdicionarTxtStream(caminhoArquivo,listaStringContinuacao);
//helper.LerArquivoStream(caminhoArquivo);
//helper.MoverArquivo(caminhoArquivo,novoCaminhoArquivo,true);
//helper.CopiarArquivo(caminhoArquivo,caminhoArquivoBckp,true);
//helper.DeletarArquivo(caminhoArquivoBckp);