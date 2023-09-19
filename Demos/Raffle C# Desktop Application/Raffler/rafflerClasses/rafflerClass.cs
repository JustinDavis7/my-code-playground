using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raffler.rafflerClasses
{
    internal class rafflerClass
    {
        //Getter Setter Properties
        public int numberToChoose { get; set; }
        public string[] winners { get; set; }

        //Getting the names from the list
        public List<string> PickWinners(string[] allNames, int winnersCount)
        {
            Random random = new Random();
            string[] shuffledNames = new string[allNames.Length];
            allNames.CopyTo(shuffledNames, 0);

            // Fisher-Yates shuffle
            for (int i = shuffledNames.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                string temp = shuffledNames[i];
                shuffledNames[i] = shuffledNames[j];
                shuffledNames[j] = temp;
            }

            // Take the first winnersCount elements
            List<string> winners = new List<string>();
            foreach (var name in shuffledNames)
            {
                winners.Add(name);
                if (winners.Count() >= winnersCount)
                    break;
            }

            return winners;
        }
    }
}
