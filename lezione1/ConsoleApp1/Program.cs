using ConsoleApp1;

Console.Write("\nInserisci il tuo nome: ");
var nome = Console.ReadLine();

if (string.IsNullOrWhiteSpace(nome))
{
    Console.WriteLine("Il nome non può essere vuoto.");
    return;
}

var p = new Persona()
{
    Nome = nome
};

Console.WriteLine(p.Saluta());

// TODO: Aggiungere un loop che chiede il nome finche non viene inserito un nome valido (non vuoto o solo spazi).