using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorDeDesconto
{
    public class GerenciadorDeDesconto
    {
        public decimal AplicarDesconto(decimal valorOriginal, Conta conta)
        {
            decimal precoComDesconto = 0;

            decimal descontoBaseadoEmTempoDeConta = CalcularDescontoBaseadoEmTempoDeConta(conta);
            switch (conta.Tipo)
            {
                case TipoDeConta.Visitante:
                    precoComDesconto = valorOriginal;
                    break;

                case TipoDeConta.Cliente:
                    precoComDesconto = (valorOriginal - (0.1m * valorOriginal)) - descontoBaseadoEmTempoDeConta * (valorOriginal - (0.1m * valorOriginal));
                    break;

                case TipoDeConta.Vip:
                    precoComDesconto = (0.7m * valorOriginal) - descontoBaseadoEmTempoDeConta * (0.7m * valorOriginal);
                    break;

                case TipoDeConta.Socio:
                    precoComDesconto = (valorOriginal - (0.5m * valorOriginal)) - descontoBaseadoEmTempoDeConta * (valorOriginal - (0.5m * valorOriginal));
                    break;
            }

            return precoComDesconto;
        }

        public decimal CalcularDescontoBaseadoEmTempoDeConta(Conta conta)
        {
            return (conta.TempoDeCadastroEmAnos > 5) ? (decimal)5 / 100 : (decimal)conta.TempoDeCadastroEmAnos / 100;
        }

        //public decimal CalcularPrecoComDesconto(decimal amount, int type, int years)
        //{
        //    decimal result = 0;

        //    decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;

        //    if (type == 1)
        //    {
        //        result = amount;
        //    }
        //    else if (type == 2)
        //    {
        //        result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
        //    }
        //    else if (type == 3)
        //    {
        //        result = (0.7m * amount) - disc * (0.7m * amount);
        //    }
        //    else if (type == 4)
        //    {
        //        result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
        //    }

        //    return result;
        //}
    }
}
