using System;
using System.Collections.Generic;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Implementations
{
    class UpgradeMember : IMembership
    {
        public void PerformAction()
        {
            Console.WriteLine("Member upgraded");
        }

        public void SendEmail()
        {
            Console.WriteLine("Email sent : Member successfully upgraded");
        }
    }
}
