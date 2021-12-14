using System;
/// <summary>
/// Generic Class ?
/// </summary>
/// <typeparam name="T">the type to know</typeparam>
class Queue<T>
{
	/// <summary>
	/// the class method
	/// </summary>
	/// <returns>the type to know</returns>
	public Type CheckType()
	{
		return(typeof(T));
	}
}
