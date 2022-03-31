using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlanoTestApp.Api.ViewModel;
using PlanoTestApp.Services;

namespace ChatBot.Services.WebHook.Controllers
{
    [Route("[controller]")]
    public class CurrencyController : ControllerBase
    {
        private IConvertService _convertService;

        public CurrencyController(IConvertService convertService)
        {
            _convertService = convertService;
        }


        [HttpPost]
        public async Task<ActionResult<ConvertResponse>> Post([FromBody] ConvertCommand command)
        {
            var result =  await _convertService.ConvertCurrencyAsync(command);
            return Ok(result);
        }
    }
}
