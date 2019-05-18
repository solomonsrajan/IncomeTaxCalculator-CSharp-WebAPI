using Payroll.BusinessLogic;
using Payroll.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Payroll.Controllers
{
    public class PayslipController : ApiController
    {
        private readonly ITaxRates _taxRates;
        private readonly IPayslipCalculation _payslipCalculation;

        /// <summary>
        /// Constructor with IoC DI parameters
        /// </summary>
        /// <param name="taxRates">TaxRates for finding Tax Rate slot</param>
        public PayslipController(TaxRates taxRates, PayslipCalculation  payslipCalculation)
        {
            _taxRates = taxRates;
            _payslipCalculation = payslipCalculation;
        }


        /// <summary>
        /// Get call to calculate Tax Rate
        /// </summary>
        /// <param name="employees">Employees contains list of Employee details</param>
        /// <returns>Payslip - Response payload</returns>
        [HttpGet]
        public PayslipCollections CalculatePaySlipForAllEmployees([FromBody] EmployeeCollections employees)
        {
            PayslipCollections payslips = new PayslipCollections();
            payslips.Payslips = new List<Payslip>();

            foreach (Employee employee in employees.Employees)
            {
                TaxRate taxRate = _taxRates.GetTaxRate(employee);
                Payslip payslip = _payslipCalculation.Calculation(employee, taxRate);
                payslips.Payslips.Add(payslip);
            }

            return payslips;
        }
    }
}