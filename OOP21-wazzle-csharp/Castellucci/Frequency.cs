using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using OOP21_wazzle_csharp.Samore;

namespace OOP21_wazzle_csharp.Castellucci
{
    /// <summary>
    /// This class provides a concrete implementation for IFrequency.
    /// It provides methods for compute frequency.
    /// </summary>
    public sealed class Frequency : IFrequency
    {
        private readonly IDataset _dataset;

        /// <summary>
        /// Constructs a new Frequency object.
        /// </summary>
        /// <param name="dataset"> the dataset to be used to perform the frequency operation</param>
        public Frequency(IDataset dataset) => _dataset = dataset;

        /// <summary>
        /// Computes the frequency of the charaters in the dataset.
        /// </summary>
        /// <returns> the weighted alphabet which contains a map with all the charaters and its frequency. </returns>
        public WeightedAlphabet ComputeFrequency()
        {
            var frequencyMap = new Dictionary<char, double>();
            var result = new Dictionary<char, double>();
            _dataset.Words.SelectMany(w => w.ToList()).ToList().ForEach(c => frequencyMap[c] = frequencyMap.ContainsKey(c) ? frequencyMap[c] + 1 : 1);
            frequencyMap.ToList().ForEach(p => result.Add(p.Key, p.Value / frequencyMap.Values.Sum()));
            return new WeightedAlphabet(result);
        }
    }
}
