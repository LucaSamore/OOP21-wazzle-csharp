using System;

namespace WazzleLuca
{
    /// <summary>
    /// This enum groups all the Difficulty names.
    /// </summary>
    public enum DifficultyNames
    {
        EASY, HARD
    }

    /// <summary>
    ///  This class represents a configuration for MainGame difficulty. 
    ///  More precisely, it encapsulates all the parameters used for improving the difficulty of a Grid.
    ///  It also provides a default configuration via the DEFAULT property
    /// </summary>
    public sealed class Difficulty
    {
        private static readonly string SEPARATOR = Environment.NewLine;
        private static readonly DifficultyNames DEFAULT_NAME = DifficultyNames.EASY;
        private static readonly int DEFAULT_SHAPE = 4;
        private static readonly int DEFAULT_LOWER_BOUND = 76;
        private static readonly int DEFAULT_UPPER_BOUND = 200;
        private static readonly long DEFAULT_TIME = 240_000L;

        /// <summary>
        /// Returns the name of this difficulty configuration.
        /// </summary>
        public DifficultyNames DifficultyName { get; }

        /// <summary>
        /// Returns the shape of this difficulty configuration.
        /// </summary>
        public int GridShape { get; }

        /// <summary>
        /// Returns the lower bound of this difficulty configuration.
        /// </summary>
        public int LowerBound { get; }

        /// <summary>
        /// Returns the upper bound of this difficulty configuration.
        /// </summary>
        public int UpperBound { get; }

        /// <summary>
        /// Returns the time in milliseconds of this difficulty configuration.
        /// </summary>
        public long Time { get;  }

        /// <summary>
        /// Returns the default configuration.
        /// </summary>
        public static Difficulty DEFAULT { get => new Difficulty(
            DEFAULT_NAME, 
            DEFAULT_SHAPE, 
            DEFAULT_LOWER_BOUND, 
            DEFAULT_UPPER_BOUND, 
            DEFAULT_TIME); }

        public Difficulty(DifficultyNames name, int gridShape, int lowerBound, int upperBound, long time)
        {
            DifficultyName = name;
            GridShape = gridShape;
            LowerBound = lowerBound;
            UpperBound = upperBound;
            Time = time;
        }

        public override bool Equals(object obj) => obj is Difficulty difficulty &&
                   DifficultyName == difficulty.DifficultyName &&
                   GridShape == difficulty.GridShape &&
                   LowerBound == difficulty.LowerBound &&
                   UpperBound == difficulty.UpperBound &&
                   Time == difficulty.Time;

        public override int GetHashCode() => HashCode.Combine(DifficultyName, GridShape, LowerBound, UpperBound, Time);

        public override string ToString() => $"Difficulty status:{SEPARATOR}" +
            $"Name={DifficultyName}{SEPARATOR}" +
            $"GridShape={GridShape}{SEPARATOR}" +
            $"LowerBound={LowerBound}{SEPARATOR}" +
            $"UpperBound={UpperBound}{SEPARATOR}" +
            $"Time={Time}";
    }
}
