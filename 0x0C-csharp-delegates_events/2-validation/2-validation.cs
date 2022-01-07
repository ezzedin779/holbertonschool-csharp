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

	/// <summary>
	/// the validator of the hp (sets the hp)
	/// </summary>
	/// <param name="newHp"> to be checked if correct </param>
	public void ValidateHP(float newHp)
	{
		if (newHp < 0)
			hp = 0;
		else if (newHp > maxHp)
			hp = maxHp;
		else
			hp = newHp;
	}

	/// <summary>
	/// inflicting damage to player
	/// </summary>
	/// <param name="damage"> the damage taken by the player </param>
	public void TakeDamage(float damage)
	{
		if (damage < 0)
			damage = 0;
		Console.WriteLine("{0} takes {1} damage!", this.name, damage);
		hp -= damage;
		ValidateHP(hp);
	}

	/// <summary>
	/// player getting healed
	/// </summary>
	/// <param name="heal"> the heal got by the player</param>
	public void HealDamage(float heal)
	{
		if (heal < 0)
			heal = 0;
		Console.WriteLine("{0} heals {1} HP!", this.name, heal);
		hp += heal;
		ValidateHP(hp);
	}

	/// <summary>
	/// a delegate that calculates the health
	/// </summary>
	public delegate void CalculateHealth(float damage);
}
