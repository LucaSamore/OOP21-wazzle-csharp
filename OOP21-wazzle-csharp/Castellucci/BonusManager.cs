using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp
{
    /// <summary>
    /// This class is a concrete implementation for IBonusManager.
	/// It provides methods for bonuses handling.
	/// </summary>
    public sealed class BonusManager : IBonusManager
    {
        private readonly ScoreBonus _scoreBonus;
        private readonly TimeBonus _timeBonus;
        private readonly WordBonus _wordBonus;
        private readonly IAbstractBonusFactory _bonusFactory;

        /// <summary>
        /// Construct a new BonusManager.
        /// </summary>
        public BonusManager()
        {
            _bonusFactory = new BonusFactory();
            _scoreBonus = _bonusFactory.CreateScoreBonus();
            _timeBonus = _bonusFactory.CreateTimeBonus();
            _wordBonus = _bonusFactory.CreateWordBonus();
        }

        /// <summary>
        /// Updates the ScoreBonus quantity.
        /// </summary>
        /// <param name="operation"> the operation that must be done when the ScoreBonus is used by the user. </param>
        public void UpdateScoreBonusQuantity(Func<int, int> operation) => _scoreBonus.UpdateQuantity(operation);

        /// <summary>
		/// Updates the TimeBonus quantity.
		/// </summary>
		/// <param name="operation"> the operation that must be done when the TimeBonus is used by the user. </param>
        public void UpdateTimeBonusQuantity(Func<int, int> operation) => _timeBonus.UpdateQuantity(operation);

        /// <summary>
		/// Updates the WordBonus quantity.
		/// </summary>
		/// <param name="operation"> the operation that must be done when the WordBonus is used by the user. </param>
        public void UpdateWordBonusQuantity(Func<int, int> operation) => _wordBonus.UpdateQuantity(operation);

        /// <summary>
        /// Gives the quantity of ScoreBonus.
        /// </summary>
        /// <returns> the quantity of ScoreBonus available. </returns>
        public int GetScoreBonusQuantity() => _scoreBonus.Quantity;

        /// <summary>
		/// Gives the quantity of TimeBonus.
		/// </summary>
		/// <returns> the quantity of TimeBonus available. </returns>
        public int GetTimeBonusQuantity() => _timeBonus.Quantity;

        /// <summary>
		/// Gives the quantity of WordBonus.
		/// </summary>
		/// <returns> the quantity of WordBonus available. </returns>
        public int GetWordBonusQuantity() => _wordBonus.Quantity;

        /// <summary>
		/// Apply the implications of the ScoreBonus.
		/// </summary>
		/// <param name="currentTime"></param>
		/// <returns> the updated score. </returns>
        public int ApplyScoreBonus(int currentScore, int gridTotalScore)
        {
            UpdateScoreBonusQuantity(b => b - 1);
            return _scoreBonus.Apply(currentScore, gridTotalScore);
        }

        /// <summary>
		/// Apply the implications of the TimeBonus.
		/// </summary>
		/// <param name="currentTime"></param>
		/// <returns> the updated time. </returns>
        public long ApplyTimeBonus(long currentTime)
        {
            UpdateTimeBonusQuantity(b => b - 1);
            return _timeBonus.Apply(currentTime);
        }

        /// <summary>
		/// Apply the implications of the WordBonus.
		/// </summary>
		/// <param name="currentTime"></param>
		/// <returns> the suggested words. </returns>
        public ISet<string> ApplyWordBonus(ISet<string> toFoundWords) 
        {
            UpdateWordBonusQuantity(b => b - 1);
            return _wordBonus.Apply(toFoundWords);
        }

        /// <summary>
		/// Extract randomly a bonus.
		/// </summary>
		/// <returns> the extracted bonus. </returns>
        public string ExtractBonus()
        {
            var extractedBonus = extracter().GetType();
            if (_scoreBonus.GetType().Equals(extractedBonus))
            {
                UpdateScoreBonusQuantity(q => q + 1);
                return _scoreBonus.Name;
            }
            if (_wordBonus.GetType().Equals(extractedBonus))
            {
                UpdateWordBonusQuantity(q => q + 1);
                return _wordBonus.Name;
            }
            if (_timeBonus.GetType().Equals(extractedBonus))
            {
                UpdateTimeBonusQuantity(q => q + 1);
                return _timeBonus.Name;
            }
            return ""; 
        }

        /// <summary>
        /// Extract randomly a bonus.
        /// </summary>
        /// <returns> the extracted bonus. </returns>
        private AbstractBonus extracter()
        {
            var random = new Random();
            var bonuses = new List<AbstractBonus>()
            { _bonusFactory.CreateScoreBonus(),
              _bonusFactory.CreateWordBonus(),
              _bonusFactory.CreateTimeBonus()
            };
            return bonuses[random.Next(bonuses.Count)];
        }
    }
}
