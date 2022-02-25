using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using String = System.String;

namespace Application.Extensions
{
    public static class PodmiotExtensions
    {
        public static bool IsCorrect(this Podmiot podmiot)
        {
            if (String.IsNullOrEmpty(podmiot.Nazwa)
                && (String.IsNullOrEmpty(podmiot.Regon)
                    && (String.IsNullOrEmpty(podmiot.StatusNip)))) return false;

            return true;
        }
    }
}
