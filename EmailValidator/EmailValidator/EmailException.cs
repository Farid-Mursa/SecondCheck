using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidator
{
    internal class EmailException
    {
        internal class ShortEmailException:Exception
        {
            public ShortEmailException(string message) : base(message)
            {

            }
        }
        internal class NotAnEmailAdressException: Exception
        {
            public NotAnEmailAdressException(string message) : base(message)
            {

            }
        }
    }
}
