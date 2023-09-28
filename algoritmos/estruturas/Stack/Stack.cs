
namespace algoritmos.estruturas.Stack
{
    internal class Stack
    {
        private Node? _top;
        private int _size;

        public Stack()
        {
            _top = null;
            _size = 0;
        }

        public void Push(int value)
        {
            Node newNode = new Node(value);

            if (_top == null)
            {
                _top = newNode;
            }
            else
            {
                newNode.Next = _top;
                _top = newNode;
            }
            _size++;
        }

        public int Pop()
        {
            if (_top == null)
            {
                throw new InvalidOperationException("The stack is empty");
            }

            int value = _top.Value;
            _top = _top.Next;
            _size--;

            return value;
        }

        public int Peek()
        {
            if (_top == null)
            {
                throw new InvalidOperationException("the stack is empty");
            }

            return _top.Value;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public int Size()
        {
            return _size;
        }

    }
}
