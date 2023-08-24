using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EmailValidator.EmailException;

namespace EmailValidator
{
    public class EmailValidator
    {
        public bool Validate(string email)
        {
            if (email.Length < 10)
            {
                throw new ShortEmailException("Email must be minimum 10 character");
            }
            if (!email.EndsWith("@mail.ru"))
            {
                throw new NotAnEmailAdressException("Email must have @mail.ru");
            }

            return true;
        }
    }
}
