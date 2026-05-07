namespace ConsoleApp1;

public class Persona
{
    public Persona () { }

    public Persona(string nome, string cognome)
    {
        Nome = nome;
        Cognome = cognome;
    }

    public string Nome { get; set; }
    public string Cognome { get; set; }
    public DateOnly? DataDiNascita { get; set; }

    public string Saluta()
    {
        return $"Ciao, mi chiamo {Nome} {Cognome}";
    }
}