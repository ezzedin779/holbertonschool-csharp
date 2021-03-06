using System;

	/// <summary>
	/// Base class
	/// </summary>
    public abstract class Base
    {
		/// <summary>
		/// public property
		/// </summary>
        private string name {get; set;}
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
	/// The class test Object 
	/// </summary>
	public class TestObject : Base, IInteractive, IBreakable, ICollectable
	{
		/// <summary>
		/// durability ?
		/// </summary>
		public int durability {get; set;}
		/// <summary>
		/// is collected ?
		/// </summary>
		public bool isCollected {get; set;}
		/// <summary>
		/// name
		/// </summary>
		public string name {get; set;}
		/// <summary>
		/// the interact
		/// </summary>
		public void Interact(){
			// Implement
		}
		/// <summary>
		/// the Break
		/// </summary>
		public void Break(){
			// Implement
		}
		/// <summary>
		/// the collect
		/// </summary>
		public void Collect(){
			// Implement
		}
	}
