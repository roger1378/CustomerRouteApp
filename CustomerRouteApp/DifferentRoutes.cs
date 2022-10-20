using CustomerRoutApp.BusinessLogic;

namespace CustomerRoutApp;

public class DifferentRoutes: IDifferentRoutes
{
    public string GetDifferentRoutes(Dictionary<string, int> routes, string start, string end)
    {
        Route objRoute = new();
        int count = 0;

        var mainRoutes = routes
              .Where(x => x.Key.StartsWith(start))
              .Select(x => x.Key)
              .ToList();

        foreach (var route in mainRoutes)
        {
            int length = 0;
            string endValueKey = route.Substring(1, 1);

            length = routes[route];

            var rts = new Dictionary<string, int>();
            foreach (var rt in routes)
            {
                rts.Add(rt.Key, rt.Value);
            }

            var nextRout = string.Empty;
            foreach (var route1 in routes)
            {
                nextRout = objRoute.GetNextRoute(rts, endValueKey);

                if (nextRout != string.Empty)
                {
                    length = length + rts[nextRout];

                    endValueKey = nextRout.Substring(1, 1);

                    rts.Remove(nextRout);

                    if (endValueKey == end)
                    {
                        count++;
                    }
                }
                else
                    length = 9999;
            }
        }

        return count.ToString();
    }
}
