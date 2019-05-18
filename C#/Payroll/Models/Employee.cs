using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payroll.Models
{
    /// <summary>
    /// Request payload
    /// </summary>
    public class EmployeeCollections
    {
        public List<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double AnnualSalary { get; set; }
        public double SuperRate { get; set; }
        public DateTime PaymentStartDate { get; set; }
    }
}