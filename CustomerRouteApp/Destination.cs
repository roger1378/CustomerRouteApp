using System.Security.AccessControl;

namespace CustomerRoutApp;

public class Destination: IDestinaton
{
    public string GetDistances(Dictionary<string, int> routes)
    {
        string result = string.Empty;
        string[] arrRoutes = new string[] { "ABC", "AD", "ADC", "AEBCD", "AED" };

        foreach (var item in arrRoutes)
        {
            string response = "0";

            for (int i = 0; i < item.Length - 1; i++)
            {
                var key = item.Substring(i, 2);
                if (key.Length == 2)
                {
                    if (routes.ContainsKey(key))
                    {
                        response = (int.Parse(response) + routes[key]).ToString();
                    }
                    else
                    {
                        response = "NO SUCH ROUTE";
                        break;
                    }
                }
            }
            if (result == string.Empty)
                result = response;
            else
                result = string.Concat(result, ",", response);
        }

        return result;
    }
}
