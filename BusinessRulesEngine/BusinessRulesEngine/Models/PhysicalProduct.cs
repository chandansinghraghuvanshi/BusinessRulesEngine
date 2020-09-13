using System;
using System.Collections.Generic;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Models
{
    class PhysicalProduct : IPayment
    {
        private ICommission commission;

        public PhysicalProduct(ICommission commission)
        {
            this.commission = commission;
        }

        public void ExecuteBusinessRules()
        {
            Console.WriteLine("Packing slip for shipping generated");
            GenerateCommissionPayment();
        }

        private void GenerateCommissionPayment()
        {
            commission.GenerateCommissionPayment();
        }
    }
}
