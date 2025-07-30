using System;

class Elevator
{
    private int currentFloor = 1;
    private int requestedFloor = 0;
    private int totalFloorsTraveled = 0;
    private Person passenger;
    public void LoadPassenger()
    {
        passenger = new Person();
    }

    public void InitiateNewFloorRequest()
    {
        requestedFloor = passenger.NewFloorRequest();
        Console.WriteLine("Odjeżdżam z piętra: " + currentFloor + " Jadę na: " + requestedFloor);
        totalFloorsTraveled = totalFloorsTraveled + Math.Abs(currentFloor - requestedFloor);
        currentFloor = requestedFloor;
    }

    public void ReportStatistics()
    {
        Console.WriteLine("Ilość przebytych pięter: " + totalFloorsTraveled);
    }
}

class Person
{
    private System.Random randomNumberGenerator;

    public Person()
    {
        randomNumberGenerator = new System.Random();
    }

    public int NewFloorRequest()
    {
        return randomNumberGenerator.Next(1,30);
    }
}

class Building
{
    private static Elevator elevatorA;

    public static void Main()
    {
        elevatorA = new Elevator();
        elevatorA.LoadPassenger();
        elevatorA.InitiateNewFloorRequest();
        elevatorA.InitiateNewFloorRequest();
        elevatorA.InitiateNewFloorRequest();
        elevatorA.InitiateNewFloorRequest();
        elevatorA.InitiateNewFloorRequest();
        elevatorA.ReportStatistics();
    }
}