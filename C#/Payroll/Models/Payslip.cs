using System.Collections.Generic;

namespace Payroll.Models
{

    /// <summary>
    /// Response payload
    /// </summary>
    public class PayslipCollections
    {
        public List<Payslip> Payslips { get; set; }
    }

    public class Payslip
    {
        public string EmployeeName { get; set; }
        public string PayPeriod { get; set; }
        public double GrossIncome { get; set; }
        public double IncomeTax { get; set; }
        public double NetIncome { get; set; }
        public double SuperRateAmount { get; set; }
    }
}