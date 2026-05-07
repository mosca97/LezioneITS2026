using ConsoleApp1;

Console.Write("\nInserisci il tuo nome: ");
var nome = Console.ReadLine();

Console.Write("\nInserisci il tuo cognome: ");
var cognome = Console.ReadLine();

Console.Write("\nInserisci la tua data di nascita (opzionale) (yyyy-MM-dd): ");
var dataDiNascita = Console.ReadLine();

var p = new Persona();

p.Nome = nome;
p.Cognome = cognome;

if (dataDiNascita != null)
{
    p.DataDiNascita = DateOnly.Parse(dataDiNascita);
}

var p2 = new Persona
{
    Nome = nome,
    Cognome = cognome
};

Console.WriteLine(p.Saluta());

// TODO: Aggiungere un loop che chiede il nome finche non viene inserito un nome valido (non vuoto o solo spazi).