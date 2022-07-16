using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace PersonManagement.ApplicationLogic
{
    internal class EployeeValidations
    {
        public static bool IsNameCorrect(string name)
        {
            if (Validation.IsTextCorrect(name, 2, 20))
            {
                return true;
            }

            return false;
        }
        public static bool IsLastNameCorrect(string lastName)
        {
            if (Validation.IsTextCorrect(lastName,3,30))
            {
                return true;
            }

            return false;
        }
        public static bool IsFatherNameCorrect(string fatherName)
        {
            if (Validation.IsTextCorrect(fatherName, 2,20))
            {
                return true;
            }

            return false;
        }
        public static bool IsFinCorrect(string fin)
        {
            if(fin.Length == 7)
            {
                for(int i = 0; i < 7; i++)
                {
                    if (!(char.IsLetter(fin[i]) || char.IsDigit(fin[i])))
                    {
                       
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
        public static bool IsEmailCorrect(string email)
        {

            if (email != null)
            {
                Regex re = new Regex(@"^((\w[^\W]+)[\.\-]?){1,}\@(([0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3})|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,4}))$");
                if (re.IsMatch(email))
                    return true;
            }
            return false;

        }

    }
}
