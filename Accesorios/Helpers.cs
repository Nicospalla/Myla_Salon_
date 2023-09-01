using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Accesorios
{
    public class Helpers
    {

        public bool soloNum(string texto)
        {
            if (!string.IsNullOrEmpty(texto))
            {

                texto = texto.Replace(",", ".");
                char[] chars = texto.ToCharArray();
                int contador = 0;
                foreach (char s in chars)
                {
                    if (s == '.')
                    {
                        if (contador >= 1)
                            return false;
                        contador++;
                    }
                    else if (s != '.' && contador <= 1 && char.IsDigit(s))
                    {
                        continue;
                    }
                    else { return false; }

                }
            }
            return true;

        }
        public bool validEmail(string mail)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if(Regex.IsMatch(mail, pattern))
                return true;

            return false;
        }
    }
}
