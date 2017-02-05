namespace _04.FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FixEmails
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            var detailsDict = new Dictionary<string, string>();

            while (!name.Equals("stop"))
            {
                string email = Console.ReadLine();

                if (!detailsDict.ContainsKey(name) && !email.EndsWith("uk") && !email.EndsWith("us")) 
                {
                    detailsDict[name] = email;
                }

                name = Console.ReadLine();
            }

            foreach (var detail in detailsDict)
            {
                Console.WriteLine("{0} -> {1}", detail.Key, detail.Value);
            }
        }
    }
}
