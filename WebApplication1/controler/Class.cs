namespace ConversorDeMoedas.Services
{
    public class CurrencyConverter
    {
        private readonly decimal dollarRatetoBRL = 5.52m;
        private readonly decimal euroRatetoBRL = 6.47m;
        private readonly decimal brlRatetoDollar = 0.18m;
        private readonly decimal brlRatetoEuro = 0.15m;

        public decimal Convert(decimal value, int coinOrigem, int coinDestino)
        {
            if (coinOrigem == 1 && coinDestino == 2)
                return value * dollarRatetoBRL;

            if (coinOrigem == 1 && coinDestino == 3)
                return (value * dollarRatetoBRL) * brlRatetoEuro;

            if (coinOrigem == 2 && coinDestino == 1)
                return value * brlRatetoDollar;

            if (coinOrigem == 2 && coinDestino == 3)
                return value * brlRatetoEuro;

            if (coinOrigem == 3 && coinDestino == 1)
                return (value * euroRatetoBRL) * brlRatetoDollar;

            if (coinOrigem == 3 && coinDestino == 2)
                return value * euroRatetoBRL;

            throw new Exception("Invalid option");
        }
    }
}
