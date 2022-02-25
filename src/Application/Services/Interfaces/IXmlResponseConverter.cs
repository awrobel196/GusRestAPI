using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface IXmlResponseConverter
    {
        Task<List<T>> Convert<T>(string xmlResponse) where T : class, new();
    }
}
