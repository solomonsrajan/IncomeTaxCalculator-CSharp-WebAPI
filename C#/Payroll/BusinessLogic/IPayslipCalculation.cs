using Payroll.Models;

namespace Payroll.BusinessLogic
{
    interface IPayslipCalculation
    {
        //Tax Calculation
        Payslip Calculation(Employee employee, TaxRate taxRate);
    }
}
