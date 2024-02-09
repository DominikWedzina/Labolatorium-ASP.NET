# Labolatorium-ASP.NET
Dokumentacja Projektu Labolatorium3_App
Lista wykorzystanych technologii

    ASP.NET Core: 6.0
    Baza danych: SQLite i SQL Server (wersje użyte w projekcie to te dostępne z pakietami NuGet w wersji 6.0.26)
    Dodatkowe biblioteki:
        Microsoft.AspNetCore.Identity.EntityFrameworkCore (6.0.26)
        Microsoft.AspNetCore.Identity.UI (6.0.26)
        Microsoft.EntityFrameworkCore.Sqlite (6.0.26)
        Microsoft.EntityFrameworkCore.SqlServer (6.0.26)
        Microsoft.EntityFrameworkCore.Tools (6.0.26)
        Microsoft.VisualStudio.Web.CodeGeneration.Design (6.0.16)

Dane przykładowych użytkowników

W aplikacji zdefiniowano dwa główne typy kont użytkowników: administratora i standardowego użytkownika. Oto szczegóły dostępu dla tych kont:
Konto administratora

    Login (e-mail): admin@example.com
    Hasło: 1234abcd!

Administrator posiada pełne uprawnienia do zarządzania aplikacją, w tym dostęp do wszystkich danych i funkcji administracyjnych.
Konto standardowego użytkownika

    Login (e-mail): user@example.com
    Hasło: user1234PASSWORD!@#$

Proces uruchomienia aplikacji w wersji deweloperskiej
Wymagane oprogramowanie

    Visual Studio 2022 lub nowsze z zainstalowanym .NET 6.0 SDK
    SQL Server lub narzędzie do zarządzania SQLite, w zależności od wybranej bazy danych

Konfiguracja środowiska

    Sklonuj repozytorium projektu do lokalnego katalogu.
    Otwórz rozwiązanie Labolatorium3_App.sln w Visual Studio.

Migracje bazy danych

Aplikacja korzysta z Entity Framework Core, co wymaga przeprowadzenia migracji bazy danych, aby zainicjować schemat bazy danych. 
Uruchom następujące komendy w terminalu znajdując się w katalogu projektu Data:

dotnet tool install --global dotnet-ef
dotnet ef migrations add InitialCreate
dotnet ef database update
Uruchomienie projektu

    Po skonfigurowaniu bazy danych, wybierz projekt startowy w Visual Studio.
    Użyj przycisku "Debuguj" lub naciśnij F5, aby uruchomić aplikację. Visual Studio powinno automatycznie otworzyć przeglądarkę z uruchomioną aplikacją.
