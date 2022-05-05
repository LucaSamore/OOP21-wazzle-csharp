using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP21_wazzle_csharp.Barbanti
{
    /// <summary>
    /// This class handles all computing operation on the attemps made by the user, more specifically
    /// it can check if a word is correct and compute the differencies between the targetWord and the guessed one.
    /// </summary>
    public sealed class WordChecker
    {
        private readonly string _targetWord;
        private IList<char> _lettersLeftToGuess;

        /// <summary>
        /// Initializes a new instance of the <see cref="WordChecker"/> class.
        /// </summary>
        /// <param name="targetWord">The target word that must be guessed.</param>
        public WordChecker(string targetWord)
        {
            _targetWord = targetWord;
            _lettersLeftToGuess = new List<char>();
        }

        /// <summary>
        /// Given a wrong word it computes the differencies between the correct word and the wrong one.
        /// It creates a new <see cref="MiniGameWord"/> containg the result of the computation.
        /// </summary>
        /// <param name="attempt">The word guessed by the user.</param>
        /// <returns>A new <see cref="MiniGameWord"/> containing the result of the computation.</returns>
        public MiniGameWord ComputeAttemptResult(string guessedWord)
        {
            var result = new List<WordElement>();
            _lettersLeftToGuess = _targetWord.ToList();
            SetAllCorrectLetterInTheRightPlace(guessedWord, result);
            SetAllRemainingLetterState(result);
            return new MiniGameWord(result);
        }

        /// <summary>
        /// Check without computing if the word guessed by the user is the correct one by comparing it with the target word to be guessed.
        /// </summary>
        /// <param name="guessedWord">The guessed word.</param>
        /// <returns>True if the word is correct, false otherwise.</returns>
        public bool IsCorrectWord(string guessedWord) => guessedWord.Equals(_targetWord);

        private void SetAllCorrectLetterInTheRightPlace(string guessedWord, IList<WordElement> result)
        {
            for (int i = 0; i < guessedWord.Length; i++)
            {
                if (guessedWord[i] == _targetWord[i])
                {
                    result.Add(new WordElement(guessedWord[i], Result.CORRECT));
                    _lettersLeftToGuess.Remove(guessedWord[i]);
                }
                else
                {
                    result.Add(new WordElement(guessedWord[i], Result.NOT_SET));
                }
            }
        }

        private void SetAllRemainingLetterState(IList<WordElement> result)
        {
            result.Where(result => result.Result == Result.NOT_SET)
                .ToList()
                .ForEach(result => result.Result = _lettersLeftToGuess.Contains(result.Character) ?
                        Result.CORRECT_WRONG_PLACE : Result.WRONG);
        }
    }
}
