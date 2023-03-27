﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace AssignmentWeek11.Models
{
    /// <summary>
    /// Lookup table containing standard ISO currencies.
    /// </summary>
    public partial class Currency
    {
        public Currency()
        {
            CountryRegionCurrency = new HashSet<CountryRegionCurrency>();
            CurrencyRateFromCurrencyCodeNavigation = new HashSet<CurrencyRate>();
            CurrencyRateToCurrencyCodeNavigation = new HashSet<CurrencyRate>();
        }

        /// <summary>
        /// The ISO code for the Currency.
        /// </summary>
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Currency name.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRateFromCurrencyCodeNavigation { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRateToCurrencyCodeNavigation { get; set; }
    }
}