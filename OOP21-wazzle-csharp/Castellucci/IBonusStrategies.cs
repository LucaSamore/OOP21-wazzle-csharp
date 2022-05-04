using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp
{
    /// <summary>
    /// This interface provides methods for giving each bonus a strategy.
    /// </summary>
    interface IBonusStrategies
    {

        /// <summary>
        /// Implements the application strategy for ScoreBonus.
        /// </summary>
        /// <returns> the updated score. </returns>
        static Func<int, int, int> ScoreBonus() => (current, bonus) => current + bonus;

        /// <summary>
        /// Implements the application strategy for TimeBonus.
        /// </summary>
        /// <returns> the updated time. </returns>
        static Func<long, long> TimeBonus() => i => i + 30;

        /// <summary>
        /// Implements the application strategy for WordBonus.
        /// </summary>
        /// <returns> the suggested words. </returns>
        static Func<ISet<string>, ISet<string>> WordBonus() => s => ExtractWords(s);

        private static ISet<string> ExtractWords(ISet<string> words)
        {
            var random = new Random();
            var extractedWords = new HashSet<string>();
            while (extractedWords.Count != 3)
            {
                extractedWords.Add(words.ToList()[random.Next(words.Count - 1)]);
            }
            return extractedWords;
        }

    }
}
