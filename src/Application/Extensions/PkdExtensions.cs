using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using String = System.String;

namespace Application.Extensions
{
    public static class PkdExtensions
    {
        public static bool IsCorrect(this List<Pkd> podmiot)
        {
            if (String.IsNullOrEmpty(podmiot.First().Nazwa)
                && (String.IsNullOrEmpty(podmiot.First().KodPKD))) return false;

            return true;
        }
    }
}
