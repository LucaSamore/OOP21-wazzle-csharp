using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Barbanti
{
    /// <summary>
    /// This class represents a letter present in the dataset and it's associated value after computation.
    /// The result of computation is an element of the Enum <see cref="Result"/>, while the character is
    /// one of the letters present in the initial dataset.
    /// </summary>
    public sealed class WordElement
    {
        /// <summary>
        /// Gets or sets the result, see <see cref="Result"/>.
        /// </summary>
        public Result Result { get; set; }
        public char Character { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WordElement"/> class.
        /// </summary>
        /// <param name="character">The character to be represented by the WordElement .</param>
        /// <param name="result">The result associated to the given character.</param>
        public WordElement(char character, Result result)
        {
            Character = character;
            Result = result;
        }

        public override bool Equals(object obj)
        {
            return obj is WordElement element &&
                   Result == element.Result &&
                   Character == element.Character;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Result, Character);
        }
    }
}
