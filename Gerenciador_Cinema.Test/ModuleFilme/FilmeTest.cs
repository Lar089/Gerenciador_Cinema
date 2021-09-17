using Gerenciador_Cinema.Dominio.ModuleFilme;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using FluentAssertions;
using System.Collections.Generic;
using System.Text;

namespace Gerenciador_Cinema.Test.ModuleFilme
{
    [TestClass]
    [TestCategory("Dominio")]
    public class FilmeTest
    {
        byte[] imagem;
        string titulo;
        string descricao;
        TimeSpan duracao;

        public FilmeTest()
        {
            PopularFilme(out imagem, out titulo, out descricao, out duracao);
        }

        private void PopularFilme(out byte[] imagem, out string titulo, out string descricao, out TimeSpan duracao)
        {
            imagem = null;
            titulo = "Homem-Aranha no Aranhaverso";
            descricao = "Dimensão paralela, outras versões do Homem-Aranha.";
            duracao = new TimeSpan(1, 56, 0);
        }


        #region Atributos de teste adicionais
        //
        // É possível usar os seguintes atributos adicionais enquanto escreve os testes:
        //
        // Use ClassInitialize para executar código antes de executar o primeiro teste na classe
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para executar código após a execução de todos os testes em uma classe
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize para executar código antes de executar cada teste 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para executar código após execução de cada teste
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Filme_SemTitulo()
        {
            var filme = new Filme(imagem, "", descricao, duracao);

            var resultadoValidacao = filme.Validar();

            resultadoValidacao.Should().Be("Titulo é um campo obrigatório");
        }

        [TestMethod]
        public void Filme_SemDescricao()
        {
            var filme = new Filme(imagem, titulo, "", duracao);

            var resultadoValidacao = filme.Validar();

            resultadoValidacao.Should().Be("Descrição é um campo obrigatório");
        }

        [TestMethod]
        public void Filme_SemDuracao()
        {
            var filme = new Filme(imagem, titulo, descricao, new TimeSpan(0,0,0));

            var resultadoValidacao = filme.Validar();

            resultadoValidacao.Should().Be("Duração é um campo obrigatório");
        }
    }
}
