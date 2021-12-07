#Labb2 

##Denna Labb är endast utförd utav mig - Sebastian Romedahl

Först och främst har jag löst ut de privata metoderna för emailhantering och loggning 
till två egna klasser med tillhörande interface för att underlätta implementationen. 
Jag valde att göra detta så att man framöver enkelt kan lägga till funktionalitet för loggning mot t.ex databas.

För själva orderhanteringen har jag skapat tre separata klasser för de olika order-typerna.
Dessa ärver av ett och samma interface som bara har en metod - nämligen Process metoden.
För att bygga bort det if-statement vi hade i klassen så gjorde jag såhär. 
Jag valde sen att skapa en lista av dessa olika ordertyper (interfaces) och beroende på vilken som är aktuell för given order så körs endast den.
Det finns en liten risk här, skickas en order in med en fjärde ordertyp - så returnerar singleordefault null.
Och det vill säga att för varje ny ordertyp behöver vi skapa en ny klass och lägga till i listan. Kanske inte helt optimalt.

Det ligger en if-sats kvar i klassen metoden ProcessOrder, det blir lättare för mig att se vad som sker med den. Kanske det går att lösa på annat sätt?

Alternativet som jag tänkte på istället för skapandet av lista var att göra en form av "Chain-reaction" av metoder.
Skapa en abstract klass som de olika ordertyperna får ärva av - ha någon form av koll där och om den inte uppfyller kraven, skicka till nästa osv.
Detta hade nog resulterat i något snyggare kod, men jag fick inte helt till det.