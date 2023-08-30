// ---------------------------------------------------- Fields ---------------------------------------------------- 
// A name (i.e. Honda Accord, Mountain Bike, Rollerblades)
// The number of passengers the vehicle carries
// The color of the vehicle
// Whether or not the vehicle has an engine
// How many miles the vehicle has already traveled - start this at 0 by default

//Answer:
// public class Vehicle
// {
//     public string Name;
//     public int NumPassengers;
//     public string Color;
//     public bool HasEngine;
//     public int Distance = 0;
// }



// ----------------------------------------------------  Constructors ---------------------------------------------------- 
// A constructor that allows a user to fill in all fields (except distance traveled)
//Answer:
    // public Vehicle( string name, int passengers, string color, bool engine)
    // {
    //     Name = name;
    //     NumPassengers = passengers;
    //     Color = color;
    //     HasEngine = engine;
    // }

// A constructor that only allows a user to fill in name and color and provides default values for all other fields (you can assume it will become some sort of car)
//Answer:
    // public Vehicle( string name, string color)
    // {
    //     Name = name;
    //     NumPassengers = 4;
    //     Color = color;
    //     HasEngine = true;
    // }




// ---------------------------------------------------- Methods ---------------------------------------------------- 
// A method called ShowInfo() prints out all the information about the vehicle
    // public void ShowInfo()
    // {
    //     Console.WriteLine($"Name: {Name}");
    //     Console.WriteLine($"NumPassengers: {NumPassengers}");
    //     Console.WriteLine($"Color: {Color}");
    //     Console.WriteLine($"HasEngine: {HasEngine}");
    //     Console.WriteLine($"Distance: {Distance}");
    // }
// A method called Travel() accepts input for distance, adds that distance to the total distance traveled, and prints out a message saying how far the vehicle has gone
    // public void Travel(int dist)
    // {
    //     Distance += dist;
    //     Console.WriteLine($"{Name} has travled {Distance}");
    // }


//---------------------------------------------------- Program CS ---------------------------------------------------- 
// Once your vehicle class has been created, head back to Program.cs and complete the following tasks:

public class Vehicle
{
    public string Name;
    public int NumPassengers;
    public string Color;
    public bool HasEngine;
    public int Distance = 0;

    public Vehicle( string name, int passengers, string color, bool engine)
    {
        Name = name;
        NumPassengers = passengers;
        Color = color;
        HasEngine = engine;
    }

        public Vehicle( string name, string color)
    {
        Name = name;
        NumPassengers = 4;
        Color = color;
        HasEngine = true;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"NumPassengers: {NumPassengers}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"HasEngine: {HasEngine}");
        Console.WriteLine($"Distance: {Distance}");
    }

    public void Travel(int dist)
    {
        Distance += dist;
        Console.WriteLine($"{Name} has travled {Distance}");
    }
}