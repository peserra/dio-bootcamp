using System.IO;
namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        //metodo para listar os diretorios em um determinado caminho
        public void ListarDiretorios(string caminho) //recebe um caminho
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*",SearchOption.AllDirectories); // armazena o caminho do diretorio raiz e dos subdiretorios

            foreach(var path in retornoCaminho)
            {
                System.Console.WriteLine(path); //vai imprimir todos os caminhos recebidos
            }
        }

        //Para listar os arquivos em um determinado diretorio, passando o caminho dele
        public void ListarArquivos(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho, "*", SearchOption.AllDirectories); // ,"*",SearchOption.AllDirectories serve para buscar recursivamente no diretorio
            foreach( var arq in retornoArquivos)
            {
                System.Console.WriteLine(arq);
            }
        }

        //Para criar diretorio
        public void CriarDiretorio(string caminho)
        {
            var retornoDiretorio = Directory.CreateDirectory(caminho); //retorna as infos do diretorio criado
            System.Console.WriteLine(retornoDiretorio.FullName);
        }

        //Para apagar um diretorio
        public void ApagarDiretorio(string caminho, bool apagarArquivos)
        {
            Directory.Delete(caminho,apagarArquivos); // retorno vazio
        }
        //criar arquivo texto
        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho)) //verificação para criar somente se nao houver o arquivo
            {
                File.WriteAllText(caminho,conteudo);
            }
         
            
        }
        //criar arquivo texto com stream
        public void CriarTxtStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.CreateText(caminho)) //using é utilizado para liberar o processo da memoria depois de usar ele 
            {
                foreach (var linha in conteudo) //escrevo na stream a ela escreve no arquivo, em partes
                {
                    stream.WriteLine(linha);
                }
            }

            
        }
        //adicionar linha ao arquivo
        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo); //abre adiciona e fecha o arquivo se ele existir, se nao ele cria arquivo
        }
        //adicionar linha ao arquivo com stream
        public void AdicionarTxtStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.AppendText(caminho)) //using é utilizado para liberar o processo da memoria depois de usar ele 
            {
                foreach (var linha in conteudo) //escrevo na stream a ela escreve no arquivo, em partes
                {
                    stream.WriteLine(linha);
                }
            }

            
        }
        //Ler arquivo
        public void LerArquivo(string caminho)
        {
            var conteudo = File.ReadAllLines(caminho);
            foreach (var linha in conteudo)
            {
                System.Console.WriteLine(linha);
            }
        }

        //Ler arquivo com stream
        public void LerArquivoStream(string caminho)
        {
            string linha = string.Empty; //cria uma linha vazia
            using (var stream = File.OpenText(caminho))
            {   //le linha por linha e retorna o conteudo das linhas, ao pouco -> arquivos grandes
                while((linha=stream.ReadLine())!= null) //quando chegar ao fim do arquivo, a linha sera null, entao saira do laço
                {
                    System.Console.WriteLine(linha);
                }
            }
        }
        //mover arquivo, sobrescrevendo se quiser
        public void MoverArquivo(string caminhoAntigo,string caminhoNovo, bool sobrescrever)
        {
            File.Move(caminhoAntigo,caminhoNovo,sobrescrever);
        }
        //Copia o arquivo, sobrescrevendo se quiser
        public void CopiarArquivo(string caminhoAntigo, string caminhoNovo, bool sobrescrever)
        {
            File.Copy(caminhoAntigo,caminhoNovo,sobrescrever);
        }
        //deletar arquivo
        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }
    }
}