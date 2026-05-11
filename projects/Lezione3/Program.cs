using Lista;

var lista = new ListaElementi<int>();

lista.Add(6);
var result = lista.GetItems();

foreach(var item in result)
{
    Console.WriteLine(item);
}

var studenti = new ListaElementi<Studente>();

studenti.Add(new Studente()
{
    Nome = "Studente"
});

class Studente
{
    public string Nome { get; set; }
}