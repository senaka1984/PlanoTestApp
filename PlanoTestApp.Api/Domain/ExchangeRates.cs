
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlanoTestApp.Api.Domain
{
    [Table("ExchangeRates")]
    public class ExchangeRate
    {
        
        public ExchangeRate()
        { }

        [Key]
        public long ERID { get; set; }
        public string CurrencyCode { get; set; }
        public decimal ExchangeRates { get; set; }
        public bool IsDefault { get; set; }
       
    }
}
