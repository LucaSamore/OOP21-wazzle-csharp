﻿using System.Collections.Generic;

namespace WazzleLuca
{
    /// <summary>
    /// Represents an interface for modeling a grid object. A grid contains a set of Letter objects
    /// previously generated by LetterAllocator. This interface provides some methods for retrieving 
    /// informations about the grid object.
    /// </summary>
    public interface IGrid
    {
        /// <summary>
        /// Returns the set of letters that this grid contains.
        /// </summary>
        /// <returns></returns>
        ISet<ILetter> Letters { get; }

        /// <summary>
        /// Returns the set of strings describing all the words you can find inside this grid.
        /// </summary>
        /// <returns></returns>
        ISet<string> WordsCanBeFound { get; }

        /// <summary>
        /// Returns the sum of all the single Letter score inside this grid.
        /// </summary>
        /// <returns></returns>
        int GetTotalScore();
    }
}