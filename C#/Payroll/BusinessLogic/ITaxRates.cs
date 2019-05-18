using Payroll.Models;

namespace Payroll.BusinessLogic
{
    interface ITaxRates
    {
        //Get Tax Slot/Rate
        TaxRate GetTaxRate(Employee employee);
    }
}
