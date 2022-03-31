using Microsoft.EntityFrameworkCore;
using PlanoTestApp.Api.Context;
using PlanoTestApp.Api.Domain;
using System.Linq;
using System.Threading.Tasks;

namespace PlanoTestApp.Api.Repository
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly CurrencyContext _context;

        public CurrencyRepository(CurrencyContext context)
        {
            _context = context;
           
        }

        public async Task<ExchangeRate> GetExchangeRatesAsync(string currCode)
        => await _context.ExchangeRates.Where(x => x.CurrencyCode == currCode).FirstOrDefaultAsync();
        

        public async  Task<CurrencyProps> GetCurrencyPropsAsync(string currCode)
        => await _context.CurrencyProps.Where(x => x.CurrencyCode == currCode).FirstOrDefaultAsync();

      
    }
}
