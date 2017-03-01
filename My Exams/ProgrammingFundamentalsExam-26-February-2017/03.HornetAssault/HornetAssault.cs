namespace _03.HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetAssault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < beehives.Length; i++)
            {
                var hornetsPower = hornets.Sum();

                //the beehive disappears
                if (hornetsPower > beehives[i]) 
                {
                    beehives[i] = 0;
                }
                else //current hornet disappears
                {
                    beehives[i] -= hornetsPower;
                    hornets.RemoveAt(0);
                }
                //if all hornets are dead
                if (!hornets.Any())
                {
                    break;
                }
            }

            if(beehives.Any(b => b > 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(b => b > 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}