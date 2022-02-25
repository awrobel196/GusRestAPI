using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Application.Services.Interfaces;
using Domain.Models;

namespace Application.Services
{


    public class XmlResponseConverter : IXmlResponseConverter
    {
        public Task<List<T>> Convert<T>(string xmlResponse) where T : class, new()
        {
            using var reader = new StringReader(xmlResponse);
            XDocument document = XDocument.Load(reader);

            var node = document.Descendants("dane").ToList();
            if (node != null)
            {
                List<T> pkds = new List<T>();

                    foreach (var item in node)
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        using var xmlReader = new StringReader(item.ToString());
                        T result = serializer.Deserialize(xmlReader) as T ?? new T();
                        pkds.Add(result);
                    }

                    return Task.FromResult(pkds);
            }
            return Task.FromResult(new List<T>());
        }
    }
}