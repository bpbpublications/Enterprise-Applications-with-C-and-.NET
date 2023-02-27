using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class MobilePhone: Product
    {
        public int HeightDimension { get; set; }
        public int WidthDimension { get; set; } 
        public string InternetPlan { get; set; }

        public override void SetPrice()
        {
            this.Price = Convert.ToDecimal(100 * 0.7);
        }
    }
}
