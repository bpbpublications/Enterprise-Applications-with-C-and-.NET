using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class MedicalPlanForPrivateCompanies: IHealthInsurancePlan
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        
    }
}
