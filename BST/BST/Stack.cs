
using System;

namespace BSTTree
{


	public class Stack
	{


		public Stack ()
		{
			Elements = new T[Capacity];
		}

		public Stack (int capacity)
		{
			Capacity = capacity;
			Elements = new T[Capacity];
		}


		public void Push (T element)
		{
			if (this.Length == Capacity) {
				IncreaseCapacity ();
			}
			Index++;
			Elements[Index] = element;
		}

		public T Pop ()
		{
			if (this.Length < 1) {
				throw new InvalidOperationException ("Stack is empty");
			}
			
			T element = Elements[Index];
			//Elements[Index] = default(T);
			Index--;
			return element;
		}

		public T Peek ()
		{
			if (this.Length < 1) {
				throw new InvalidOperationException ("Stack is empty");
			}
			
			return Elements[Index];
		}

		private void IncreaseCapacity ()
		{
			Capacity++;
			Capacity *= 2;
			T[] newElements = new T[Capacity];
			Array.Copy (Elements, newElements, Elements.Length);
			Elements = newElements;
		}


		class Program
		{
			static void Main (string[] args)
			{
				//Stack<int> myStack = new Stack<int> ();
				for (int i = 0; i < 50; i++) {
					Console.WriteLine ("Pushing: " + i);
					myStack.Push (i);
					Console.WriteLine ("New Length is: " + myStack.Length);
				}
				
				for (int i = 0; i < 50; i++) {
					Console.WriteLine ("Peeking First: " + myStack.Peek ());
					Console.WriteLine ("Popping: " + myStack.Pop ());
					Console.WriteLine ("New Length is: " + myStack.Length);
				}
				
				try {
					myStack.Peek ();
				} catch (InvalidOperationException ex) {
					Console.WriteLine ("As expected I received this error: " + ex.Message);
				}
				
				try {
					myStack.Pop ();
				} catch (InvalidOperationException ex) {
					Console.WriteLine ("As expected I received this error: " + ex.Message);
				}
				
				Console.WriteLine ("Press the enter key to exit");
				Console.ReadLine ();
			}
		}
		
	}
}


