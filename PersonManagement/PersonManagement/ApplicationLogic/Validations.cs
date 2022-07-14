using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.ApplicationLogic
{
    internal class Validations
    {
        public bool IsNameTrue(string name)
        {
            if(name != null && name.Length > 2 && name.Length < 30)
            {
                for(int i = 0; i < name.Length; i++)
                {
                    if (!char.IsLetter(name[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool IsLastNameTrue(string lastname)
        {
            if (lastname != null && lastname.Length > 2 && lastname.Length < 30)
            {
                for (int i = 0; i < lastname.Length; i++)
                {
                    if (!char.IsLetter(lastname[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool IsFatherNameTrue(string fathername)
        {
            if (fathername != null && fathername.Length > 2 && fathername.Length < 30)
            {
                for (int i = 0; i < fathername.Length; i++)
                {
                    if (!char.IsLetter(fathername[i]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public bool IsFinTrue(string fin)
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
            }
            return true;
        }
        public bool IsEmailTrue(string email)
        {
            
            if (email != null)
            {
                for (int i = 0; i < email.Length; i++)
                {
                    if (email[i] == '@')
                    {
                        return true;

                    }
                }
            }
            return false;
        }

    }
}
