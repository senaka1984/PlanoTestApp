using PlanoTestApp.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanoTestApp.Api.Repository
{
    public interface ICurrencyRepository
    {
        Task<ExchangeRate> GetExchangeRatesAsync(string currCode);
        Task<CurrencyProps> GetCurrencyPropsAsync(string currCode);

    }
}
