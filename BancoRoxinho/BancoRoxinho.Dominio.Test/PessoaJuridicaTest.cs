﻿using BancoRoxinho.Dominio.Model;
using Xunit;

namespace BancoRoxinho.Dominio.Test
{
    public class PessoaJuridicaTest
    {
        [Fact]
        public void DeveRetornarTrueQuandoOCNPJForValido()
        {
            string cnpj = "02.570.336/0001-15";
            bool resultadoEsperado = true;
            PessoaJuridica pessoa = new PessoaJuridica();

            var resultado = pessoa.VerificarCNPJ(cnpj);

            Assert.True(resultado == resultadoEsperado);
        }
    }
}
