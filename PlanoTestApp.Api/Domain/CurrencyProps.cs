
using System.ComponentModel.DataAnnotations;

namespace PlanoTestApp.Api.Domain
{
    public class CurrencyProps
    {
        public CurrencyProps() { }

        [Key]
        public long CPID { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string CurrencyCode { get; set; }
        public short DecimalPlace { get; set; }

    }
}
