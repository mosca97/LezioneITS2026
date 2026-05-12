using System;
using System.Collections.Generic;
using System.Text;

namespace Repository;

public interface ISearchable<TKey>
{
    TKey Id { get; }
}

public class RepositoryClass<T, TKey>
    where T : ISearchable<TKey>
{
    private static readonly List<T> _items = [];

    public void Add(T item)
    {
        _items.Add(item);
    }

    public void Remove(T item)
    {
        _items.Remove(item);
    }

    public void Update(T item)
    {
        var existingItem = GetById(item.Id);
        if (existingItem != null)
        {
            Remove(existingItem);
            Add(item);
        }
    }

    public List<T> GetAll()
    {
        return _items;
    }

    public T? GetById(TKey id)
    {
        return _items.Find(x => EqualityComparer<TKey>.Default.Equals(x.Id, id));
    }
}
