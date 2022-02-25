using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Domain.Models
{
    [XmlType("dane")]
    public class OsobaPrawna
    {
        [XmlElement(ElementName = "praw_regon9")] public string? Regon { get; set; }
        [XmlElement(ElementName = "praw_nip")] public string? NIP { get; set; }
        [XmlElement(ElementName = "praw_statusNip")] public string? StatusNIP { get; set; }
        [XmlElement(ElementName = "praw_nazwa")] public string? Nazwa { get; set; }
        [XmlElement(ElementName = "praw_nazwaSkrocona")] public string? NazwaSkrocona { get; set; }
        [XmlElement(ElementName = "praw_numerWRejestrzeEwidencji")] public string? NumerWRejestrzeEwidencji { get; set; }
        [XmlElement(ElementName = "praw_dataWpisuDoRejestruEwidencji")] public string? DataWpisuDoRejestruEwidencji { get; set; }
        [XmlElement(ElementName = "praw_dataPowstania")] public string? DataPowstania { get; set; }
        [XmlElement(ElementName = "praw_dataRozpoczeciaDzialalnosci")] public string? DataRozpoczeciaDzialalnosci { get; set; }
        [XmlElement(ElementName = "praw_dataWpisuDoRegon")] public string? DataWpisuDoRegon { get; set; }
        [XmlElement(ElementName = "praw_dataZawieszeniaDzialalnosci")] public string? DataZawieszeniaDzialanosci { get; set; }
        [XmlElement(ElementName = "praw_dataWznowieniaDzialalnosci")] public string? DataWznowieniaDzialalnosci { get; set; }
        [XmlElement(ElementName = "praw_dataZaistnieniaZmiany")] public string? DataZaistenieniaZmiany { get; set; }
        [XmlElement(ElementName = "praw_dataZakonczeniaDzialalnosci")] public string? DataZakonczeniaDzialanosci { get; set; }
        [XmlElement(ElementName = "praw_dataSkresleniaZRegon")] public string? DataSkrzesleniaZRegon { get; set; }
        [XmlElement(ElementName = "praw_dataOrzeczeniaOUpadlosci")] public string? DataOrzeczeniaOUpadlosci { get; set; }
        [XmlElement(ElementName = "praw_dataZakonczeniaPostepowaniaUpadlosciowego")] public string? DataZakonczeniaPostepowaniaUpadlosciowego { get; set; }
        [XmlElement(ElementName = "praw_adSiedzKraj_Symbol")] public string? SymbolKrajuSiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzWojewodztwo_Symbol")] public string? SymbolWojewodztwaSiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzPowiat_Symbol")] public string? SymbolPowiatuSiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzGmina_Symbol")] public string? SymbolGminySiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzKodPocztowy")] public string? KodPocztowySiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzMiejscowoscPoczty_Symbol")] public string? SymbolMIejscowosciPocztySiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzMiejscowosc_Symbol")] public string? SymbolMiejscowosciSiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzUlica_Symbol")] public string? SymbolUlicySiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzNumerNieruchomosci")] public string? NumerNieruchomosciSiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzNumerLokalu")] public string? NumerLokaluSiedziby { get; set; }
        [XmlElement(ElementName = "praw_numerTelefonu")] public string? NumerTelefonu { get; set; }
        [XmlElement(ElementName = "praw_numerWewnetrznyTelefonu")] public string? NumerWewnetrznyTelefonu { get; set; }
        [XmlElement(ElementName = "praw_numerFaksu")] public string? NumerFaksu { get; set; }
        [XmlElement(ElementName = "praw_adresEmail")] public string? AdresEmail { get; set; }
        [XmlElement(ElementName = "praw_adresStronyinternetowej")] public string? AdresWWW { get; set; }
        [XmlElement(ElementName = "praw_adSiedzKraj_Nazwa")] public string? NazwaKrajuSiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzWojewodztwo_Nazwa")] public string? NazwaWojewodztwaSiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzPowiat_Nazwa")] public string? NazwaPowiatuSiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzGmina_Nazwa")] public string? NazwaGminySiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzMiejscowosc_Nazwa")] public string? NazwaMiejscowosciSiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzMiejscowoscPoczty_Nazwa")] public string? NazwaMiejscowosciPosztySiedziby { get; set; }
        [XmlElement(ElementName = "praw_adSiedzUlica_Nazwa")] public string? NazwaUlicySziedziby { get; set; }
        [XmlElement(ElementName = "praw_podstawowaFormaPrawna_Symbol")] public string? PodstawowySymbolFormyPrawnej { get; set; }
        [XmlElement(ElementName = "praw_szczegolnaFormaPrawna_Symbol")] public string? SzczegolowySymbolFormyPrawnej { get; set; }
        [XmlElement(ElementName = "praw_formaFinansowania_Symbol")] public string? SymbolFormyFinansowania { get; set; }
        [XmlElement(ElementName = "praw_organZalozycielski_Symbol")] public string? SymbolOrganuZalozycielskiego { get; set; }
        [XmlElement(ElementName = "praw_organRejestrowy_Symbol")] public string? SymbolOrganuRejestrowego { get; set; }
        [XmlElement(ElementName = "praw_rodzajRejestruEwidencji_Symbol")] public string? SymbolRodzajuRejestruEwidencji { get; set; }
        [XmlElement(ElementName = "praw_podstawowaFormaPrawna_Nazwa")] public string? PodstawowaNazwaFormyPrawnej { get; set; }
        [XmlElement(ElementName = "praw_szczegolnaFormaPrawna_Nazwa")] public string? SzczegolowaNazwaFormyPrawnej { get; set; }
        [XmlElement(ElementName = "praw_formaFinansowania_Nazwa")] public string? NazwaFormyFinansowania { get; set; }
        [XmlElement(ElementName = "praw_formaWlasnosci_Nazwa")] public string? NazwaFormyWlasnosci { get; set; }
        [XmlElement(ElementName = "praw_organZalozycielski_Nazwa")] public string? NazwaOrganuZalozycielskiego { get; set; }
        [XmlElement(ElementName = "praw_organRejestrowy_Nazwa")] public string? NazwaOrganuRejestrowego { get; set; }
        [XmlElement(ElementName = "praw_rodzajRejestruEwidencji_Nazwa")] public string? NazwaRodzajuRejestruEwidencji { get; set; }
        [XmlElement(ElementName = "praw_liczbaJednLokalnych")] public string? LiczbaJednostekLokalnych { get; set; }

    }
}
