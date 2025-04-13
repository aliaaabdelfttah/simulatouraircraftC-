public class Flight
{
    public string FlightNumber { get; set; }
    public int Altitude { get; set; }
    public int Speed { get; set; }
    public string Status { get; set; } // Airborne, Landing, Emergency

    public void ChangeAltitude(int newAlt)
    {
        Altitude = newAlt;
        Console.WriteLine($"Flight {FlightNumber} changed altitude to {Altitude} feet.");
    }
}
