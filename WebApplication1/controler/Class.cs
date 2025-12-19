namespace ConversorDeMoedas.Services
{
    public class CurrencyConverter
    {
        private readonly double dollarRatetoBRL = 5.52;
        private readonly double euroRatetoBRL = 6.47;
        private readonly double brlRatetoDollar = 0.18;
        private readonly double brlRatetoEuro = 0.15;

        public double Convert(double value, int coinOrigem, int coinDestino)
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
