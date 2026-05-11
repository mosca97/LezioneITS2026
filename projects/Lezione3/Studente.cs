using System;
using System.Collections.Generic;
using System.Text;

namespace Lezione3;

public class Studente
{
    public int Matricola { get; set; }
    public string Cognome { get; set; }
    public string Nome { get; set; }
    public List<int> Voti { get; set; }
}