using System;
/// <summary>
/// Generic Class ?
/// </summary>
/// <typeparam name="T">the type to know</typeparam>
class Queue<T>
{
	Node head {get; set;}
	Node tail {get; set;}
	int count {get; set;}
	/// <summary> dequeue </summary>
	public void Dequeue()
	{
		if (head != null)
		{
			Node de = new Node(default(T));
			de = head;
			head = head.next;
			count--;
			return de.value;
		}
		Console.WriteLine("Queue is empty");
		return(default(T));
	}
	/// <summary>
	/// the class method
	/// </summary>
	/// <returns>the type to know</returns>
	public Type CheckType()
	{
		return(typeof(T));
	}
	///<summary> enqueue </summary>
	public void Enqueue(T value) {
		if (head == null)
		{
			Node newH = new Node(value);
			head = tail = newH;
		}
		else{
			Node newT = new Node(value);
			tail.next = newT;
			tail = newT;
		}
		count++;
	}
	/// <summary> counter </summary>
	public int Count(){
		return count;
	}
	/// <summary> Node CLASS </summary>
	public class Node{
		public T value {get; set;}
		public Node next {get; set;}

		///<summary> the value setter ? </summary>
		public Node(T value)
		{
			this.value = value;
		}
	}
}
