public class Program
{
   
	public static void Main()
	{
        string inputLoadUserSave = "0";

        Console.WriteLine("Welcome to the Squid Wizard RPG");
        Console.WriteLine("Press 1 or Enter to continue story (load save data)");
        Console.WriteLine("Press 2 to load new game");
        inputLoadUserSave = Console.ReadLine(); 

        inputLoadUserSave = Console.ReadLine() ?? string.Empty;
        inputLoadUserSave = inputLoadUserSave.ToLower().Trim();

        if (string.IsNullOrWhiteSpace(inputLoadUserSave) || inputLoadUserSave == "1" || inputLoadUserSave == "enter")
        {
            return System.Text.Json.JsonSerializer.Deserialize(Player); //the save data;
        }

        else if (inputLoadUserSave == "2")
        {
            Player player = new Player();
            
        }
        else 
        {
            Console.WriteLine("Selection not understood. Loading save data");
            return System.Text.Json.JsonSerializer.Deserialize(Player); 
        }
        
        if (inputLoadUserSave == "2")
        {
            System.Console.WriteLine("Welcome new Player!");
            Console.WriteLine(Player);
        }

        Console.WriteLine("Your current player stats are:");
        Console.WriteLine(Player);

    }

}
