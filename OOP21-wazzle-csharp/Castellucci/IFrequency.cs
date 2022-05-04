using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Castellucci
{
    /// <summary>
    /// This interface provides a method for computing the frequency of the characters in the dataset.
    /// </summary>
    public interface IFrequency
    {
        /// <summary>
        /// Computes the frequency of the charaters in the dataset.
        /// </summary>
        /// <returns> the weighted alphabet which contains a map with all the charaters and its frequency. </returns>
        WeightedAlphabet ComputeFrequency();
    }
}
