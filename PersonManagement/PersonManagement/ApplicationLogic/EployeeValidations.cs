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
            if (Validation.IsNameCorrect(name, 2, 20))
            {
                return true;
            }

            return false;
        }
        public static bool IsLastNameCorrect(string lastname)
        {
            if (lastname != null && lastname.Length > 2 && lastname.Length < 30)
            {
                for (int i = 0; i < lastname.Length; i++)
                {
                    if (!char.IsLetter(lastname[i]))
                    {
                        Console.WriteLine("Check LastName");
                        return false;
                    }
                }
                return true;
            }
            Console.WriteLine("Check LastName");
            return false;
        }
        public static bool IsFatherNameCorrect(string fathername)
        {
            if (fathername != null && fathername.Length > 2 && fathername.Length < 30)
            {
                for (int i = 0; i < fathername.Length; i++)
                {
                    if (!char.IsLetter(fathername[i]))
                    {
                        Console.WriteLine("Check FatherName");
                        return false;
                    }
                }
                return true;
            }
            Console.WriteLine("Check FatherName");
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
                        Console.WriteLine("Check FIN");
                        return false;
                    }
                }
                return true;
            }
            Console.WriteLine("Check FIN");
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
            Console.WriteLine("Check Email");
            return false;

        }

    }
}
