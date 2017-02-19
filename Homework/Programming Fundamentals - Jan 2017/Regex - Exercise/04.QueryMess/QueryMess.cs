//Thanks to Katya Marincheva for the solution
namespace _04.QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    public class QueryMess
    {
        public static void Main()
        {
            var pattern = @"([^&=?]*)=([^&=]*)";
            var regex = @"((%20|\+)+)";

            var inputLine = string.Empty;

            while ((inputLine = Console.ReadLine()) != "END")
            {
                var pairs = new Regex(pattern);
                var matchCollection = pairs.Matches(inputLine);

                var results = new Dictionary<string, List<string>>();
                for (int i = 0; i < matchCollection.Count; i++)
                {
                    string field = matchCollection[i].Groups[1].Value;
                    field = Regex.Replace(field, regex, word => " ").Trim();

                    string value = matchCollection[i].Groups[2].Value;
                    value = Regex.Replace(value, regex, word => " ").Trim();

                    if (!results.ContainsKey(field))
                    {
                        var values = new List<string>();
                        values.Add(value);
                        results.Add(field, values);
                    }
                    else if (results.ContainsKey(field))
                    {
                        results[field].Add(value);
                    }
                }

                foreach (var pair in results)
                {
                    Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                }
                Console.WriteLine();
            }
        }
    }
}
