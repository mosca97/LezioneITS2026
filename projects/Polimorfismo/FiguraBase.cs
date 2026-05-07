using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo;

public abstract class FiguraBase
{
    public string Nome { get; set; }

    public string Descrizione()
    {
        return $"Figura: {Nome}";
    }
}
