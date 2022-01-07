using System;
using System.Collections.Generic;

	/// <summary>
	/// Base class
	/// </summary>
    public abstract class Base
    {
		/// <summary>
		/// public property
		/// </summary>
        public string name {get; set;}
		/// <summary>
		/// override the string
		/// </summary>
		public override string ToString()
		{
			return $"{name} is a {this.GetType()}";
		}
    }

	/// <summary>
	/// Interactive interface
	/// </summary>
	public interface IInteractive
	{
		/// <summary>
		/// The interact method
		/// </summary>
		void Interact();
	}

	/// <summary>
	/// Breakable interface
	/// </summary>
	public interface IBreakable
	{
		/// <summary>
		/// the durability to break
		/// </summary>
		int durability {get; set;}
		/// <summary>
		/// the brek method
		/// </summary>
		void Break();
	}

	/// <summary>
	/// Collectable interface
	/// </summary>
	public interface ICollectable
	{
		/// <summary>
		/// is it collected ?
		/// </summary>
		bool isCollected {get; set;}
		/// <summary>
		/// collect method ?
		/// </summary>
		void Collect();
	}

	/// <summary>
	/// Door class
	/// </summary>
	public class Door: Base, IInteractive
	{
		/// <summary>
		/// The name of the door
		/// </summary>
		public Door(string value = "Door"){
			this.name = value;
		}
		/// <summary>
		/// The interaction with the door
		/// </summary>
		public void Interact()
		{
			Console.WriteLine($"You try to open the {this.name}. It's locked.");
		}
	}

	/// <summary>
	/// Decoration class ?
	/// </summary>
	public class Decoration : Base, IInteractive, IBreakable
	{
		/// <summary>
		/// isQuestobj are u usefull ?
		/// </summary>
		public bool isQuestobj {get; set;}
		/// <summary>
		/// How durable
		/// </summary>
		public int durability {get; set;}
		/// <summary>
		/// Set the parameters
		/// </summary>
		public Decoration(string name= "Decoration", int durability= 1, bool isQuestobj= false)
		{
			if (durability <= 0)
				throw new System.ArgumentException("Durability must be greater than 0");
			this.name = name;
			this.durability = durability;
			this.isQuestobj = isQuestobj;
		}
		/// <summary>
		/// the interact ?
		/// </summary>
		public void Interact()
		{
			if (this.durability <= 0)
				Console.WriteLine("The {0} has been broken.", this.name);
			else
			{
				if (this.isQuestobj)
					Console.WriteLine("You look at the {0}. There's a key inside.", this.name);
				else
					Console.WriteLine("You look at the {0}. Not much to see here.", this.name);
			}
		}
		/// <summary>
		/// BREAK THE F* DOOR
		/// </summary>
		public void Break()
		{
			this.durability -= 1;
			if (this.durability > 0)
				Console.WriteLine("You hit the {0}. It cracks.", this.name);
			else if (this.durability == 0)
				Console.WriteLine("You smash the {0}. What a mess.", this.name);
			else
				Console.WriteLine("The {0} is already broken.", this.name);
		}
	}

	/// <summary>
	/// key class
	/// </summary>
	public class Key : Base, ICollectable
	{
		/// <summary>
		/// did u get a key ?
		/// </summary>
		public bool isCollected {get; set;}
		/// <summary>
		/// the key ?
		/// </summary>
		public Key(string name= "Key", bool isCollected= false)
		{
			this.name = name;
			this.isCollected = isCollected;
		}
		/// <summary>
		/// the Collect method ?
		/// </summary>
		public void Collect()
		{
			if (this.isCollected == false)
			{
				this.isCollected = true;
				Console.WriteLine("You pick up the {0}.", this.name);
			}
			else
				Console.WriteLine("You have already picked up the {0}.", this.name);
		}
	}

	/// <summary>
	/// The objects Generic Class
	/// </summary>
	class Objs<T>: IEnumerable<T>
	{
		public List<T> Ls {get; set;}
		/// <summary>
		/// get the list ?
		/// </summary>
		public Objs()
		{
			Ls = new List<T>();
		}
		/// <summary>
		/// adding items ?
		/// </summary>
		public void Add(T i)
		{
			Ls.Add(i);
		}
		/// <summary>
		/// get enumerator
		/// </summary>
		public IEnumerator<T> GetEnumerator()
		{
			return Ls.GetEnumerator();
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
