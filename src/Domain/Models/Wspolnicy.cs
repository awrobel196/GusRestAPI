using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Domain.Models
{
    [XmlType("dane")]
    public class Wspolnicy
    {
        [XmlElement(ElementName = "wspolsc_regonWspolnikSpolki")] public string? RegonSpolki { get; set; }
        [XmlElement(ElementName = "wspolsc_imiePierwsze")] public string? ImiePierwsze { get; set; }
        [XmlElement(ElementName = "wspolsc_imieDrugie")] public string? ImieDrugie { get; set; }
        [XmlElement(ElementName = "wspolsc_nazwisko")] public string? Nazwisko { get; set; }
        [XmlElement(ElementName = "wspolsc_firmaNazwa")] public string? NazwaFirmy { get; set; }
    }
}
