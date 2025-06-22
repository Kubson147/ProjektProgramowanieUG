# Prosta Aplikacja Pogodowa w C#

Projekt zaliczeniowy stworzony w ramach drugiego semestru studiów na kierunku Informatyka i Ekonometria.

## Opis Projektu

Celem projektu było stworzenie prostej aplikacji okienkowej w C#, która komunikuje się z zewnętrznym API. Postanowiłem zbudować aplikację pogodową, która pobiera aktualne dane dla podanego przez użytkownika miasta i wyświetla je w czytelny sposób.

Aplikacja łączy się z serwisem **OpenWeatherMap**, pobiera dane w formacie JSON, a następnie przetwarza je i prezentuje w interfejsie graficznym. Projekt jest w pełni skonfigurowany i gotowy do uruchomienia.

## Technologie i Narzędzia

* **Język:** C#
* **Platforma:** .NET Framework
* **Interfejs:** Windows Forms
* **Środowisko programistyczne:** Visual Studio 2022
* **Kluczowe biblioteki:**
    * `Newtonsoft.Json` - do wydajnego przetwarzania danych w formacie JSON.
* **API zewnętrzne:**
    * OpenWeatherMap Current Weather Data API

## Główne Funkcjonalności

* Wyszukiwanie aktualnej pogody dla dowolnego miasta na świecie.
* Wyświetlanie kluczowych informacji:
    * Temperatura (w stopniach Celsjusza)
    * Opis słowny warunków pogodowych (w języku polskim)
    * Dynamicznie wczytywana ikona graficzna pogody
* Prezentacja szczegółowych danych:
    * Temperatura odczuwalna
    * Ciśnienie atmosferyczne (w hPa)
    * Wilgotność (w %)
    * Prędkość wiatru (w m/s)
* Podstawowa obsługa błędów (np. w przypadku nieznalezienia miasta).

## Jak uruchomić projekt?

Aplikacja jest w pełni skonfigurowana i zawiera klucz API niezbędny do działania. Aby ją uruchomić, wystarczy:

1.  **Sklonować repozytorium** na swój komputer.
    ```bash
    git clone [https://github.com/Kubson147/ProjektProgramowanieUG](https://github.com/Kubson147/ProjektProgramowanieUG)
    ```
    2.  **Otworzyć plik rozwiązania** (`.sln`) w programie Visual Studio 2022.

3.  **Uruchomić aplikację**, naciskając przycisk **"Start"** lub klawisz **F5**. Visual Studio automatycznie przywróci potrzebne pakiety i skompiluje projekt.

## Struktura Plików

* `Projekt/` - Główny folder projektu C#.
* `Projekt/Form1.cs` - Główny plik z logiką aplikacji.
* `Projekt/Form1.Designer.cs` - Kod generowany automatycznie, opisujący wygląd interfejsu.
* `Projekt/Program.cs` - Punkt startowy aplikacji.
* `Projekt/packages.config` - Plik z listą zewnętrznych bibliotek NuGet.

## Autor

**[Jakub Dolecki]**
