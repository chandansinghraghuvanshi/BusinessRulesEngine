using System;
using System.Collections.Generic;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Models
{
    class Membership : IPayment
    {
        private IMembership membership;

        public Membership(IMembership membership)
        {
            this.membership = membership;
        }

        public void ExecuteBusinessRules()
        {
            membership.PerformAction();
            membership.SendEmail();
        }
    }
}
