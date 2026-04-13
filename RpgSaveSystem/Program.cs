using System;
using System.Collections.Concurrent;
using PlayerObjectSpace;

public class Program
{
   
	public static void Main()
	{
        PlayerObjectSpace.Player player2 = new PlayerObjectSpace.Player();
        player2 = System.Text.Json.JsonSerializer.Deserialize(savedataplayer);

        string inputLoadUserSave = "0";
        Console.WriteLine("Welcome to the Squid Wizard RPG");
        Console.WriteLine("Press 1 to load new game");
        Console.WriteLine("Press 2 or Enter to continue story (load save data)");
        
        inputLoadUserSave = Console.ReadLine(); 

        inputLoadUserSave = Console.ReadLine() ?? string.Empty;
        inputLoadUserSave = inputLoadUserSave.ToLower().Trim();
        if (string.IsNullOrWhiteSpace(inputLoadUserSave) || inputLoadUserSave == "2" || inputLoadUserSave == "enter")
        {
            return System.Text.Json.JsonSerializer.Deserialize(Player); //the save data;
        }

        else if (inputLoadUserSave == "1")
        {
            Player player1 = new Player();
            
        }
        else 
        {
            Console.WriteLine("Selection not understood. Loading save data");
            return System.Text.Json.JsonSerializer.Deserialize(Player); 
        }
        
        if (inputLoadUserSave == "1")
        {
            Console.WriteLine("Welcome new Player! *intro sequence*");
            Console.WriteLine("Current players stats are " + Player);
            player1.TakeDamage(20);
            player1.LevelUp();
            System.Console.WriteLine("Nice job taking out the first enemy of the session");
        }

        Console.WriteLine("Your current player stats are:");
        Console.WriteLine(Player);

    }

}
