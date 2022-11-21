using System;
using System.Collections;
using System.Collections.Generic;

namespace Arrays.LinkedList
{
    public class CustomLinkedList<T> : IEnumerable<T> where T : IComparable
	{
		private Node<T> head; // first/head element
		private Node<T> tail; // last/tail element
		private int _count;  // amount of elements in the list
		
		public void AddFirst(T data)
		{
			var node = new Node<T>(data);

			// set current head to the next element
			node.Next = head;

			// make new node a head
			head = node;

			// if list is empty node = head = tail
			if (_count == 0)
				tail = head;

			_count++;
		}

		public void AddLast(T data)
		{
			var node = new Node<T>(data);

			if (head == null)
				head = node;
			else
				// tail has a link on the new node
				tail.Next = node;

			// set new node as a tail
			tail = node;
			_count++;
		}

		public bool AddBefore(T dataBefore, T dataAdd)
		{
			Node<T> previous = null;
			var current = head;
			
			var node = new Node<T>(dataAdd);
			
			while (current != null)
			{
				if (current.Data.Equals(dataBefore))
				{
					if (previous != null)
					{
						previous.Next = node;
						node.Next = current;
					}
					else
					{
						node.Next = head;
						head = node;
					}
					
					_count++;
					return true;
				}

				previous = current;
				current = current.Next;
			}

			return false;
		}
		
		public bool AddAfter(T dataAfter, T dataAdd)
		{
			var current = head;
			
			var node = new Node<T>(dataAdd);
			
			while (current != null)
			{
				if (current.Data.Equals(dataAfter))
				{
					if (current == tail)
					{
						tail.Next = node;
						tail = node;
					}
					else
					{
						node.Next = current.Next;
						current.Next = node;
					}

					_count++;
					return true;
				}

				current = current.Next;
			}

			return false;
		}

		public bool Remove(T data)
		{
			var current = head;
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

		public bool RemoveFirst()
		{
			if (head == null)
				return false;
			
			head = head.Next;

			if (head == null)
				tail = null;
			
			_count--;
			return true;
		}
		
		public bool RemoveLast()
		{
			var current = head;
			Node<T> previous = null;

			while (current != null)
			{
				if (current.Next == null && previous != null)
				{
					previous.Next = null;
					tail = previous;

					if (tail == null)
						head = null;

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
			var current = head;

			// loop changing pointers to the other side
			while (current != null)
			{
				var next = current.Next;
				current.Next = prevNode;
				prevNode = current;
				if (current?.Next == null) tail = prevNode;
				current = next;
			}
			
			// prevNode is a 'tail' node, so make it 'head'
			head = prevNode;
		}

		public int Count => _count; 

		public bool IsEmpty => _count == 0;

		public Node<T> First => head ?? new Node<T>(default);
		
		public Node<T> Last => tail ?? new Node<T>(default);

		public void Clear()
		{
			head = null;
			tail = null;
			_count = 0;
		}

		public bool Contains(T data)
		{
			var current = head;

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
			var current = head;
			var min = current.Data;

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
			var current = head;
			var max = current.Data;

			while (current != null)
			{
				if (current.Data.CompareTo(max) > 0)
					max = current.Data;

				current = current.Next;
			}

			return max;
		}

		/// <summary>
		/// 'IEnumerable' realization for using 'foreach' loop
		/// </summary>
		///

		IEnumerator IEnumerable.GetEnumerator() 
			=> ((IEnumerable)this).GetEnumerator();

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			var current = head;

			while (current != null)
			{
				yield return current.Data;
				current = current.Next;
			}
		}
	}
}