using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp
{
    /// <summary>
    /// This class is a concrete implementation for AbstractBonus.
    /// It provides methods for apply a TimeBonus.
    /// </summary>
    public sealed class TimeBonus : AbstractBonus
    {
        private readonly Func<long, long> _applier;

        /// <summary>
        /// Construct a new TimeBonus.
        /// </summary>
        /// <param name="applier"> the operation that must be done when the bonus is used by the user.</param>
        /// <param name="name"> the bonus name </param>
        public TimeBonus(Func<long, long> applier, string name)
        {
            _applier = applier;
            Name = name;
        }

        /// <summary>
        /// Apply the implications of the TimeBonus.
        /// </summary>
        /// <param name="currentTime"> the current time to increment </param>
        /// <returns></returns>
        public long Apply(long currentTime) => _applier.Invoke(currentTime);

        public override bool Equals(object obj) => obj is TimeBonus bonus &&
                   base.Equals(obj) &&
                   EqualityComparer<Func<long, long>>.Default.Equals(_applier, bonus._applier);

        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), _applier);

        public override string ToString() => base.ToString();
      
    }
}
