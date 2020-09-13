using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRulesEngine.Interfaces
{
    interface IMembership : IEmail
    {
        void PerformAction();
    }
}
