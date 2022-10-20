
using CustomerRoutApp;
using CustomerRoutApp.BusinessLogic;

namespace CustomerRouteTest.BusinessLogic;

public class RouteTest
{
    [Fact]
    public void TestDestination()
    {

        string arr = "AB5,BC4,CD8,DC8,DE6,AD5,CE2,EB3,AE7";

        SetUpRoutes setUpRoutes = new();
        var routes = setUpRoutes.GetRoutes(arr);

        Destination destination = new();

        var destinations = destination.GetDistances(routes);

        string expected = "9,5,13,22,NO SUCH ROUTE";

        Assert.Equal(expected, destinations);
    }

    [Fact]
    public void TestTrip()
    {

        string arr = "AB5,BC4,CD8,DC8,DE6,AD5,CE2,EB3,AE7";

        SetUpRoutes setUpRoutes = new();
        var routes = setUpRoutes.GetRoutes(arr);

        Trip trip = new();

        var trips = trip.GetTrips(routes, 3, "C", "C");

        string expected = "2";

        Assert.Equal(expected, trips);
    }

    [Fact]
    public void TestShortestRoute()
    {

        string arr = "AB5,BC4,CD8,DC8,DE6,AD5,CE2,EB3,AE7";

        SetUpRoutes setUpRoutes = new();
        var routes = setUpRoutes.GetRoutes(arr);

        ShortestRoute sRoute = new();

        var shortestRoute = sRoute.GetLengthShortestRoute(routes, "A", "C");

        string expected = "9";

        Assert.Equal(expected, shortestRoute);
    }

    [Fact]
    public void TestAll()
    {

        string arr = "AB5,BC4,CD8,DC8,DE6,AD5,CE2,EB3,AE7";

        SetUpRoutes setUpRoutes = new();
        var routes = setUpRoutes.GetRoutes(arr);

        Destination destination = new();
        var response = destination.GetDistances(routes);

        Trip trip = new();
        response = string.Concat(response, ",", trip.GetTrips(routes, 3, "C", "C"));
        response = string.Concat(response, ",", trip.GetTrips(routes, 4, "A", "C"));

        ShortestRoute sRoute = new();
        response = string.Concat(response, ",", sRoute.GetLengthShortestRoute(routes, "A", "C"));
        response = string.Concat(response, ",", sRoute.GetLengthShortestRoute(routes, "C", "C"));

        DifferentRoutes differentRoutes = new ();
        response = string.Concat(response, ",", differentRoutes.GetDifferentRoutes(routes, "C", "C"));

        string expected = "9,5,13,22,NO SUCH ROUTE,2,3,9,9,7";

        Assert.Equal(expected, response);
    }
}
