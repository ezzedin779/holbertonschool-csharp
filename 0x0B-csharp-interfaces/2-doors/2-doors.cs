using System;

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
		public Interact()
		{
			Console.WriteLine($"You try to open the {this.name}. It's locked");
		}
	}
