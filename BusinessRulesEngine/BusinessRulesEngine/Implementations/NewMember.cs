using System;
using System.Collections.Generic;
using System.Text;
using BusinessRulesEngine.Interfaces;

namespace BusinessRulesEngine.Implementations
{
    class NewMember : IMembership
    {
        public void PerformAction()
        {
            Console.WriteLine("New member created");
        }

        public void SendEmail()
        {
            Console.WriteLine("Email sent : New member successfully created");
        }
    }
}
