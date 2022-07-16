﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.ApplicationLogic
{
    class AddressValidations
    {
        public static bool IsNameTrue(string name)
        {
            if (Validation.IsNameCorrect(name, 3, 30))
            {
                return true;
            }

            return false;
        }
    }
}
