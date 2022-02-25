using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gus;

namespace Application.Query
{
    public class BaseQuery
    {
        public string? Regon;
        public string? Nip;
        public UslugaBIRzewnPublClient GusServices = default!;
        public virtual string? NazwaRaportu { get; set; }
    }
}
