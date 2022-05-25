using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace JSONStorage
{
	public class JSONStorage
	{
		public Dictionary<string, dynamic> objects = new Dictionary<string, dynamic>();

		public Dictionary<string, dynamic> all()
		{
			return objects;
		}

		public void New(dynamic obj)
		{
			try
			{
				objects.Add($"{obj.GetType().Name}.{obj.id}", obj);
			}
			catch (Exception)
			{
				Console.WriteLine("Please provide class instance that inherits from BaseClass");
			}
		}

		public void Save()
		{
			var op = new JsonSerializerOptions {WriteIndented = true};
			string fileName = "storage/inventory_manager.json";
			string jsonString = JsonSerializer.Serialize(objects, op);
			File.WriteAllText(fileName, jsonString);
		}
		public void Load()
		{
			string fileName = "storage / inventory_manager.json";
			string jsonString = File.ReadAllText(fileName);
			objects = JsonSerializer.Deserialize<Dictionary<string, dynamic>>(jsonString);
		}
	}
}