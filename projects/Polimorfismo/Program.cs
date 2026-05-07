// See https://aka.ms/new-console-template for more information
using Polimorfismo;

Console.WriteLine("Hello, World!");

List<IFigura> figure = [
    new Cerchio { Raggio = 5 },
    new Rettangolo { Base = 4, Altezza = 6 }
];

//// equivalente

//var f = new List<IFigura>();

//f.Add(new Cerchio { Raggio = 5 });
//f.Add(new Rettangolo { Base = 4, Altezza = 6 });

foreach (var figura in figure)
{
    Console.WriteLine($"Area: {figura.CalcolaArea()}");
    Console.WriteLine($"Perimetro: {figura.CalcolaPerimetro()}");
}

/*****************************************************************/