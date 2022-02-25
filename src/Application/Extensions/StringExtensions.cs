using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Extensions
{
    public static class StringExtensions
    {
        public static bool IsCorrectNip(this string nip)
        {
            if (nip.Length != 10) return false;
            return true;
        }

        public static bool IsCorrectRegon(this string regon)
        {
            if (regon.Length != 9) return false;
            return true;
        }
    }
}
