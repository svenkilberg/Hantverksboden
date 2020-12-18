# Hantverksboden 2.0

## Ursprung

I början av arbetet var applikation uppbyggd runt ett hårdkodat repository kallat MockCraftRepository. Detta skickades till controllern med dependecy injektion i Startup.cs.

Nu när stöd för databas skulle läggas till märktes tydlig hur smidigt det fungerar när kopplingen till repositoriet ligger i Startup.cs.

Tack vare den hanteringen tyckte jag egentligen inte att det var någon del som var svår att uppdatera. Det tog lite tid att förstå hur InMemoryDatabsase fungerade. Efter att det hade fallit på plats gick resten smidigt.

## Resultat

Nu efter updateringen är applikationen uppbyggd med en AppDbContext för innehållet i databasen. Databasen innehåller en del för föremålen och en del för kategorier av föremål.

I repositoriet för föremål finns en ny metod för att hämta ut en lista med alla föremål i en viss kategori.

För vyerna skapade jag en partial view som generar de kort som visar varje föremål. Detta var en smidig komponent att återanvända på alla ställen som skall visa dessa kort.

## Enhetstester

Första testet heter GetCraftsByCategoryTest. Testet kontrollerar att metoden i repositoriet som listar alla föremål av samma katergori fungerar. Testet anropar först denna metoden med en parameter för vilken kategori som föremålen skall tillhöra. Assert går sedan ingenom listan och kontrollerar att alla föremål har den önskade kategorin.

Andra tetstet heter GetCraftByIdTest. Detta test kontrollerar att en metod i repositoriet för att hämta ut ett föremål med ett specifikt id fungerar. Testet anropar först metoden med en parameter för det önskade föremålet. I assert kontrollreras att det returnerade föremålet har rätt id.

Dessa tester tillhör två metoder som är viktiga för att applikationen skall fungera som det är tänkt. Metoden för att hämta alla föremål i en kategori används redan idag. Metoden för att hämta ut enskilda föremål kommer att bli viktig när funktionalitet för en varukorg och beställning läggs till i framtiden.

När jag lade till projektet för testerna såg jag att det blev en mappstuktrur som jag inte är riktigt nöjd med. För ordningens skull vill jag hellre ha den uppdelning som vi har haft förut med src och test som olika mappar. Jag beslutade att inte ändra på detta så här till inlämningen. Kommer prova att strukturera om det inför nästa del av kursen.
