using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Castellucci
{
    /// <summary>
    /// Contains all the possible Range which characters or letters could belong to.
    /// </summary>
    public enum RangeName
    {
        HIGH_FREQUENCY, MEDIUM_FREQUENCY, LOW_FREQUENCY
    }

    /// <summary>
    /// Represents the ranges.
    /// </summary>
    public sealed class Range
    {
        public RangeName RangeName { get; set; }
        public int Weight { get; set; }

        /// <summary>
        /// Constructs a new Range object.
        /// </summary>
        /// <param name="rangeName"> the range name. </param>
        /// <param name="weight"> the range weight. </param>
        public Range (RangeName rangeName, int weight)
        {
            RangeName = rangeName;
            Weight = weight;
        }

        public override bool Equals(object obj) => obj is Range range &&
                   RangeName == range.RangeName &&
                   Weight == range.Weight;

        public override int GetHashCode() => HashCode.Combine(RangeName, Weight);

        public override string ToString() => base.ToString();
    }
}
