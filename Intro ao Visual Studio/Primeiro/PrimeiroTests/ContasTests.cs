using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contas.Tests
{
    [TestClass()]
    public class ContasTests
    {
        [TestMethod()]
        public void SomaTest()
        {
            // criar variáveis de teste:
            var a = 2; 
            var b = 2;
            //cria resultado esperado de teste:
            var esperado = 4;
            //instancia a classe Contas para teste:
            var contas = new Contas();
            // utiliza a o metodo da classe a ser testada com as mesmas variáveis:
            var resultado = contas.Soma(a, b);
            // verifica se os resultados são iguais, se True, o teste passa
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void SubtracaoTest()
        {
            // criar variáveis de teste:
            var a = 2;
            var b = 2;
            //cria resultado esperado de teste:
            var esperado = 0;
            //instancia a classe Contas para teste:
            var contas = new Contas();
            // utiliza a o metodo da classe a ser testada com as mesmas variáveis:
            var resultado = contas.Subtracao(a, b);
            // verifica se os resultados são iguais, se True, o teste passa
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void DivisaoTest()
        {
            // criar variáveis de teste:
            var a = 2;
            var b = 2;
            //cria resultado esperado de teste:
            var esperado = 1;
            //instancia a classe Contas para teste:
            var contas = new Contas();
            // utiliza a o metodo da classe a ser testada com as mesmas variáveis:
            var resultado = contas.Divisao(a, b);
            // verifica se os resultados são iguais, se True, o teste passa
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod()]
        public void MultiplicacaoTest()
        {
            // criar variáveis de teste:
            var a = 2;
            var b = 2;
            //cria resultado esperado de teste:
            var esperado = 4;
            //instancia a classe Contas para teste:
            var contas = new Contas();
            // utiliza a o metodo da classe a ser testada com as mesmas variáveis:
            var resultado = contas.Multiplicacao(a, b);
            // verifica se os resultados são iguais, se True, o teste passa, se não , é lançada exceção
            Assert.AreEqual(esperado, resultado);
        }
    }
}