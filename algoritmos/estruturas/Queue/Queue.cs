namespace algoritmos.estruturas.Queue;

internal class Queue
{
    private Node? _head;
    private Node? _tail;

    public Queue()
    {
        _head = null;
        _tail = null;
    }

    public void Enqueue(int value)
    {
        Node newNode = new Node(value);

        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            _tail = newNode;
        }
    }

    public int Dequeue()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("The queue is empty");
        }

        int value = _head.Value;
        _head = _head.Next;

        return value;
    }

    public int Peek()
    {
        if (_head == null)
        {
            throw new InvalidOperationException("The queue is empty");
        }

        return _head.Value;
    }

    public bool IsEmpty()
    {
        return _head == null;
    }

    public void Print()
    {
        Node? current = _head;

        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }

        Console.WriteLine();
    }   
}
