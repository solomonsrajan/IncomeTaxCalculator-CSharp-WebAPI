using Payroll.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace Payroll
{
    public static class UnityConfiguration
    {
        /// <summary>
        /// Register TaxRates and PayslipCalculation
        /// </summary>
        public static void RegisterUnity()
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<ITaxRates, TaxRates>();
            container.RegisterType<IPayslipCalculation, PayslipCalculation>();
        }
    }
}