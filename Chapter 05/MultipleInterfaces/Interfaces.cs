using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    public interface IProduct
    {
        int Id { get; set; }    
        string Name { get; set; }
        decimal Price { get; set; }
        int Type { get; set; }
        decimal CalculateDiscount()
        {
            return 3.0m;
        }
    }

    public interface IPhysicalProduct
    {
        public int HeightDimension { get; set; }
        public int WidthDimension { get; set; }
    }

    public interface IOnlineProduct
    {
        int DownloadSize { get; set; }
    }


}
