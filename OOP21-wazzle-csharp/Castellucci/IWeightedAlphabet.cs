using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Castellucci
{
    /// <summary>
    /// This interface models a map of characters an their respective frequencies.
    /// </summary>
    interface IWeightedAlphabet
    {
        /// <summary>
        /// The map which contains all characters and its frequency.
        /// </summary>
        IDictionary<char, double> WeightedAlphabetMap { get; }
    }
}