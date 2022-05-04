using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Castellucci
{
    /// <summary>
    /// This class is a concrete implementation for AbstractBonus.
    /// It provides methods for apply a WordBonus.
    /// </summary>
    public sealed class WordBonus : AbstractBonus
    {
        private readonly Func<ISet<string>, ISet<string>> _applier;

        /// <summary>
        /// Construct a new WordBonus.
        /// </summary>
        /// <param name="applier"> the operation that must be done when the bonus is used by the user.</param>
        /// <param name="name"> the bonus name </param>
        public WordBonus(Func<ISet<string>, ISet<string>> applier, string name)
        {
            _applier = applier;
            Name = name;
        }

        /// <summary>
        /// Apply the implications of the WordBonus.
        /// </summary>
        /// <param name="toFoundWords"> the words that have to be found </param>
        /// <returns></returns>
        public ISet<string> Apply(ISet<string> toFoundWords) => _applier.Invoke(toFoundWords);

        public override bool Equals(object obj) => obj is WordBonus bonus &&
                   base.Equals(obj) &&
                   EqualityComparer<Func<ISet<string>, ISet<string>>>.Default.Equals(_applier, bonus._applier);

        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), _applier);

        public override string ToString() => base.ToString();

    }
}
