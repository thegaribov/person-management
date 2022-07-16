﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManagement.ApplicationLogic
{
    class Validation
    {
        public static bool IsNameCorrect(string name, int startLength, int endLength)
        {
            if (name != null & name.Length > startLength & name.Length < endLength)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (!char.IsLetter(name[i]))
                    {
                        Console.WriteLine("Check Name");
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
