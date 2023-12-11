//Opgave klasse Person

//Opret en klasse af navnet Person og give den følgende indhold

//Oplysninger:

//-Fornavn

//- Efternavn

//- Højde

//- Vægt

//Properties: 4 stk der tilgår hver sin oplysning.

//Constructors:

//-Constructor uden parametre

//- Constructor med parametrene Fornavn og Efternavn

//- Constructor med parametre til alle oplysninger

//Metoder:

//-ToString

//- GetBMI - Vægt i kg/(Højde i m * Højde i m)

//- GetFullName

//- SetFullName – med to strings som parameter

//- SetFullName – med en string som parameter, hvis denne indeholder et ord skal det tilskrives LastName, og hvis den indeholder to eller flere ord, skal det sidste tilskrives LastName og resten tilskrives FirstName.

//Opret et array eller liste af Person-objekter og udskriv alle.

//Sortering på en fast property

//Prøv at sortere disse med Array.Sort().

//Dette skulle gå galt.

//Implementer i klassen Person interfacet IComparable, som har metoden CompareTo() og tilret denne så der sammenlignes på LastName.

//Prøv at sortere igen og udskriv alle.

//Sortering på en valgfri property

//For at kunne sortere på Height, oprettes en klasse CompareHeight som implementerer interfacet IComparer, og dennes metode Compare, sådan at det er Height der sammenlignes på.

//Giv et objekt af denne klasse til Sort-metoden og udskriv derefter alle.

//Opret ligeledes klasserne CompareWeight og CompareBMI, så der kan sorteres på Weight eller på BMI.

//Afprøv disse en ad gangen i sorteringer og udskriv alle.

//Sortering på forskellige properties med den samme klasse

//Opret en enum PersonSort med definitionerne CompareHeight, CompareWidth og CompareBMI.

//Opret en klasse ComparePerson der implementerer IComparer, og har en contructor, som modtager en af de 3 enum-definitioner og vælger ud fra dette hvilken property, der skal sammenlignes på.

//Afprøv sortering med et objekt af klassen PersonSort oprettet med constructor som får henholdsvis ComparHeigt, CompareWidth og CompareBMI.

//Udskriv alle for hver sortering.