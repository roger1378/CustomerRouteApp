namespace CustomerRoutApp;
using CustomerRoutApp.BusinessLogic;

public class Trip: ITrip
{
    public string GetTrips(Dictionary<string, int> routes, int len, string start, string end)
    {
        string result = string.Empty;

        Route route = new ();
        var mainRoutes = routes
              .Where(x => x.Key.StartsWith(start))
              .Select(x => x.Key)
              .ToList();

        int count = 0;
        foreach (var mainRoute in mainRoutes)
        {
            int trips = 0;
            string endValueKey = mainRoute.Substring(1, 1);
            for (int i = 0; i < len; i++)
            {
                var nextRoute = route.GetNextRoute(routes, endValueKey);

                if (nextRoute != string.Empty)
                {
                    trips++;
                    endValueKey = nextRoute.Substring(1, 1);
                    if (endValueKey == end)
                    {
                        count++;
                        break;
                    }
                }
            }
            result = count.ToString();
        }

        return result;
    }
}
