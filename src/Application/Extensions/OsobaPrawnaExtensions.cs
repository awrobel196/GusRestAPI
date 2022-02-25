using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using String = System.String;

namespace Application.Extensions
{
    public static class OsobaPrawnaExtensions
    {
        public static bool IsCorrect(this OsobaPrawna podmiot)
        {
            if (String.IsNullOrEmpty(podmiot.Nazwa)
                && (String.IsNullOrEmpty(podmiot.NIP)
                    && (String.IsNullOrEmpty(podmiot.NumerWRejestrzeEwidencji)))) return false;

            return true;
        }
    }
}
