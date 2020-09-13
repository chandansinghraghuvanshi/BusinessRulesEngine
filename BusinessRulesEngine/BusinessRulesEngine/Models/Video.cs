using System;
using System.Collections.Generic;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Models
{
    class Video : IPayment
    {
        public void ExecuteBusinessRules()
        {
            Console.WriteLine("Learning to Ski video, adding free First aid video");
        }
    }
}
