using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays.LinkedList
{
    public class LinkedList<T> : IEnumerable<T> where T : IComparable
	{
		private Node<T> head; // first/head element
		private Node<T> tail; // last/tail element
		private int _count;  // amount of elements in the list

		public void Add(T data)
		{
			Node<T> node = new Node<T>(data);

			if (head == null)
				head = node;
			else
				// tail has a link on the new node
				tail.Next = node;

			// set new node as a tail
			tail = node;
			_count++;
		}

		public bool Remove(T data)
		{
			Node<T> current = head;
			Node<T> previous = null;

			while (current != null)
			{
				if (current.Data.Equals(data))
				{
					// if node in the middle or in the end of the list
					if (previous != null)
					{
						// next element after previous will be current.Next
						previous.Next = current.Next;

						// if current.Next == null, our element is last
						// change tail variable
						if (current.Next == null)
							tail = previous;
					}
					else
					{
						// if we delete first element
						// change head
						head = head.Next;

						// if list is empty after deleting - tail = null
						if (head == null)
							tail = null;
					}

					_count--;
					return true;
				}

				previous = current;
				current = current.Next;
			}

			return false;
		}

		public void Reverse()
		{
			// starts from head
			Node<T> prevNode = null;
			Node<T> current = head;

			// loop changing pointers to the other side
			while (current != null)
			{
				var next = current.Next;
				current.Next = prevNode;
				prevNode = current;
				current = next;
			}
			
			// prevNode is a 'tail' node, so make it 'head'
			head = prevNode;
		}

		public int Count => _count; 

		public bool IsEmpty => _count == 0;

		public Node<T> First => head;
		
		public Node<T> Last => tail;

		public void Clear()
		{
			head = null;
			tail = null;
			_count = 0;
		}

		public bool Contains(T data)
		{
			Node<T> current = head;

			// check all elements for the element needed
			while (current != null)
			{
				if (current.Data.Equals(data))
					return true;

				current = current.Next;
			}

			return false;
		}

		public T Min() 
		{
			Node<T> current = head;
			T min = current.Data;

			while (current != null)
			{
				if (current.Data.CompareTo(min) < 0 )
					min = current.Data;

				current = current.Next;
			}

			return min;
		}

		public T Max()
		{
			Node<T> current = head;
			T max = current.Data;

			while (current != null)
			{
				if (current.Data.CompareTo(max) > 0)
					max = current.Data;

				current = current.Next;
			}

			return max;
		}

		public void AppendFirst(T data)
		{
			Node<T> node = new Node<T>(data);

			// set current head to the next element
			node.Next = head;

			// make new node a head
			head = node;

			// if list is empty node = head = tail
			if (_count == 0)
				tail = head;

			_count++;
		}
		
		/// <summary>
		/// 'IEnumerable' realization for using 'foreach' loop
		/// </summary>
		///

		IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			Node<T> current = head;

			while (current != null)
			{
				yield return current.Data;
				current = current.Next;
			}
		}
	}
}