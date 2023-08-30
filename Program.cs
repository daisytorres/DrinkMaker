// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

// Create a vehicle class with the following features in a Vehicle.cs file:


// Create at least 4 different vehicles using any of the constructors (use each constructor at least once)
// Put all the vehicles you created into a List
// Loop through the List and have each vehicle run its ShowInfo() method
// Make one of the vehicles Travel 100 miles
// Print the information of the vehicle to verify the distance traveled went up

Vehicle one = new Vehicle("Honda", 4, "black", true); // Create at least 4 different vehicles using any of the constructors (use each constructor at least once)
Vehicle two = new Vehicle("Toyota", "blue");
Vehicle three = new Vehicle ("Scooter", 1, "pink", false);
Vehicle four = new Vehicle ("Horse", 2, "brown", false);

List<Vehicle> AllVehicles = new List<Vehicle>(); // Put all the vehicles you created into a List
AllVehicles.Add(one);
AllVehicles.Add(two);
AllVehicles.Add(three);
AllVehicles.Add(four);

foreach (Vehicle v in AllVehicles) // Loop through the List and have each vehicle run its ShowInfo() method
{
    v.ShowInfo();
}

one.Travel(100); // Make one of the vehicles Travel 100 miles
one.ShowInfo(); // Print the information of the vehicle to verify the distance traveled went up
