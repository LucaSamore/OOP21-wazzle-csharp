using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Barbanti
{
    /// <summary>
    /// The interface of dictionary.
    /// This interface provides the method <see cref="GetWords"/> to retrive all the words contained.
    /// </summary>
    public abstract class AbstractDictionary
    {
        /// <summary>
        /// Gets the current available words.
        /// </summary>
        /// <returns>An ISet containing the words.</returns>
        public abstract ISet<string> GetWords();
    }
}
