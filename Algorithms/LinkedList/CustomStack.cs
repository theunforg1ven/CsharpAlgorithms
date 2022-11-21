using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays.LinkedList
{
    public class CustomStack<T> : IEnumerable<T>
    {
        private Node<T> _head; // first/head element
        private int _count; // amount of elements

        public bool IsEmpty => _count == 0;

        public int Count => _count;

        public void Push(T item)
        {
            var node = new Node<T>(item);
            node.Next = _head;
            _head = node;
            _count++;
        }
        
        public T Pop(T item)
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack has no items");
                return default;
            }
                
            var result = _head;
            _head = _head.Next;
            _count--;

            return result.Data;
        }
        
        public T Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Stack has no items");
                return default;
            }
            
            return _head.Data;
        }
        
        public void Clear()
        {
           _head = null;
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