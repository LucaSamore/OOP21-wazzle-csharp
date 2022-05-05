using OOP21_wazzle_csharp.Samore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Barbanti
{
    /// <summary>
    /// The implementation of dictionary.
    /// </summary>
    public sealed class ConcreteDictionary : IDataset
    {
        private readonly ISet<string> _words;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteDictionary"/> class.
        /// </summary>
        /// <param name="words">The Set containing all words.</param>
        public ConcreteDictionary(ISet<string> words) => _words = words;



        public ISet<string> Words { get => _words; }
    }
}
