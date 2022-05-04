using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Castellucci
{
	/// <summary>
	/// This interface provides methods for bonuses handling.
	/// </summary>
    interface IBonusManager
    {
		/// <summary>
		/// Updates the ScoreBonus quantity.
		/// </summary>
		/// <param name="operation"> the operation that must be done when the ScoreBonus is used by the user. </param>
		void UpdateScoreBonusQuantity(Func<int, int> operation);

		/// <summary>
		/// Updates the WordBonus quantity.
		/// </summary>
		/// <param name="operation"> the operation that must be done when the WordBonus is used by the user. </param>
		void UpdateWordBonusQuantity(Func<int, int> operation);

		/// <summary>
		/// Updates the TimeBonus quantity.
		/// </summary>
		/// <param name="operation"> the operation that must be done when the TimeBonus is used by the user. </param>
		void UpdateTimeBonusQuantity(Func<int, int> operation);

		/// <summary>
		/// Gives the quantity of ScoreBonus.
		/// </summary>
		/// <returns> the quantity of ScoreBonus available. </returns>
		int GetScoreBonusQuantity();

		/// <summary>
		/// Gives the quantity of WordBonus.
		/// </summary>
		/// <returns> the quantity of WordBonus available. </returns>
		int GetWordBonusQuantity();

		/// <summary>
		/// Gives the quantity of TimeBonus.
		/// </summary>
		/// <returns> the quantity of TimeBonus available. </returns>
		int GetTimeBonusQuantity();

		/// <summary>
		/// Apply the implications of the ScoreBonus.
		/// </summary>
		/// <param name="currentScore"> the current score. </param>
		/// <param name="gridTotalScore"> the total score of the letters in the grid. </param>
		/// <returns> the updated score. </returns>
		int ApplyScoreBonus(int currentScore, int gridTotalScore);

		/// <summary>
		/// Apply the implications of the WordBonus.
		/// </summary>
		/// <param name="toFoundWords"> the current score. </param>
		/// <returns> the suggested words. </returns>
		ISet<string> ApplyWordBonus(ISet<string> toFoundWords);

		/// <summary>
		/// Apply the implications of the TimeBonus.
		/// </summary>
		/// <param name="currentTime"></param>
		/// <returns> the updated time. </returns>
		long ApplyTimeBonus(long currentTime);

		/// <summary>
		/// Extract randomly a bonus.
		/// </summary>
		/// <returns> the extracted bonus. </returns>
		string ExtractBonus();
	}
}
