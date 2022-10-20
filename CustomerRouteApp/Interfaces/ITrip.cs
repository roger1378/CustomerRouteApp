namespace CustomerRoutApp;

public interface ITrip
{
    string GetTrips(Dictionary<string, int> routes, int len, string start, string end);
}
