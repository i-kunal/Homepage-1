using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homepage
{
    class ValidTextException:Exception
    {
        public ValidTextException():base()
        {

        }
        public ValidTextException(String message):base(message)
        {

        }
    }
}
