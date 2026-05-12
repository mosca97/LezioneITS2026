// ── SelectMany ──────────────────────────────────────────────────────────────
// Appiattisce una collezione di collezioni in una sequenza unica.
// Scenario: ogni classe ha una lista di studenti; vogliamo tutti gli studenti.
var classi = new List<Classe>()
{
    new() { Nome = "Classe A", Studenti = new List<string> { "Alice", "Bob", "Carlo" } },
    new() { Nome = "Classe B", Studenti = new List<string> { "Diana", "Enrico" } },
    new() { Nome = "Classe C", Studenti = new List<string> { "Francesca", "Giorgio", "Hana" } },
};

IEnumerable<string> tuttiGliStudenti = classi.SelectMany(c => c.Studenti);

Console.WriteLine("=== SelectMany ===");
foreach (var studente in tuttiGliStudenti)
    Console.WriteLine($"  {studente}");

// ── Zip ─────────────────────────────────────────────────────────────────────
// Combina due sequenze elemento per elemento in coppie (o in un valore calcolato).
// Scenario: accoppiare nomi e voti di uno studente.

List<string> nomi = ["Alice", "Bob", "Carlo", "Diana"];
List<int> voti = [28, 30, 25, 27];

var risultati = nomi.Zip(voti, (nome, voto) => $"{nome}: {voto}/30");

Console.WriteLine("\n=== Zip ===");
foreach (var r in risultati)
    Console.WriteLine($"  {r}");

// ── DistinctBy ───────────────────────────────────────────────────────────────
// Restituisce elementi distinti in base a una proprietà chiave.
// Scenario: rimuovere studenti duplicati confrontando solo il cognome.

var studenti = new List<Studente>()
{
    new() { Nome = "Alice",    Cognome = "Rossi"  },
    new() { Nome = "Marco",    Cognome = "Rossi"  },   // stesso cognome di Alice
    new() { Nome = "Diana",    Cognome = "Verdi"  },
    new() { Nome = "Enrico",   Cognome = "Bianchi"},
    new() { Nome = "Federica", Cognome = "Verdi"  },   // stesso cognome di Diana
};

var cognomiDistinti = studenti.DistinctBy(s => s.Cognome);

Console.WriteLine("\n=== DistinctBy ===");
foreach (var s in cognomiDistinti)
    Console.WriteLine($"  {s.Nome} {s.Cognome}");

// ── Chunk ────────────────────────────────────────────────────────────────────
// Divide una sequenza in gruppi (chunk) di dimensione fissa.
// Scenario: paginare una lista di 10 studenti in gruppi da 3.

List<string> listaStudenti = ["A", "B", "C", "D", "E", "F", "G", "H", "I", "L"];

Console.WriteLine("\n=== Chunk (pagine da 3) ===");
int pagina = 1;
foreach (var chunk in listaStudenti.Chunk(3))
{
    Console.WriteLine($"  Pagina {pagina++}: {string.Join(", ", chunk)}");
}

// ── GroupBy ──────────────────────────────────────────────────────────────────
// Raggruppa gli elementi in base a una chiave.
// Scenario: raggruppare studenti per anno di corso.

var iscritti = new List<Studente>()
{
    new() { Nome = "Alice",   Anno = 1 },
    new() { Nome = "Bob",     Anno = 2 },
    new() { Nome = "Carlo",   Anno = 1 },
    new() { Nome = "Diana",   Anno = 3 },
    new() { Nome = "Enrico",  Anno = 2 },
    new() { Nome = "Flavia",  Anno = 1 },
};

var perAnno = iscritti.GroupBy(s => s.Anno);

Console.WriteLine("\n=== GroupBy ===");
foreach (var gruppo in perAnno)
{
    Console.WriteLine($"  Anno {gruppo.Key}:");
    foreach (var s in gruppo)
        Console.WriteLine($"    - {s.Nome}");
}

Console.ReadKey();

public class Classe
{
    public string Nome { get; set; }
    public List<string> Studenti { get; set; }
}

public class Studente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int Anno { get; set; }
}

public record StudenteRecord(string Nome, string Cognome, int Anno);