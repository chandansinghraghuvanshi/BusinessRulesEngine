using System;
using System.Collections.Generic;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Implementations
{
    class GenerateCommission : ICommission
    {
        public void GenerateCommissionPayment()
        {
            Console.WriteLine("Commission payment to the agent generated");
        }
    }
}
