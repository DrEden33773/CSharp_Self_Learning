namespace CSharp_Self_Learning;

public class OfficialList<T>
{
    const int DefaultCapacity = 4;

    T[] _items;
    int _count;

    public OfficialList(int capacity = DefaultCapacity)
    {
        _items = new T[capacity];
    }

    public int Count => _count; // Property(Read-Only)

    public int Capacity
    {
        get => _items.Length;
        set // contains "value" (input)
        {
            var originCapacity = _items.Length;
            var inputCapicity = value;
            if (inputCapicity < _count)
            {
                Console.WriteLine(
                    format: $"input capacity '{inputCapicity}' is smaller than size '{_count + 1}' , ",
                    arg0: $"but has been automatically reset to that, ",
                    arg1: $"in order to avoid data after _items[{inputCapicity - 1}] beening discarded."
                );
                inputCapicity = _count;
            }
            if (inputCapicity != originCapacity)
            {
                T[] newItems = new T[inputCapicity];
                Array.Copy(
                    sourceArray: _items,
                    sourceIndex: 0,
                    destinationArray: newItems,
                    destinationIndex: 0,
                    length: _count
                );
                _items = newItems;
                _count = inputCapicity;
            }
        }
    } // Property

    public T this[int index] // indexer
    {
        get
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException("input index is out of range.");
            }
            return _items[index];
        }
        set
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException("input index is out of range.");
            }
            _items[index] = value;
        }
    }

    public void Add(T item)
    {
        if (_count == Capacity) Capacity = _count * 2;
        _items[_count] = item;
        _count++;
        OnChanged();
    }
    protected virtual void OnChanged() =>
        Changed?.Invoke(this, EventArgs.Empty);

    public override bool Equals(object other) =>
        Equals(this, other as OfficialList<T>);

    static bool Equals(OfficialList<T> a, OfficialList<T> b)
    {
        if (Object.ReferenceEquals(a, null)) return Object.ReferenceEquals(b, null);
        if (Object.ReferenceEquals(b, null) || a._count != b._count)
            return false;
        for (int i = 0; i < a._count; i++)
        {
            if (!object.Equals(a._items[i], b._items[i]))
            {
                return false;
            }
        }
        return true;
    }

    public event EventHandler Changed;

    public static bool operator ==(OfficialList<T> a, OfficialList<T> b)
        => Equals(a, b);

    public static bool operator !=(OfficialList<T> a, OfficialList<T> b)
        => !Equals(a, b);

    public override int GetHashCode()
    {
        int hash = 0;
        for (int i = 0; i < _count; i++)
        {
            hash ^= _items[i].GetHashCode();
        }
        return hash;
    }

    public static void Example()
    {
        OfficialList<int>? UserList = new();

        // accessor example part
        UserList.Capacity = 100;   // Invokes set accessor
        int i = UserList.Count;    // Invokes get accessor
        int j = UserList.Capacity; // Invokes get accessor
        Console.WriteLine($"i = {i} , j = {j}");

        // indexer example part
        UserList[index: 0] = 1;     // Invokes indexer set accessor
        int k = UserList[0]; // Invokes indexer get accessor
        Console.WriteLine($"k = {k}");
    }
}