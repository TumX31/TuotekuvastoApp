# TuotekuvastoApp

Tervetuloa TuotekuvastoApp-projektiin! Tämä projekti on ASP.NET Core -pohjainen verkkosovellus, joka esittelee tuotteita JSON-tiedostosta. Tässä projektissa on käytetty mallin-näkymä-kontrolleri (MVC) -arkkitehtuuria.

## Projektin rakenne

Projektissa on seuraavat tärkeät osat:

- **Controllers**: Tämä kansio sisältää kaikki sovelluksen ohjaimet, jotka käsittelevät käyttäjän pyyntöjä ja palauttavat näkymiä.
  - `HomeController.cs`: Käsittelee pyyntöjä pääsivulta ja tuotteiden sivulta.
  
- **Models**: Tässä kansiossa sijaitsevat tietomallit.
  - `Product.cs`: Määrittelee tuotteiden rakenteen.
  
- **Views**: Tämä kansio sisältää kaikki näkymät, jotka esittävät tietoja käyttäjälle.
  - `Home`-kansio: Sisältää näkymät, kuten `Index.cshtml` ja `Product.cshtml`.
  
- **wwwroot**: Tämä kansio sisältää staattiset tiedostot, kuten CSS- ja JavaScript-tiedostot, sekä JSON-tiedostot.
  - `products.json`: Tiedosto, joka sisältää tuotteiden tiedot.

## Asennusohjeet

1. Luo uusi ASP.NET Core -projekti Visual Studiossa valitsemalla "ASP.NET Core Web Application" (malli-näkymä-kontrolleri).
2. Lisää projektiin tarvittavat NuGet-paketit, kuten Newtonsoft.Json.
3. Lisää JSON-tiedosto `wwwroot`-kansioon ja täytä se tuotteiden tiedoilla.
4. Muokkaa `HomeController.cs` -tiedostoa tuotteiden lukemiseen ja näyttämiseen.

## Koodin esittely

Koodissa on käytetty kommentteja venäjäksi, jotta voit ymmärtää koodin toimintaa paremmin. Kommentit selittävät kunkin osan tarkoituksen ja toiminnan.

## Käyttöohjeet

1. Käynnistä sovellus Visual Studiossa.
2. Navigoi pääsivulle `https://localhost:7172/`.
3. Siirry tuotteiden sivulle `https://localhost:7061/Home/Product` nähdäksesi tuotekatalogin.

## Lisätietoja

Voit tutustua ASP.NET Core -dokumentaatioon saadaksesi lisätietoja ja ohjeita.

