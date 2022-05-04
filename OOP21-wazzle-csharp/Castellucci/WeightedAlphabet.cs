using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Castellucci
{
    /// <summary>
    /// This class is a concrete implementation for IWeightedAlphabet.
    /// It models a map of characters an their respective frequencies.
    /// </summary>
    public sealed class WeightedAlphabet : IWeightedAlphabet
    {
        public IDictionary<char, double> WeightedAlphabetMap { get; }

        /// <summary>
        /// Constructs a new WeightedAlphabet.
        /// </summary>
        /// <param name="weightedAlphabetMap"> the weighted alphabet map </param>
        public WeightedAlphabet(IDictionary<char, double> weightedAlphabetMap)
        {
            WeightedAlphabetMap = weightedAlphabetMap;
        }

        public override bool Equals(object obj) => obj is WeightedAlphabet alphabet &&
                   EqualityComparer<IDictionary<char, double>>.Default.Equals(WeightedAlphabetMap, alphabet.WeightedAlphabetMap);

        public override int GetHashCode() => HashCode.Combine(WeightedAlphabetMap);

        public override string ToString() => base.ToString();
    }
}
