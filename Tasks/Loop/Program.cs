
namespace Loop;
    class MyClass
    {
    
    static void Main(string[] args)
    {
        int[] temperatureArray = { 18, 20, 10, 35, 16 };

        Console.WriteLine("Najwyższa temperatura przez ostatnie dni to " + FindHighestTemperature(temperatureArray) + " stopni Celsjusza");

        Console.WriteLine("Najniższa temperatura przez ostatnie dni to " + FindLowestTemperature(temperatureArray) + " stopni Celsjusza");

    }

    public static int FindHighestTemperature(int[] temperatures)
    {
        int highestTemperature = temperatures[0];
        for (int i = 1;i < temperatures.Length; i++)
        {
            if (temperatures[i] > highestTemperature)
            {
                highestTemperature = temperatures[i];
            }
        }
        return highestTemperature;
    }

    // Znajduje najniższą temperaturę w tablicy temperatur
    public static int FindLowestTemperature(int[] temperatures)
    {
        int lowestTemperatureDegree = temperatures[0];
        for (int i = 1; i < temperatures.Length; i++)
        {
            if (temperatures[i] < lowestTemperatureDegree)
            {
                lowestTemperatureDegree = temperatures[i];
            }
        }
        return lowestTemperatureDegree;
    }
}