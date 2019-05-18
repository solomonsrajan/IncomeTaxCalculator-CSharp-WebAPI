using System;
using System.Collections.Generic;

namespace Payroll.Models
{
    //All Tax Slot/Rates
    public class TaxRateCollections
    {
        public List<TaxRate> TaxRates { get; set; }

        public TaxRateCollections()
        {
            TaxRates = new List<TaxRate>();
        }
    }

    //Tax Rate model
    public class TaxRate
    {
        public DateTime taxApplicableFrom { get; set; }
        public DateTime? taxApplicableTo { get; set; }
        public double taxableAmountFrom { get; set; }
        public double? taxableAmountTo { get; set; }
        public double notTaxableAmount { get; set; }
        public double baseTaxAmount { get; set; }
        public double increaseTaxAmountBy { get; set; }
        public double increaseTaxAmountFor { get; set; }
        public Int16 calculationFormulaID { get; set; }
    }
}