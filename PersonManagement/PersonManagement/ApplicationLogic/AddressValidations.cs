using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.ApplicationLogic
{
    class AddressValidations
    {
        public static bool IsNameCorrect(string name)
        {
            if (Validation.IsTextCorrect(name, 3, 30))
            {
                return true;
            }

            return false;
        }
    }
}
