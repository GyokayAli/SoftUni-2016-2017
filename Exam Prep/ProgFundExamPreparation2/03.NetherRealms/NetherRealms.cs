namespace _03.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    public class NetherRealms
    {
        public static void Main()
        {
            var demons = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var damageRegex = new Regex(@"[+-]?\d+(?:\.?\d+)?");
            var healthRegex = new Regex(@"[^\d\.\-\+\*\/]");

            foreach (var demon in demons.OrderBy(d => d))
            {
                var damage = 0.0m;
                var health = 0;

                var damageMatchCollection = damageRegex.Matches(demon);
                foreach (var match in damageMatchCollection)
                {
                    damage += decimal.Parse(match.ToString());
                }

                var healthMatchCollection = healthRegex.Matches(demon);
                foreach (var match in healthMatchCollection)
                {
                    health += match.ToString().First();
                }

                var modifiers = demon.Where(a => a == '*' || a == '/').ToArray();
                foreach (var modifier in modifiers)
                {
                    switch (modifier)
                    {
                        case '*': damage *= 2; break;
                        case '/': damage /= 2; break;
                    }
                }

                Console.WriteLine($"{demon} - {health} health, {damage:F2} damage");
            }
        }
    }
}
