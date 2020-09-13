using System;
using System.Collections.Generic;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Models
{
    class Book : IPayment
    {
        private ICommission commission;

        public Book(ICommission commission)
        {
            this.commission = commission;
        }

        public void ExecuteBusinessRules()
        {
            Console.WriteLine("Duplicate packing slip created for royality department created");
            GenerateCommissionPayment();
        }

        private void GenerateCommissionPayment()
        {
            commission.GenerateCommissionPayment();
        }
    }
}
