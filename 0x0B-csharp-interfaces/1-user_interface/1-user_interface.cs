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
	interface IInteractive
	{
		/// <summary>
		/// The interact method
		/// </summary>
		void Interact();
	}

	/// <summary>
	/// Breakable interface
	/// </summary>
	interface IBreakable
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
	interface ICollectable
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
	/// The class test Object 
	/// </summary>
	public class TestObject : Base, IInteractive, IBreakable, ICollectable
	{
		public int durability {get; set;}
		public bool isCollected {get; set;}
		public string name {get; set;}
		public void Interact(){

		}
		public void Break(){

		}
		public void Collect(){

		}
	}
