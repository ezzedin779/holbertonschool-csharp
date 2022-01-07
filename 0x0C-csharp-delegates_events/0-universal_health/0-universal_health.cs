using System;

class Player
{
    private string name {get; set;}
	private float maxHp {get; set;}
	private float hp {get; set;}
	/// <summary>
	/// the constructor
	/// </summary>
	/// <param name="name"> of the player</param>
	/// <param name="maxHp"> Maximum health </param>
	public Player(string name="Player", float maxHp=100f)
	{
		if (maxHp <= 0)
		{
			maxHp = 100f;
			Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
		}
		this.maxHp = maxHp;
		this.name = name;
		this.hp = this.maxHp;
	}
	/// <summary>
	/// printing players health
	/// </summary>
	public void PrintHealth()
	{
		Console.WriteLine("{0} has {1} / {2} health", this.name, this.hp, this.maxHp);
	}
}
