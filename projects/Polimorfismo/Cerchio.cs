using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo;

public class Cerchio : IFigura
{
    public double Raggio { get; set; }

    public double CalcolaArea()
    {
        throw new NotImplementedException();
    }

    public double CalcolaPerimetro()
    {
        throw new NotImplementedException();
    }
}

public class Rettangolo : IFigura
{
    public double Base { get; set; }
    public double Altezza { get; set; }

    public double CalcolaArea()
    {
        throw new NotImplementedException();
    }

    public double CalcolaPerimetro()
    {
        throw new NotImplementedException();
    }
}