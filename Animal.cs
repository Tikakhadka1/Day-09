class Animal
{
    internal string species;
    internal string breed;
    internal int weight;
    internal int limbs;
    internal string color;

    internal void PrintDetail()
    {
        Console.WriteLine($"Species:{species} Breed: {breed} Weight:{weight} limbs:{limbs} colour:{color}");
    }
    
}