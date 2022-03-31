using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PlanoTestApp.Api.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PlanoTestApp.Api.Context
{
    public class CurrencyContext : DbContext
    {
        public CurrencyContext(DbContextOptions<CurrencyContext> options) : base(options)
        { }

        public DbSet<ExchangeRate> ExchangeRates { get; set; }
        public DbSet<CurrencyProps> CurrencyProps { get; set; }

       

    }
}

