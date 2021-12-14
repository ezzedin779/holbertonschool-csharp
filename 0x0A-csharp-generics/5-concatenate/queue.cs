﻿using System;
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
	public T Dequeue()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return(default(T));
		}
		Node de = new Node(default(T));
		de = head;
		head = head.next;
		count--;
		return de.value;
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
	/// <summary> Peek ? </summary>
	public T Peek()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return (default(T));
		}
		return head.value;
	}
	/// <summary> counter </summary>
	public int Count(){
		return count;
	}
	/// <summary> Print the head </summary>
	public void Print()
	{
		if (head == null)
			Console.WriteLine("Queue is empty");
		while (head != null)
		{
			Console.WriteLine(head.value);
			head = head.next;
		}
	}
	/// <summary> concatenate </summary>
	public String Concatenate()
	{
		if (head == null)
		{
			Console.WriteLine("Queue is empty");
			return (null);
		}
		if (typeof(T) != typeof(String) && typeof(T) != typeof(Char))
		{
			Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
			return (null);
		}
		String concat = "";
		while (head != null)
		{
			concat = concat + head.value;
			if (typeof(String) == typeof(T))
				concat = concat + " ";
			head = head.next;
		}
		return (concat);
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
