using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Barbanti
{
    /// <summary>
    /// The abstract base decorator that implements the interface <see cref="AbstractDictionary"/>.
    /// </summary>
    public abstract class FilteredDictionary : AbstractDictionary
    {
        protected readonly AbstractDictionary _dictionary;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilteredDictionary"/> class.
        /// </summary>
        /// <param name="dictionary">The dictionary containing all the words.</param>
        public FilteredDictionary(AbstractDictionary dictionary) => _dictionary = dictionary;

        public override ISet<string> GetWords() => _dictionary.GetWords();
    }
}
