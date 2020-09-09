# Cinema Database
Som afslutning på OOP skal I løse en opgave, hvor `Microsoft SQL Server` kombineres med `C#` konsol applikation.
## Opgavebeskrivelse
I `Microsoft SQL Server` skal der oprettes databasen Biograf. Biograf skal minimum indeholde 2 tabeller `Kunder` og `Bestillinger`.

Tabellen `Kunder` skal indeholde oplysninger på kunden: navn, kontaktoplysninger, kundetype og tilsvarende.
Tabellen `Bestillinger`, skal indeholde oplysning om kunden, oplysning om dato og tid for forestillingen, hvilken film, antal pladser og om det er en reservation eller billetter er betalt.

Fra `C#` skal der være forbindelse til databasen, så der kan kodes `CRUD` i programmet.

### Som minimum skal man kunne:
- Liste alle kunder i tabellen
- Man skal kunne oprette, rette eller slette en kunde (hvad med eventuelle bestillinger?)
- Man skal kunne vælge få listen sorteret efter efternavn
- For en specifik kunde skal man kunne se alle bestillinger (på liste-form)
 

### Ekstraopgaver:
- Implementer film-tabel, som Bestillinger kan trække på
- Man skal kunne foretage billet-bestilling i applikationen
- Man skal kunne se alle oplysninger for en bestilling, og man skal eventuelt kunne rette udvalgte oplysninger
