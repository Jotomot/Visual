namespace Serialization;
using Newtonsoft.Json;
class MyClass
{
    public static void Main(string[] args)
    {

        Player player = new Player("Jerry", 30); 
            


        string serializedPlayer = JsonConvert.SerializeObject(player);

        File.WriteAllText(@"C:\Repozytoria\Visual\Tasks\Serialization\Serialized\player.json", serializedPlayer);
        string serializedPlayerRead = File.ReadAllText(@"C:\Repozytoria\Visual\Tasks\Serialization\Serialized\player.json");

        Player player2 = JsonConvert.DeserializeObject<Player>(serializedPlayerRead);
        Console.WriteLine(player2.Name);
    }
    
}