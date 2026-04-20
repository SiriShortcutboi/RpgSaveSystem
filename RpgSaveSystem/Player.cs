using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace PlayerObjectSpace;
public class Player : IGameCharacter, ISaveable
{
	private readonly List<Item> _inventory = new List<Item>();
	public IReadOnlyList<Item> Inventory => _inventory.AsReadOnly();

	public string Name { get; private set; }
	public int Health{ get; private set; }
	public int Level { get; private set; }
	public Player(string name, int health, int level)
	{
		this.Name = name;
		this.Health = health;


	}
	public void AddItem(Item item)
	{
		_inventory.Add(item);
	}

	public void TakeDamage(int amount)
	{
		Health = Health - amount;
		if (Health < 0)
		{
			Health = 0;
		}
		if (Health == 0)
			Console.WriteLine("You have fainted.");

         

	}

	public void LevelUp()
	{
        Level++;
	}

	public string ToJson()
	{
        string playerinfo = System.Text.Json.JsonSerializer(Player);
		return playerinfo;
	}
}


