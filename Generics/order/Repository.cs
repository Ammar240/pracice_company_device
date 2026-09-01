using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Generics.order;

internal class Repository<T> where T : IEntity
{
    private readonly List<T> _items = new();

    public void Add(T item)
    {
        _items.Add(item);
    }
    public T GetById(int id)
    {
        for (int i = 0; i < _items.Count; i++)
        {
            if (_items[i].Id == id)
            {
                return _items[i];
            } 
        }
        return default;
    }

    public List<T> GetAll()
    {
        return _items;
    }

    public void Remove(int id)
    {
        for (int i = 0; i < _items.Count; i++)
        {
            if (_items[i].Id == id)
            {
                _items.RemoveAt(i);
            }
        }
    }

    //generic method th print value
    public void PrintValue<Tvalue>(Tvalue value)
    {
        Console.WriteLine(value);
    }

    // generic method to get value passed to it 
    public Tvalue GetValue<Tvalue>(Tvalue value)
    {
        return value;
    }
}
