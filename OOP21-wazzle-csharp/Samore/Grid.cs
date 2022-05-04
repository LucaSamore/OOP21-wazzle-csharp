using System;
using System.Collections.Generic;
using System.Linq;

namespace WazzleLuca
{
    public sealed class Grid : IGrid
    {
        private static readonly string SEPARATOR = Environment.NewLine;
        public ISet<ILetter> Letters { get; }
        public ISet<string> WordsCanBeFound { get; }
        public Grid(ISet<ILetter> letters, ISet<string> wordsCanBeFound)
        {
            Letters = letters;
            WordsCanBeFound = wordsCanBeFound;
        }
        public int GetTotalScore() => Letters.Sum(l => l.Score);

        public override bool Equals(object obj) => obj is Grid grid &&
                   EqualityComparer<ISet<ILetter>>.Default.Equals(Letters, grid.Letters) &&
                   EqualityComparer<ISet<string>>.Default.Equals(WordsCanBeFound, grid.WordsCanBeFound);
        public override int GetHashCode() => HashCode.Combine(Letters, WordsCanBeFound);

        public override string ToString() => $"Here's a lo<3ly grid:{SEPARATOR}" +
            $"Letters inside the grid:{SEPARATOR}" +
            $"{Letters}{SEPARATOR}" +
            $"Words you can find:{SEPARATOR}" +
            $"{WordsCanBeFound}";
    }
}
