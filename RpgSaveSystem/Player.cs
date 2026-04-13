using System.Runtime.CompilerServices;

namespace PlayerObjectSpace;
public class Player : IGameCharacter, ISaveable
{
    
	private Player(string name, int health, int level)
	{
        string name { get; private set; }

    
	public void AddItem(Item item)
	{

	}

	public void TakeDamage(int amount)
	{
        health = health - amount;
        if (health >= 0)
        {
            health = 0;
        }
        if (heatlh == 0)
            Console.WriteLine("You have fainted.");

         

	}

	public void LevelUp()
	{
        LevelUp++;
	}

	public string ToJson()
	{
        string playerinfo = System.Text.Json.JsonSerializer(Player);
		return playerinfo;
	}
}