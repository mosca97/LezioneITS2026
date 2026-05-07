
using Utility;

var auto = new Auto()
{
    Marca = "Fiat",
    Modello = "Panda",
    Anno = 2020
};

Console.WriteLine(auto.Descrizione());
auto.Guida(150);
Console.WriteLine($"Chilometri percorsi: {auto.Chilometri}");

try
{
    auto.Guida(-50);
    Console.WriteLine($"Chilometri percorsi: {auto.Chilometri}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Errore: {ex.Message}");
}