using System;
using System.Collections.Generic;

namespace WazzleLuca
{
    public sealed class Letter : ILetter
    {
        public char Content { get; }
        public Tuple<int, int> Position { get; }
        public int Score { get; }

        public Letter(char content, Tuple<int, int> position, int score)
        {
            Content = content;
            Position = position;
            Score = score;
        }

        public override bool Equals(object obj) => obj is Letter letter &&
                   Content == letter.Content &&
                   EqualityComparer<Tuple<int, int>>.Default.Equals(Position, letter.Position) &&
                   Score == letter.Score;
        public override int GetHashCode() => HashCode.Combine(Content, Position, Score);

        public override string ToString() => $"Content={Content} Position=({Position.Item1},{Position.Item2}) Score={Score}";
    }
}
