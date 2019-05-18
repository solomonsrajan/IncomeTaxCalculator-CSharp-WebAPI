using Payroll.Models;
using System;
using System.Linq;

namespace Payroll.BusinessLogic
{
    public class TaxRates: ITaxRates
    {
        /// <summary>
        /// Store Tax Slot/Rates
        /// </summary>
        /// <returns>All Tax Slot/Rates</returns>
        private TaxRateCollections FillTaxRates()
        {
            TaxRateCollections taxRateCollections = new TaxRateCollections();
            taxRateCollections.TaxRates.Add(
                new TaxRate()
                {
                    taxApplicableFrom = new DateTime(2017, 06, 01),
                    taxApplicableTo = null,
                    taxableAmountFrom = 0,
                    taxableAmountTo = 18200,
                    notTaxableAmount = 0,
                    baseTaxAmount = 0,
                    increaseTaxAmountBy = 0,
                    increaseTaxAmountFor = 0,
                    calculationFormulaID = 1
                }
            );

            taxRateCollections.TaxRates.Add(
                new TaxRate()
                {
                    taxApplicableFrom = new DateTime(2017, 06, 01),
                    taxApplicableTo = null,
                    taxableAmountFrom = 18201,
                    taxableAmountTo = 37000,
                    notTaxableAmount = 18200,
                    baseTaxAmount = 0,
                    increaseTaxAmountBy = 19,
                    increaseTaxAmountFor = 1,
                    calculationFormulaID = 1
                }
            );

            taxRateCollections.TaxRates.Add(
                new TaxRate()
                {
                    taxApplicableFrom = new DateTime(2017, 06, 01),
                    taxApplicableTo = null,
                    taxableAmountFrom = 18201,
                    taxableAmountTo = 37000,
                    notTaxableAmount = 18200,
                    baseTaxAmount = 0,
                    increaseTaxAmountBy = 19,
                    increaseTaxAmountFor = 1,
                    calculationFormulaID = 1
                }
            );

            taxRateCollections.TaxRates.Add(
                new TaxRate()
                {
                    taxApplicableFrom = new DateTime(2017, 06, 01),
                    taxApplicableTo = null,
                    taxableAmountFrom = 37001,
                    taxableAmountTo = 87000,
                    notTaxableAmount = 37000,
                    baseTaxAmount = 3572,
                    increaseTaxAmountBy = 32.5,
                    increaseTaxAmountFor = 1,
                    calculationFormulaID = 1
                }
            );

            taxRateCollections.TaxRates.Add(
                new TaxRate()
                {
                    taxApplicableFrom = new DateTime(2017, 06, 01),
                    taxApplicableTo = null,
                    taxableAmountFrom = 87001,
                    taxableAmountTo = 180000,
                    notTaxableAmount = 87000,
                    baseTaxAmount = 19822,
                    increaseTaxAmountBy = 37,
                    increaseTaxAmountFor = 1,
                    calculationFormulaID = 1
                }
            );

            taxRateCollections.TaxRates.Add(
                new TaxRate()
                {
                    taxApplicableFrom = new DateTime(2017, 06, 01),
                    taxApplicableTo = null,
                    taxableAmountFrom = 180001,
                    taxableAmountTo = null,
                    notTaxableAmount = 180000,
                    baseTaxAmount = 54232,
                    increaseTaxAmountBy = 45,
                    increaseTaxAmountFor = 1,
                    calculationFormulaID = 1
                }
            );

            return taxRateCollections;
        }

        /// <summary>
        /// Get the Tax Slot/Rates for the employee
        /// </summary>
        /// <param name="employee"></param>
        /// <returns>TaxRate of the employee</returns>
        public TaxRate GetTaxRate(Employee employee)
        {

            TaxRateCollections taxRateCollections = FillTaxRates();

            TaxRate taxRate =  taxRateCollections.TaxRates.Single(
                                    s => (employee.PaymentStartDate >= s.taxApplicableFrom)
                                    && ((employee.PaymentStartDate <= s.taxApplicableTo) || (s.taxApplicableTo == null))
                                    && (employee.AnnualSalary >= s.taxableAmountFrom)
                                    && ((employee.AnnualSalary <= s.taxableAmountTo) || (s.taxableAmountTo == null))
                                 );
            return taxRate;

        }

    }
}