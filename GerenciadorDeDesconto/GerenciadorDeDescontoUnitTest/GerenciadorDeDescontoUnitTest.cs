using System;
using GerenciadorDeDesconto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GerenciadorDeDescontoUnitTest
{
    [TestClass]
    public class GerenciadorDeDescontoUnitTest
    {
        [TestMethod]
        public void Dado_uma_conta_visitante_o_desconto_aplicado_deve_ser_de_0_porcento()
        {
            //Arrange
            GerenciadorDeDescontos gerenciador = new GerenciadorDeDescontos();
            Conta visitante = new Conta(TipoDeConta.Visitante, 0);

            //Act
            var resultado = gerenciador.AplicarDesconto(100, visitante);

            //Assert
            Assert.AreEqual(100m, resultado);
        }

        [TestMethod]
        public void Dado_uma_conta_cliente_o_desconto_aplicado_deve_ser_de_10_porcento()
        {
            //Arrange
            GerenciadorDeDescontos gerenciador = new GerenciadorDeDescontos();
            Conta cliente = new Conta(TipoDeConta.Cliente, 0);

            //Act
            var resultado = gerenciador.AplicarDesconto(100, cliente);

            //Assert
            Assert.AreEqual(90m, resultado);
        }

        [TestMethod]
        public void Dado_uma_conta_vip_o_desconto_aplicado_deve_ser_de_70_porcento()
        {
            //Arrange
            GerenciadorDeDescontos gerenciador = new GerenciadorDeDescontos();
            Conta vip = new Conta(TipoDeConta.Vip, 0);

            //Act
            var resultado = gerenciador.AplicarDesconto(100, vip);

            //Assert
            Assert.AreEqual(30m, resultado);
        }

        [TestMethod]
        public void Dado_uma_conta_socio_o_desconto_aplicado_deve_ser_de_50_porcento()
        {
            //Arrange
            GerenciadorDeDescontos gerenciador = new GerenciadorDeDescontos();
            Conta socio = new Conta(TipoDeConta.Socio, 0);

            //Act
            var resultado = gerenciador.AplicarDesconto(100, socio);

            //Assert
            Assert.AreEqual(50m, resultado);
        }

        [TestMethod]
        public void Dado_uma_conta_cliente_com_1_ano_de_cadastro_o_desconto_aplicado_deve_ser_de_10_porcento_mais_o_desconto_por_tempo()
        {
            //Arrange
            GerenciadorDeDescontos gerenciador = new GerenciadorDeDescontos();
            Conta cliente = new Conta(TipoDeConta.Cliente, 1);

            //Act
            var resultado = gerenciador.AplicarDesconto(100, cliente);

            //Assert
            Assert.AreEqual(89.1m, resultado);
        }

        [TestMethod]
        public void Dado_uma_conta_cliente_com_2_anos_de_cadastro_o_desconto_aplicado_deve_ser_de_10_porcento_mais_o_desconto_por_tempo()
        {
            //Arrange
            GerenciadorDeDescontos gerenciador = new GerenciadorDeDescontos();
            Conta cliente = new Conta(TipoDeConta.Cliente, 2);

            //Act
            var resultado = gerenciador.AplicarDesconto(100, cliente);

            //Assert
            Assert.AreEqual(88.2m, resultado);
        }

        [TestMethod]
        public void Dado_uma_conta_cliente_com_3_anos_de_cadastro_o_desconto_aplicado_deve_ser_de_10_porcento_mais_o_desconto_por_tempo()
        {
            //Arrange
            GerenciadorDeDescontos gerenciador = new GerenciadorDeDescontos();
            Conta cliente = new Conta(TipoDeConta.Cliente, 3);

            //Act
            var resultado = gerenciador.AplicarDesconto(100, cliente);

            //Assert
            Assert.AreEqual(87.3m, resultado);
        }

        [TestMethod]
        public void Dado_uma_conta_cliente_com_4_anos_de_cadastro_o_desconto_aplicado_deve_ser_de_10_porcento_mais_o_desconto_por_tempo()
        {
            //Arrange
            GerenciadorDeDescontos gerenciador = new GerenciadorDeDescontos();
            Conta cliente = new Conta(TipoDeConta.Cliente, 4);

            //Act
            var resultado = gerenciador.AplicarDesconto(100, cliente);

            //Assert
            Assert.AreEqual(86.4m, resultado);
        }

        [TestMethod]
        public void Dado_uma_conta_cliente_com_5_anos_de_cadastro_o_desconto_aplicado_deve_ser_de_10_porcento_mais_o_desconto_por_tempo()
        {
            //Arrange
            GerenciadorDeDescontos gerenciador = new GerenciadorDeDescontos();
            Conta cliente = new Conta(TipoDeConta.Cliente, 5);

            //Act
            var resultado = gerenciador.AplicarDesconto(100, cliente);

            //Assert
            Assert.AreEqual(85.5m, resultado);
        }

        [TestMethod]
        public void Dado_uma_conta_cliente_com_6_anos_de_cadastro_o_desconto_aplicado_deve_ser_de_10_porcento_mais_o_desconto_maximo_por_tempo()
        {
            //Arrange
            GerenciadorDeDescontos gerenciador = new GerenciadorDeDescontos();
            Conta cliente = new Conta(TipoDeConta.Cliente, 6);

            //Act
            var resultado = gerenciador.AplicarDesconto(100, cliente);

            //Assert
            Assert.AreEqual(85.5m, resultado);
        }
    }
}
