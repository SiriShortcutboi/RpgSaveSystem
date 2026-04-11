public class Player : IGameCharacter, ISaveable
{
	public Player(string name, int health, int level)
	{
	}

	public void AddItem(Item item)
	{
	}

	public void TakeDamage(int amount)
	{
	}

	public void LevelUp()
	{
	}

	public string ToJson()
	{
		return string.Empty;
	}
}