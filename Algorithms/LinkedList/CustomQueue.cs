using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays.LinkedList
{
    public class CustomQueue<T> : IEnumerable<T>
    {
        private Node<T> _head; // first/head element
        private Node<T> _tail; // last/tail element
        private int _count;  // amount of elements in the list
        
        public void Enqueue(T data)
        {
            var node = new Node<T>(data);

            _tail.Next = node;
            _tail = node;

            if (_head == null)
                _head = _tail;

            _count++;
        }

        public T Deque()
        {
            if (_count == 0)
                throw new InvalidOperationException();

            var result = _head.Data;
            _head = _head.Next;
            
            _count--;
            return result;
        }
        
        public int Count => _count; 

        public bool IsEmpty => _count == 0;
        
        public bool Contains(T data)
        {
            var current = _head;

            // check all elements for the element needed
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;

                current = current.Next;
            }

            return false;
        }

        public Node<T> First => _head ?? throw new InvalidOperationException();
		
        public Node<T> Last => _tail ?? throw new InvalidOperationException();

        public void Clear()
        {
            _head = null;
            _tail = null;
            _count = 0;
        }
        
        IEnumerator IEnumerable.GetEnumerator() 
            => ((IEnumerable)this).GetEnumerator();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            var current = _head;
            
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}