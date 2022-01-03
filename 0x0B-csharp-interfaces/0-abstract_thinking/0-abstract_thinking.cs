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
