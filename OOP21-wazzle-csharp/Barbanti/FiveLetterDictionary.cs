using OOP21_wazzle_csharp.Samore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP21_wazzle_csharp.Barbanti
{
    /// <summary>
    /// The concrete decorator that filters all the words of five lenght.
    /// </summary>
    public sealed class FiveLetterDictionary : FilteredDictionary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FiveLetterDictionary"/> class.
        /// </summary>
        /// <param name="dictionary">The dictionary containing all the words.</param>
        public FiveLetterDictionary(IDataset dictionary) : base(dictionary)
        {
        }

        public override ISet<string> Words => FilterWords(base.Words);

        /// <summary>
        /// Filters the words that are not of lenght five.
        /// </summary>
        /// <param name="words">All words that will be filtered.</param>
        /// <returns>An ISet.</returns>
        private static ISet<string> FilterWords(ISet<string> words) => words.Where(word => word.Length == 5).ToHashSet();
    }
}
