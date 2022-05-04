using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP21_wazzle_csharp;
using System.Collections.Generic;

namespace TestCastellucci
{
    [TestClass]
    public class LetterChooserTest
    {
        private readonly BonusManager _bonusManager = new BonusManager();

        [TestMethod]
        public void TestBonuses()
        {

			//ScoreBonus
			_bonusManager.UpdateScoreBonusQuantity(b => b + 1);
			Assert.AreEqual(_bonusManager.GetScoreBonusQuantity(), 1);
			var currentScore = 1000;
			var gridTotalScore = 100;
			Assert.IsTrue(_bonusManager.ApplyScoreBonus(currentScore, gridTotalScore) == currentScore + gridTotalScore);
			Assert.AreEqual(_bonusManager.GetScoreBonusQuantity(), 0);

			//WordBonus
			_bonusManager.UpdateWordBonusQuantity(b => b + 3);
			Assert.AreEqual(_bonusManager.GetWordBonusQuantity(), 3);
			_bonusManager.UpdateWordBonusQuantity(b => b - 1);
			Assert.AreEqual(_bonusManager.GetWordBonusQuantity(), 2);
			ISet<string> toFoundWords = new HashSet<string>(){ "cane", "gatto", "topo", "ape", "libellula", "rana"};
			ISet<string> suggestion = _bonusManager.ApplyWordBonus(toFoundWords);
			Assert.IsTrue(suggestion.IsSubsetOf(toFoundWords));
			Assert.AreEqual(suggestion.Count, 3);
			Assert.AreEqual(_bonusManager.GetWordBonusQuantity(), 1);

			//TimeBonus
			_bonusManager.UpdateTimeBonusQuantity(b => b + 2);
			Assert.AreEqual(_bonusManager.GetTimeBonusQuantity(), 2);
			long halfMinute = 30;
			long increment = 120;
			Assert.IsTrue(_bonusManager.ApplyTimeBonus(increment) == halfMinute + increment);
			Assert.AreEqual(_bonusManager.GetTimeBonusQuantity(), 1);

			//Extract
			int startQuantity = _bonusManager.GetScoreBonusQuantity() + _bonusManager.GetWordBonusQuantity()
							  + _bonusManager.GetTimeBonusQuantity();
			var word = _bonusManager.ExtractBonus();
			int finalQuantity = _bonusManager.GetScoreBonusQuantity() + _bonusManager.GetWordBonusQuantity()
			  + _bonusManager.GetTimeBonusQuantity();
			Assert.AreEqual(1, finalQuantity - startQuantity);

		}
	}
}
