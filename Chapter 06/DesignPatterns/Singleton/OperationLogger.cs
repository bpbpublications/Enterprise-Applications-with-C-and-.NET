using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public sealed class OperationLogger
    {
        private static volatile OperationLogger _instance;
        private static readonly object _lockProperty = new object();

        private OperationLogger()
        {

        }

        public static OperationLogger GetOperationLogger()
        {
            if(_instance == null)
            {
                lock (_lockProperty)
                {
                    if(_instance == null)
                    {
                        _instance = new OperationLogger();
                    }
                }
            }

            return _instance;
        }
    }
}
