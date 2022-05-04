using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp
{
	/// <summary>
	/// This class is a concrete implementation for IAbstractBonusFactory. 
	/// It provides methods for creating bonuses.
	/// </summary>
	public sealed class BonusFactory : IAbstractBonusFactory
    {
		/// <summary>
		/// Gives a new ScoreBonus object.
		/// </summary>
		/// <returns> a new ScoreBonus </returns>
		public ScoreBonus CreateScoreBonus() => new ScoreBonus(IBonusStrategies.ScoreBonus(), "Score Bonus");

		/// <summary>
		/// Gives a new TimeBonus object.
		/// </summary>
		/// <returns> a new TimeBonus </returns>
		public TimeBonus CreateTimeBonus() => new TimeBonus(IBonusStrategies.TimeBonus(), "Time Bonus");

		/// <summary>
		/// Gives a new WordBonus object.
		/// </summary>
		/// <returns> a new WordBonus </returns>
		public WordBonus CreateWordBonus() => new WordBonus(IBonusStrategies.WordBonus(), "Word Bonus");
	}
}
