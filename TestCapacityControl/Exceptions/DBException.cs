using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestCapacityControl.Exceptions
{
    public class DBException : ApplicationException
    {
        public DBException(string message) : base(message)
        {

        }
    }
}
