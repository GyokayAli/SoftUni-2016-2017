namespace _02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split(',').Select(p => p.Trim()).ToArray();
            var songs = Console.ReadLine().Split(',').Select(p => p.Trim()).ToArray();

            var karaokeDict = new Dictionary<string, List<string>>();

            var input = Console.ReadLine();
            while (input != "dawn")
            {
                var line = input.Split(',');
                var participant = line[0];
                var song = line[1].Trim();
                var award = line[2].Trim();

                if (participants.Contains(participant) && songs.Contains(song))
                {
                    if (!karaokeDict.ContainsKey(participant))
                    {
                        karaokeDict[participant] = new List<string>();
                    }

                    if (!karaokeDict[participant].Contains(award))
                    {
                        karaokeDict[participant].Add(award);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var kvp in karaokeDict.OrderByDescending(a => a.Value.Count))
            {
                var currParticipant = kvp.Key;
                var participantAwards = kvp.Value.Count();
                var awardsList = kvp.Value;

                Console.WriteLine($"{currParticipant}: {participantAwards} awards");
                foreach (var a in awardsList.OrderBy(a => a))
                {
                    Console.WriteLine($"--{a}");
                }
            }

            if (!karaokeDict.Any())
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
