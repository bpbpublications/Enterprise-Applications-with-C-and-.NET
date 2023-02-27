using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal interface IHealthInsurancePlan
    {
        string Name { get; set; }
        decimal Price { get; set; }

        public decimal DicountForGoldPlan()
        {
            return Price * 0.2m;
        }
    }
}
