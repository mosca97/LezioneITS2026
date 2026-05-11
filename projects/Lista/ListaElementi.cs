namespace Lista;

/// <summary>
/// Represents a generic collection of elements that provides methods to add items and retrieve the current list.
/// </summary>
/// <typeparam name="T">The type of elements contained in the collection.</typeparam>
public class ListaElementi<T>
{
    public List<T> Items { get; set; } = [];

    public void Add(T item)
    {
        Items.Add(item);
    }

    public List<T> GetItems()
    {
        return Items;
    }
}
