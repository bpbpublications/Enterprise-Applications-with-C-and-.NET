using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationService
{
    internal class IntegrationException: Exception
    {
        public int CustomCode { get; set; }
    }
}
