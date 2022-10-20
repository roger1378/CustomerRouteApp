using CustomerRoutApp.BusinessLogic;

namespace CustomerRoutApp;

public class ShortestRoute: IShortestRoute
{
    public string GetLengthShortestRoute(Dictionary<string, int> routes, string start, string end)
    {
        Route objRoute = new();
        var rts = new Dictionary<string, int>();
        foreach (var route in routes)
        {
            rts.Add(route.Key, route.Value);
        }

        int count = 9999;

        for (int i = 0; i < 3; i++)
        {
            var length = objRoute.GetShortestRoute(rts, start, end, routes.Count);
            if (length < count)
                count = length;
        }

        if (count == 9999)
            count = 0;
        
        return count.ToString();
    }
}
