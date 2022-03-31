
using PlanoTestApp.Api.ViewModel;
using System.Threading.Tasks;

namespace PlanoTestApp.Services
{
    public interface IConvertService
    {
        Task<ConvertResponse> ConvertCurrencyAsync(ConvertCommand command);
    }
}
