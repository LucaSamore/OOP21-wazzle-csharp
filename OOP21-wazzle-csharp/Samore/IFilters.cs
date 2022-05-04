using System;
using System.Collections.Generic;
using System.Linq;

namespace WazzleLuca
{
    /// <summary>
    /// This interface provides a set of static methods that can be used to perform filter operations on a set of Letter objects
    /// It also provides an ApplyFilters method that classes whose implement this interface can specify the behavior by calling, for example, all 
    /// these static filters.
    /// </summary>
    public interface IFilters
    {
        /// <summary>
        /// Given a word and a set of Letter objects, checks whether all characters in the word are present in the letters set.
        /// </summary>
        static Func<string, ISet<ILetter>, bool> FilterLetters = 
            (word, letters) => word.Where(c => letters.Select(l => l.Content).ToList().Contains(c))
                .ToList().Count == word.Length;

        /// <summary>
        /// Given a word and a set of Letter objects, checks whether the word is contained in the set of letters, 
        /// by checking if a path of characters (that can form the beginning word) exists in the set.
        /// This method uses an algorithm provided by WordPathChecker class.
        /// </summary>
        static Func<string, ISet<ILetter>, bool> FilterPaths =
            (word, letters) => new WordPathChecker().Exist(letters.ToDictionary(k => k.Position, v => v.Content), word);

        /// <summary>
        /// Given a word and a set of Letter objects, performs a sequence of filtering operations on the set 
        /// and returns a boolean describing the result of these operations.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="letters"></param>
        /// <returns></returns>
        bool ApplyFilters(string word, ISet<ILetter> letters);
    }
}
