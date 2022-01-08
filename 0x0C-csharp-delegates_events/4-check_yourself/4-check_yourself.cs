using System;

class Player
{
	private string status;
    private string name {get; set;}
	private float maxHp {get; set;}
	private float hp {get; set;}

	/// <summary>
	/// the eventhandler ?
	/// </summary>
	public event EventHandler<CurrentHPArgs> HPCheck;

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
		status = $"{name} is ready to go!";
		HPCheck += CheckStatus;
	}

	/// <summary>
	/// the event to handle ?
	/// </summary>
	/// <param name="sender"> sender </param>
	/// <param name="e"> what happened ?</param>
	private void CheckStatus(object sender, CurrentHPArgs e)
	{
		if (e.currentHP == maxHp)
			status = $"{name} is in perfect health!";
		else if (e.currentHP >= maxHp / 2 && e.currentHP < maxHp)
			status = $"{name} is doing well!";
		else if (e.currentHP >= maxHp / 4 && e.currentHP < maxHp / 2)
			status = $"{name} isn't doing too great...";
		else if (e.currentHP > 0 && e.currentHP < maxHp / 2)
			status = $"{name} needs help!";
		else
			status = $"{name} is knocked out!";
		
		Console.WriteLine(status);
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
		HPCheck?.Invoke(this, new CurrentHPArgs(hp));
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

	/// <summary>
	/// the application of the modifier
	/// </summary>
	/// <param name="baseValue"> the base value </param>
	/// <param name="modifier"> depends on u </param>
	/// <returns></returns>
	public float ApplyModifier(float baseValue, Modifier modifier)
	{
		if (modifier == Modifier.Weak)
			return baseValue / 2;
		if (modifier == Modifier.Strong)
			return baseValue * 1.5f;
		return baseValue;
	}
}

/// <summary>
/// the enumerator for the modifers
/// </summary>
public enum Modifier {
	/// <summary>
	/// weak
	/// </summary>
	Weak,
	/// <summary>
	/// basic
	/// </summary>
	Base,
	/// <summary>
	/// strong
	/// </summary>
	Strong
};

/// <summary>
/// delegate the modifiers of the calculation
/// </summary>
/// <param name="baseValue"> the base value </param>
/// <param name="modifier"> the modifier </param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);


class CurrentHPArgs: EventArgs
{
	/// <summary>
	/// the currentHP of the player
	/// </summary>
	public readonly float currentHP;
	/// <summary>
	/// the constructor
	/// </summary>
	public CurrentHPArgs(float newHp)
	{
		currentHP = newHp;
	}
}
