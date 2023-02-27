using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }
        void Deliver() { Console.WriteLine("Default implementation"); }
    }
}
