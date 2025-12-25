using ConversorDeMoedas.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConversorDeMoedas.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public decimal Value { get; set; }

        [BindProperty]
        public int CoinOrigem { get; set; }

        [BindProperty]
        public int CoinDestino { get; set; }

        public decimal? Result { get; set; }

        public void OnPost()
        {
            var converter = new CurrencyConverter();
            Result = converter.Convert(Value, CoinOrigem, CoinDestino);
        }
    }
}
