using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homepage
{
    class EmptyFieldException:Exception
    {
        public EmptyFieldException() : base()
        {

        }
        public EmptyFieldException(String message) : base(message)
        {

        }
    }
}
