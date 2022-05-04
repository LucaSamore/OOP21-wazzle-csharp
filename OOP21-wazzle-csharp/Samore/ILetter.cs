using System;

namespace OOP21_wazzle_csharp.Samore
{
    /// <summary>
    /// Represents an interface for modeling a Letter object.
    /// </summary>
    public interface ILetter
    {
        /// <summary>
        /// Returns the content of this letter
        /// </summary>
        /// <returns>A char describing the actual character of this letter</returns>
        char Content { get; }

        /// <summary>
        /// Returns the position of this letter
        /// </summary>
        /// <returns>A tuple which represents the position of this letter</returns>
        Tuple<int, int> Position { get; }

        /// <summary>
        /// Returns the score of this letter
        /// </summary>
        /// <returns>An integer which represents the score of this letter</returns>
        int Score { get; }
    }
}
