namespace ConsoleApp1;

public class Persona
{
    public required string Nome { get; set; }

    public string Saluta()
    {
        return $"Ciao, mi chiamo {Nome}";
    }
}