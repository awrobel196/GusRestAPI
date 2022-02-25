using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Domain.Models
{
    [XmlType("dane")]
    public class Pkd
    {
        [XmlElement(ElementName = "praw_pkdKod")] public string? KodPKD { get; set; }
        [XmlElement(ElementName = "praw_pkdNazwa")] public string? Nazwa { get; set; }
        [XmlElement(ElementName = "praw_pkdPrzewazajace")] public string? CzyPrzewazajace { get; set; }
    }
}
