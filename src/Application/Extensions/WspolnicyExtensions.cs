using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using String = System.String;

namespace Application.Extensions
{
    public static class WspolnicyExtensions
    {
        public static bool IsCorrect(this List<Wspolnicy> podmiot)
        {
            if (String.IsNullOrEmpty(podmiot.First().RegonSpolki)
                && (String.IsNullOrEmpty(podmiot.First().ImiePierwsze))) return false;

            return true;
        }
    }
}
