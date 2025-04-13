public class RadarController
{
    public void SendInstruction(Flight flight)
    {
        Random rnd = new Random();
        int newAltitude = rnd.Next(10000, 30000);
        Console.WriteLine($"[Radar] Instructing {flight.FlightNumber} to change altitude to {newAltitude}");
        flight.ChangeAltitude(newAltitude);
    }
}
