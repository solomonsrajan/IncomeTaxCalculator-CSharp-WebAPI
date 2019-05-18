using Payroll.Models;
using System;

namespace Payroll.BusinessLogic
{
    public class PayslipCalculation: IPayslipCalculation
    {
        /// <summary>
        /// Tax calculation
        /// </summary>
        /// <param name="employee">Individual employee detail</param>
        /// <param name="taxRate">Tax Slab/Rate of the employee</param>
        /// <returns>Payslip - Response payload</returns>
        public Payslip Calculation(Employee employee, TaxRate taxRate)
        {
            Payslip payslip = new Payslip();

            payslip.EmployeeName = employee.FirstName + " " + employee.LastName;
            payslip.PayPeriod = employee.PaymentStartDate.ToString("dd/MM/yyyy");

            payslip.GrossIncome = Math.Round(employee.AnnualSalary / 12);
            payslip.IncomeTax = Math.Round((taxRate.baseTaxAmount + (employee.AnnualSalary - taxRate.notTaxableAmount) * (taxRate.increaseTaxAmountBy / 100)) / 12);
            payslip.NetIncome = Math.Round(payslip.GrossIncome - payslip.IncomeTax);
            payslip.SuperRateAmount = Math.Round(payslip.GrossIncome * (employee.SuperRate / 100));

            return payslip;
        }


    }
}