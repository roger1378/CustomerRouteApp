namespace CustomerRoutApp.BusinessLogic;

public class SetUpRoutes
{
    public Dictionary<string, int> GetRoutes(string strRoutes)
    {
        var listRoutes = strRoutes.Split(',');

        var routes = new Dictionary<string, int>();

        foreach (var route in listRoutes)
        {
            routes.Add(route.Trim().Substring(0, 2), int.Parse(route.Trim().Substring(2, 1)));
        }

        foreach (var route in routes)
        {
            if (route.Key.Substring(0, 1) == route.Key.Substring(1, 1))
            {
                Console.WriteLine($"Invalid route: {route.Key}");
                routes.Remove(route.Key);
            }
        }

        return routes;  
    }
}
