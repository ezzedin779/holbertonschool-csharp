using System;

public class Item : BaseClass
{
	public string name {get; set;} = " ";
	public string description {get; set;} = null;
	public float? price {get; set;} = null;
	public List<string> tags {get; set;} = null;
}
