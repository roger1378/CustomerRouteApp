namespace CustomerRoutApp;

public interface IShortestRoute
{
    string GetLengthShortestRoute(Dictionary<string, int> routes, string start, string end);
}
