using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Barbanti
{
    /// <summary>
    /// This class represents a Minigame Word composed of a list of <see cref="WordElement"/>.
    /// </summary>
    public sealed class MiniGameWord
    {
        public IList<WordElement> CompositeWord { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MiniGameWord"/> class.
        /// </summary>
        /// <param name="compositeWord">The composite word.</param>
        public MiniGameWord(IList<WordElement> compositeWord) => CompositeWord = compositeWord;



        public override string ToString()
        {
            var minigameWordAsString = "";

            foreach (var wordElement in CompositeWord)
            {
                minigameWordAsString += "[" + wordElement.Character + "," + wordElement.Result + "] ";
            }

            return minigameWordAsString;
        }

        public override bool Equals(object obj)
        {
            return obj is MiniGameWord word &&
                   EqualityComparer<IList<WordElement>>.Default.Equals(CompositeWord, word.CompositeWord);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(CompositeWord);
        }
    }
}
