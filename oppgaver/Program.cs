// See https://aka.ms/new-console-template for more information

using oppgaver;

bool continueTasks = true;
var oppgaveService = new OppgaveService();
while (continueTasks)
{
    Console.WriteLine("Hallo, velg oppgave:");
    Console.WriteLine("1. Fra 100 til 1:");
    Console.WriteLine("2. Tallrekke:");
    Console.WriteLine("3. Sjekk et ord for palindrom:");
    Console.WriteLine("4. Avslutt");
    var selection = int.Parse(Console.ReadLine());

    switch (selection)
    {
        case 1:
            oppgaveService.Print100Til1();
            break;
        case 2:
            oppgaveService.Tallrekke();
            break;
        case 3:
            Console.WriteLine("Skriv ordet som skal sjekkes:");
            var ord = Console.ReadLine();
            if(!string.IsNullOrWhiteSpace(ord))
                oppgaveService.PalindromSjekk(ord);
            break;
        case 4:
            continueTasks = false;
            break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }
    Console.WriteLine("---------------");
}

