public class Auto
{
    public string Marca { get; set; }
    public string Modello { get; set; }
    public int Anno { get; set; }

    public string Descrizione()
    {
        return $"Auto: {Marca} {Modello}, Anno: {Anno}";
    }

    public long Chilometri { get => _chilometri; }
    private long _chilometri;

    public long Guida(long chilometri)
    {
        if (chilometri < 0)
        {
            throw new ArgumentException("I chilometri percorsi non possono essere negativi.");
        }
        _chilometri += chilometri;
        return _chilometri;
    }
}