using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Castellucci
{
	/// <summary>
	/// This interface provides methods for creating bonuses.
	/// </summary>
    interface IAbstractBonusFactory
    {
		/// <summary>
		/// Gives a new ScoreBonus object.
		/// </summary>
		/// <returns> a new ScoreBonus </returns>
		ScoreBonus CreateScoreBonus();

		/// <summary>
		/// Gives a new TimeBonus object.
		/// </summary>
		/// <returns> a new TimeBonus </returns>
		TimeBonus CreateTimeBonus();

		/// <summary>
		/// Gives a new WordBonus object.
		/// </summary>
		/// <returns> a new WordBonus </returns>
		WordBonus CreateWordBonus();
	}
}
