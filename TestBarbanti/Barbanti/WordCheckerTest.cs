using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP21_wazzle_csharp.Barbanti.Tests
{
    [TestClass()]
    public sealed class WordCheckerTest
    {
        [TestMethod()]
        public void TestComputeAttempt()
        {
            var targetWord = "gatto";
            var wordChecker = new WordChecker(targetWord);

            var wrongGuessedWord = "tasto";

            var elementsOfWrongWord = new List<WordElement>
            {
                new WordElement('t', Result.CORRECT_WRONG_PLACE),
                new WordElement('a', Result.CORRECT),
                new WordElement('s', Result.WRONG),
                new WordElement('t', Result.CORRECT),
                new WordElement('o', Result.CORRECT),
            };

            var expectedWrongWord = new MiniGameWord(elementsOfWrongWord);
            Assert.IsTrue(wordChecker.ComputeAttemptResult(wrongGuessedWord).CompositeWord.SequenceEqual((expectedWrongWord).CompositeWord));
        }

        [TestMethod()]
        public void TestComputeAttempt2()
        {
            var targetWord = "gatto";
            var wordChecker = new WordChecker(targetWord);

            var correctGuessedWord = "gatto";

            var elementsOfCorrectWord = new List<WordElement>
            {
                new WordElement('g', Result.CORRECT),
                new WordElement('a', Result.CORRECT),
                new WordElement('t', Result.CORRECT),
                new WordElement('t', Result.CORRECT),
                new WordElement('o', Result.CORRECT),
            };

            var expectedCorrectWord = new MiniGameWord(elementsOfCorrectWord);

            Assert.IsTrue(wordChecker.ComputeAttemptResult(correctGuessedWord).CompositeWord.SequenceEqual((expectedCorrectWord).CompositeWord));
        }

        [TestMethod()]
        public void TestIsWordCorrect()
        {
            var targetWord = "gatto";
            var wordChecker = new WordChecker(targetWord);
            var wrongGuessedWord = "tasto";
            Assert.IsFalse(wordChecker.IsCorrectWord(wrongGuessedWord));
            Assert.IsTrue(wordChecker.IsCorrectWord(targetWord));
        }
    }
}