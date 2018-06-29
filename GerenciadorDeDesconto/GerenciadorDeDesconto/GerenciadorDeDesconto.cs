namespace GerenciadorDeDesconto
{
    public class GerenciadorDeDesconto
    {
        private decimal procentagemDeDescontoMaximaBaseadoNoTempoDeConta = 0.05m;

        public decimal AplicarDesconto(decimal valorOriginal, Conta conta)
        {
            decimal descontoBaseadoEmTempoDeConta = CalcularDescontoBaseadoEmTempoDeConta(conta);
            decimal descontoBaseadoEmTipoDeConta = ObterDescontoBaseadoEmTipoDeConta(conta);

            return CalcularPrecoTotalComDescontos(valorOriginal, descontoBaseadoEmTempoDeConta, descontoBaseadoEmTipoDeConta);
        }

        private decimal CalcularDescontoBaseadoEmTempoDeConta(Conta conta)
        {
            return (conta.TempoDeCadastroEmAnos > 5) ? procentagemDeDescontoMaximaBaseadoNoTempoDeConta : (decimal)conta.TempoDeCadastroEmAnos / 100;
        }

        public decimal ObterDescontoBaseadoEmTipoDeConta(Conta conta)
        {
            switch (conta.Tipo)
            {
                case TipoDeConta.Cliente:
                    return 0.1m;

                case TipoDeConta.Vip:
                    return 0.7m;

                case TipoDeConta.Socio:
                    return 0.5m;

                default:
                    return 0m;
            }
        }
        private decimal CalcularPrecoTotalComDescontos(decimal valorOriginal, decimal descontoBaseadoEmTempoDeConta, decimal descontoBaseadoEmTipoDeConta)
        {
            return (valorOriginal - (descontoBaseadoEmTipoDeConta * valorOriginal)) - descontoBaseadoEmTempoDeConta * (valorOriginal - (descontoBaseadoEmTipoDeConta * valorOriginal));
        }
    }
}
