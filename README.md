# En Natt På Museet

En Natt På Museet är en konsolapplikation utvecklad med C# och .NET 8.0. Programmet låter användare navigera runt i ett museum och interagera med dess rum och konstverk enligt en fördefinierad karta. Applikationen är designad för att enkelt kunna uppdateras med nya rum eller flytt av konstverk.

## Krav

Innan du kör projektet, säkerställ att följande är installerat på ditt system:

- .NET 8.0 SDK eller senare
- En kodredigerare som Visual Studio (rekommenderas) eller Visual Studio Code

## Paket

Projektet använder följande NuGet-paket, vilka automatiskt återställs vid byggnation av projektet:

- `coverlet.collector` (6.0.0)
- `Microsoft.NET.Test.Sdk` (17.8.0)
- `xunit` (2.5.3)
- `xunit.runner.visualstudio` (2.5.3)

Du behöver inte installera dessa manuellt, de återställs genom att köra `dotnet restore`.

## Setup-instruktioner

### Klona detta repo

```bash
git clone https://github.com/ditt-github-konto/ennattpamuseet.git
cd ennattpamuseet

Återställ nödvändiga paket

dotnet restore

Kör applikationen

dotnet run --project ennattpamuseet

När programmet startar, visas en introduktion om hur du navigerar i museet.
Testning

För att köra enhetstesterna, använd följande kommando:

dotnet test

Funktioner

    Navigera mellan olika rum i museet enligt en logisk karta.
    Se konstverk i varje rum, inklusive deras titel, beskrivning och upphovsmakare.
    Flexibel struktur som gör det enkelt att lägga till nya rum eller flytta konstverk.
    Minst tre implementerade enhetstester för att säkerställa programmets funktionalitet.
