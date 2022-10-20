namespace CustomerRoutApp.BusinessLogic
{
    internal class Route
    {
        internal string GetNextRoute(Dictionary<string, int> routes, string endValueKey)
        {
            foreach (var item in routes)
            {
                if (item.Key.Substring(0, 1) == endValueKey)
                {
                    return item.Key;
                }
            }

            return string.Empty;
        }

        internal int GetShortestRoute(Dictionary<string, int> routes, string start, string end, int len)
        {
            int count = 9999;

            var mainRoutes = routes
                  .Where(x => x.Key.StartsWith(start))
                  .Select(x => x.Key)
                  .ToList();

            foreach (var route in mainRoutes)
            {
                int length = 0;
                string endValueKey = route.Substring(1, 1);

                length = routes[route];

                for (int i = 0; i < len; i++)
                {
                    var nextRoute = this.GetNextRoute(routes, endValueKey);

                    if (nextRoute != string.Empty)
                    {
                        length = length + routes[nextRoute];

                        endValueKey = nextRoute.Substring(1, 1);

                        if (i == 0)
                            routes.Remove(nextRoute);

                        if (endValueKey == end)
                            break;
                    }
                    else
                        length = 9999;
                }
                if (length < count)
                    count = length;
            }
            return count;
        }
    }
}
