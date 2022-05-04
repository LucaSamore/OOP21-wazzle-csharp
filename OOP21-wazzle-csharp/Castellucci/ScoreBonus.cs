using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp
{
    /// <summary>
    /// This class is a concrete implementation for AbstractBonus.
    /// It provides methods for apply a ScoreBonus.
    /// </summary>
    public sealed class ScoreBonus : AbstractBonus
    {

        private readonly Func<int, int, int> _applier;

        /// <summary>
        /// Construct a new ScoreBonus.
        /// </summary>
        /// <param name="applier"> the operation that must be done when the bonus is used by the user.</param>
        /// <param name="name"> the bonus name </param>
        public ScoreBonus(Func<int, int, int> applier, string name)
        {
            _applier = applier;
            Name = name;
        }

        /// <summary>
        /// Apply the implications of the ScoreBonus.
        /// </summary>
        /// <param name="currentScore"> the current score </param>
        /// <param name="gridTotalScore">the grid total score </param>
        /// <returns></returns>
        public int Apply(int currentScore, int gridTotalScore) => _applier.Invoke(currentScore, gridTotalScore);

        public override bool Equals(object obj) => obj is ScoreBonus bonus &&
                   base.Equals(obj) &&
                   EqualityComparer<Func<int, int, int>>.Default.Equals(_applier, bonus._applier);

        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), _applier);

        public override string ToString() => base.ToString();
    }
}
