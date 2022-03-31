using MediatR;
using PlanoTestApp.Api.ViewModel;

namespace PlanoTestApp.Api.ViewModel
{
    public class ConvertCommand : IRequest<ConvertResponse>
    {
        public string CurrCode { get; set; }
        public decimal Amount { get; set; }
        public string TargetCode { get; set; }
        
    }
}
