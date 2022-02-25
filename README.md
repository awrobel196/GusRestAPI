# GusRestAPI ![alt text](https://img.shields.io/badge/Wersja-1.0-green)

### I. O GusRestAPI
GusRestAPI pozwala na korzystanie z danych udpstępnianych przez GUS REGON API przy pomocy endpointów Rest API. Aplikacja GusRestAPI zotała wykonana przy pomocy .NET 6 z użyciem wzorca CQRS. Do pobierania danych przy pomocy GusRestAPI wymagany jest klucz api, który można uzyskać kontaktując się z GUS korzystając z adresu email `regon_bir@stat.gov.pl`. Dokładna instrukcja jak uzyskać klucz api znajduje się na stronie https://api.stat.gov.pl/Home/RegonApi

![alt](https://github.com/awrobel196/GusRestAPI/blob/main/logo.jpg?raw=true)
---

### II. Endpointy API
- `Podmiot` - zwraca informację o firmie na podstawie numeru NIP. Jako parametry przyjmuje numer nip (`nip`) oraz klucz api gus (`apiKey`)
- `OsobaPrawna` - zwraca informację na temat osoby prawnej. Jako parametry przyjmuje numer regon (`regon`) oraz klucz api gus (`apiKey`)
- `PKD` - zwraca informację na temat numerów PKD. Jako parametry przyjmuje numer regon (`regon`) oraz klucz api gus (`apiKey`)
- `Wspolnicy` - zwraca informację na temat wspólników. Jako parametry przyjmuje numer regon (`regon`) oraz klucz api gus (`apiKey`)

---

### III. Walidacja parametrów
#### IIIa. Numer NIP
Numer NIP walidowany jest za pomocą metody rozszerzającej `IsCorrectNip()`, która sprawdza czy numer NIP ma odpowiednią ilość cyfr. Jeśli ilość cyfr podanego nipu jest różna od 10, zwracany jest kod `422 - UnprocessableEntity`. Dodatkowo sam NIP walidowany jest w trakcie pobierania danych z GUS API i jeśli w bazie GUS nie istnieje podmiot o takim numerze NIP, zwracany jest kod `404 - Not Found`


#### IIIb. Numer REGON
Numer REGON walidowany jest za pomocą metody rozszerzającej `IsCorrectRegon()`, która sprawdza czy numer REGON ma odpowiednią ilość cyfr. Jeśli ilość cyfr podanego regonu jest różna od 9, zwracany jest kod `422 - UnprocessableEntity`. Dodatkowo sam REGON walidowany jest w trakcie pobierania danych z GUS API i jeśli w bazie GUS nie istnieje podmiot o takim numerze REGON, zwracany jest kod `404 - Not Found`

#### IIIc. ApiKey
Klucz api (`ApiKey`) walidowany jest za pomocą metody `_authorization.Login(apiKey, _uslugaBi)`, któa przy pomocy mechanizmu udostępnionego przez GUS API sprawdza, czy podany klucz api jest poprawny. Jeśli klucz api jest niepoprawny, zwracany zostaje kod `401 - Unauthorized`

---

### IV. Planowany rozwój oprogramowania
- [ ] Obługa ponownego wywołania usług GUS za pomocą Polly
- [ ] Implementacja serwisu przy użyciu minimal API
