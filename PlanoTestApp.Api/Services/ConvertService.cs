using PlanoTestApp.Api.Domain;
using PlanoTestApp.Api.Repository;
using PlanoTestApp.Api.ViewModel;
using System;
using System.Threading.Tasks;

namespace PlanoTestApp.Services
{
    public class ConvertService : IConvertService
    {
        public ICurrencyRepository _currencyRepository;

        public ConvertService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }


        public async Task<ConvertResponse> ConvertCurrencyAsync(ConvertCommand command)
        {
            try
            {
                string result = string.Empty;
                ExchangeRate sourceCurrency = await _currencyRepository.GetExchangeRatesAsync(command.CurrCode);
                var targetCurrency = await _currencyRepository.GetExchangeRatesAsync(command.TargetCode);
                var targetCurrencyProps = await _currencyRepository.GetCurrencyPropsAsync(command.TargetCode);

                decimal returnAmount = Math.Round((command.Amount / sourceCurrency.ExchangeRates * targetCurrency.ExchangeRates), targetCurrencyProps.DecimalPlace);
                result = string.Format("{0} {1}", targetCurrencyProps.Symbol, returnAmount.ToString());
                return new ConvertResponse { Result = result };
            }
            catch(Exception Ex)
            {
                return new ConvertResponse { Result = "Error" };
            }
        }
    }
}
