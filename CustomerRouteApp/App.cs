using CustomerRoutApp.BusinessLogic;

namespace CustomerRoutApp;

public class App
{
    private readonly IDestinaton _destinaton;
    private readonly ITrip _trip;
    private readonly IShortestRoute _shortestRoute;
    private readonly IDifferentRoutes _differentRoutes;

    public App(IDestinaton destinaton, ITrip trip, IShortestRoute shortestRoute, IDifferentRoutes differentRoutes)
    {
        _destinaton = destinaton;
        _trip = trip;
        _shortestRoute = shortestRoute;
        _differentRoutes = differentRoutes;
    }

    public void Run(string[] args)
    {
        string arr = "AB5,BC4,CD8,DC8,DE6,AD5,CE2,EB3,AE7";
        if (args.Length > 0)
            arr = args[0];

        SetUpRoutes setUpRoutes = new ();
        var routes = setUpRoutes.GetRoutes(arr);

        /*Requested routes*/
        var response = _destinaton.GetDistances(routes);
        
        response = string.Concat(response, ",", _trip.GetTrips(routes, 3, "C", "C"));
        response = string.Concat(response, ",", _trip.GetTrips(routes, 4, "A", "C"));

        response = string.Concat(response, ",", _shortestRoute.GetLengthShortestRoute(routes, "A", "C"));
        response = string.Concat(response, ",", _shortestRoute.GetLengthShortestRoute(routes, "C", "C"));

        response = string.Concat(response, ",", _differentRoutes.GetDifferentRoutes(routes, "C", "C"));

        var arrResult = response.Split(",");

        for (int i = 0; i < arrResult.Length; i++)
        {
            Console.WriteLine($"Output #{i+1}: {arrResult[i]}");
        }
    }
}
