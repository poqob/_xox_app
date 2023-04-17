using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _xox_app.util
{
    public static class InputController
    {
        public static bool controll(String input)
        { 
            return Regex.IsMatch(input, @"^\d{8}$");
        }
    }
}
