using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP21_wazzle_csharp.Samore;
using System;
using System.Collections.Generic;
using System.IO;

namespace TestSamore.Samore
{
    [TestClass()]
    public sealed class GeneratorTest
    {
        private static readonly char SEPARATOR = Path.DirectorySeparatorChar;
        private readonly IDataset _dataset = DatasetReader.ReadDataset($"..{SEPARATOR}..{SEPARATOR}..{SEPARATOR}dataset.txt");
        private readonly Difficulty _easy4x4 = new Difficulty(DifficultyNames.EASY, 4, 76, 200, 240_000L);
        private readonly Difficulty _hard4x4 = new Difficulty(DifficultyNames.HARD, 4, 25, 75, 180_000L);
        private readonly Difficulty _easy5x5 = new Difficulty(DifficultyNames.EASY, 5, 151, 250, 240_000L);
        private readonly Difficulty _hard5x5 = new Difficulty(DifficultyNames.HARD, 5, 100, 150, 180_000L);
        private readonly Difficulty _easy6x6 = new Difficulty(DifficultyNames.EASY, 6, 226, 350, 240_000L);
        private readonly Difficulty _hard6x6 = new Difficulty(DifficultyNames.HARD, 6, 150, 225, 180_000L);

        [TestMethod()]
        public void TestEasy4x4()
        {
            var generator = new GridGenerator(_dataset, _easy4x4)
            {
                Letters = new HashSet<ILetter>()
                {
                    new Letter('i', new Tuple<int, int>(2, 1), 2),
                    new Letter('i', new Tuple<int, int>(3, 0), 2),
                    new Letter('c', new Tuple<int, int>(3, 2), 5),
                    new Letter('i', new Tuple<int, int>(0, 2), 2),
                    new Letter('i', new Tuple<int, int>(0, 0), 2),
                    new Letter('i', new Tuple<int, int>(1, 2), 2),
                    new Letter('i', new Tuple<int, int>(2, 3), 2),
                    new Letter('n', new Tuple<int, int>(3, 1), 5),
                    new Letter('r', new Tuple<int, int>(1, 1), 3),
                    new Letter('s', new Tuple<int, int>(3, 3), 4),
                    new Letter('m', new Tuple<int, int>(0, 3), 6),
                    new Letter('u', new Tuple<int, int>(2, 0), 6),
                    new Letter('t', new Tuple<int, int>(1, 0), 4),
                    new Letter('t', new Tuple<int, int>(2, 2), 4),
                    new Letter('a', new Tuple<int, int>(0, 1), 1),
                    new Letter('a', new Tuple<int, int>(1, 3), 1)
                }
            };

            var grid = generator.Generate();

            Assert.IsFalse(grid is null);
        }

        [TestMethod()]
        public void TestHard4x4()
        {
            var generator = new GridGenerator(_dataset, _hard4x4)
            {
                Letters = new HashSet<ILetter>()
                {
                    new Letter('i', new Tuple<int, int>(3, 0), 2),
                    new Letter('e', new Tuple<int, int>(1, 0), 3),
                    new Letter('i', new Tuple<int, int>(2, 3), 2),
                    new Letter('r', new Tuple<int, int>(1, 1), 3),
                    new Letter('r', new Tuple<int, int>(2, 1), 3),
                    new Letter('o', new Tuple<int, int>(1, 2), 3),
                    new Letter('o', new Tuple<int, int>(2, 2), 3),
                    new Letter('v', new Tuple<int, int>(3, 2), 6),
                    new Letter('t', new Tuple<int, int>(3, 3), 4),
                    new Letter('c', new Tuple<int, int>(0, 3), 5),
                    new Letter('a', new Tuple<int, int>(3, 1), 1),
                    new Letter('e', new Tuple<int, int>(0, 1), 3),
                    new Letter('e', new Tuple<int, int>(0, 2), 3),
                    new Letter('w', new Tuple<int, int>(2, 0), 7),
                    new Letter('a', new Tuple<int, int>(1, 3), 1),
                    new Letter('a', new Tuple<int, int>(0, 0), 1)
                }
            };

            var grid = generator.Generate();

            Assert.IsFalse(grid is null);
        }

        [TestMethod()]
        public void TestEasy5x5()
        {
            var generator = new GridGenerator(_dataset, _easy5x5)
            {
                Letters = new HashSet<ILetter>()
                {
                    new Letter('i', new Tuple<int, int>(3, 1), 2),
                    new Letter('i', new Tuple<int, int>(4, 1), 2),
                    new Letter('q', new Tuple<int, int>(0, 1), 7),
                    new Letter('r', new Tuple<int, int>(2, 1), 3),
                    new Letter('t', new Tuple<int, int>(4, 3), 4),
                    new Letter('t', new Tuple<int, int>(3, 3), 4),
                    new Letter('a', new Tuple<int, int>(4, 2), 1),
                    new Letter('e', new Tuple<int, int>(3, 4), 3),
                    new Letter('e', new Tuple<int, int>(2, 4), 3),
                    new Letter('i', new Tuple<int, int>(0, 2), 2),
                    new Letter('e', new Tuple<int, int>(4, 4), 3),
                    new Letter('i', new Tuple<int, int>(0, 0), 2),
                    new Letter('e', new Tuple<int, int>(3, 0), 3),
                    new Letter('n', new Tuple<int, int>(2, 0), 5),
                    new Letter('q', new Tuple<int, int>(1, 4), 7),
                    new Letter('m', new Tuple<int, int>(2, 2), 6),
                    new Letter('s', new Tuple<int, int>(0, 4), 4),
                    new Letter('n', new Tuple<int, int>(1, 2), 5),
                    new Letter('t', new Tuple<int, int>(1, 0), 4),
                    new Letter('s', new Tuple<int, int>(3, 2), 4),
                    new Letter('e', new Tuple<int, int>(0, 3), 3),
                    new Letter('e', new Tuple<int, int>(2, 3), 3),
                    new Letter('e', new Tuple<int, int>(1, 3), 3),
                    new Letter('v', new Tuple<int, int>(4, 0), 6),
                    new Letter('a', new Tuple<int, int>(1, 1), 1)
                }
            };

            var grid = generator.Generate();

            Assert.IsFalse(grid is null);
        }

        [TestMethod()]
        public void TestHard5x5()
        {
            var generator = new GridGenerator(_dataset, _hard5x5)
            {
                Letters = new HashSet<ILetter>()
                {
                    new Letter('i', new Tuple<int, int>(0, 3), 2),
                    new Letter('r', new Tuple<int, int>(4, 3), 3),
                    new Letter('p', new Tuple<int, int>(3, 3), 6),
                    new Letter('o', new Tuple<int, int>(1, 3), 3),
                    new Letter('s', new Tuple<int, int>(2, 1), 4),
                    new Letter('t', new Tuple<int, int>(1, 1), 4),
                    new Letter('q', new Tuple<int, int>(4, 1), 7),
                    new Letter('a', new Tuple<int, int>(2, 0), 1),
                    new Letter('e', new Tuple<int, int>(1, 2), 3),
                    new Letter('e', new Tuple<int, int>(0, 2), 3),
                    new Letter('e', new Tuple<int, int>(2, 4), 3),
                    new Letter('a', new Tuple<int, int>(1, 0), 1),
                    new Letter('a', new Tuple<int, int>(4, 4), 1),
                    new Letter('i', new Tuple<int, int>(4, 2), 2),
                    new Letter('e', new Tuple<int, int>(3, 0), 3),
                    new Letter('i', new Tuple<int, int>(3, 4), 2),
                    new Letter('g', new Tuple<int, int>(1, 4), 6),
                    new Letter('t', new Tuple<int, int>(0, 4), 4),
                    new Letter('o', new Tuple<int, int>(4, 0), 3),
                    new Letter('o', new Tuple<int, int>(3, 2), 3),
                    new Letter('o', new Tuple<int, int>(2, 2), 3),
                    new Letter('v', new Tuple<int, int>(0, 0), 6),
                    new Letter('a', new Tuple<int, int>(3, 1), 1),
                    new Letter('a', new Tuple<int, int>(0, 1), 1),
                    new Letter('a', new Tuple<int, int>(2, 3), 1)
                }
            };

            var grid = generator.Generate();

            Assert.IsFalse(grid is null);
        }

        [TestMethod()]
        public void TestEasy6x6()
        {
            var generator = new GridGenerator(_dataset, _easy6x6)
            {
                Letters = new HashSet<ILetter>()
                {
                    new Letter('i', new Tuple<int, int>(2, 1), 2),
                    new Letter('o', new Tuple<int, int>(2, 5), 3),
                    new Letter('b', new Tuple<int, int>(4, 3), 6),
                    new Letter('i', new Tuple<int, int>(1, 3), 3),
                    new Letter('g', new Tuple<int, int>(1, 5), 4),
                    new Letter('c', new Tuple<int, int>(5, 5), 4),
                    new Letter('i', new Tuple<int, int>(4, 5), 7),
                    new Letter('e', new Tuple<int, int>(5, 3), 1),
                    new Letter('d', new Tuple<int, int>(1, 1), 3),
                    new Letter('r', new Tuple<int, int>(2, 3), 3),
                    new Letter('t', new Tuple<int, int>(3, 5), 3),
                    new Letter('n', new Tuple<int, int>(0, 3), 1),
                    new Letter('n', new Tuple<int, int>(3, 3), 1),
                    new Letter('t', new Tuple<int, int>(5, 1), 2),
                    new Letter('r', new Tuple<int, int>(4, 1), 3),
                    new Letter('e', new Tuple<int, int>(1, 2), 2),
                    new Letter('e', new Tuple<int, int>(0, 2), 6),
                    new Letter('a', new Tuple<int, int>(4, 4), 4),
                    new Letter('i', new Tuple<int, int>(2, 0), 3),
                    new Letter('e', new Tuple<int, int>(5, 0), 3),
                    new Letter('i', new Tuple<int, int>(3, 0), 3),
                    new Letter('g', new Tuple<int, int>(3, 2), 6),
                    new Letter('g', new Tuple<int, int>(0, 4), 1),
                    new Letter('i', new Tuple<int, int>(1, 4), 1),
                    new Letter('i', new Tuple<int, int>(0, 0), 1),
                    new Letter('i', new Tuple<int, int>(2, 2), 1),
                    new Letter('e', new Tuple<int, int>(5, 2), 1),
                    new Letter('i', new Tuple<int, int>(3, 4), 1),
                    new Letter('o', new Tuple<int, int>(4, 0), 1),
                    new Letter('r', new Tuple<int, int>(2, 4), 1),
                    new Letter('o', new Tuple<int, int>(1, 0), 1),
                    new Letter('a', new Tuple<int, int>(0, 5), 1),
                    new Letter('s', new Tuple<int, int>(5, 4), 1),
                    new Letter('t', new Tuple<int, int>(4, 2), 1),
                    new Letter('a', new Tuple<int, int>(3, 1), 1),
                    new Letter('e', new Tuple<int, int>(0, 1), 1)
                }
            };

            var grid = generator.Generate();

            Assert.IsFalse(grid is null);
        }

        [TestMethod()]
        public void TestHard6x6()
        {
            var generator = new GridGenerator(_dataset, _hard6x6)
            {
                Letters = new HashSet<ILetter>()
                {
                    new Letter('j', new Tuple<int, int>(1, 5), 2),
                    new Letter('i', new Tuple<int, int>(2, 1), 3),
                    new Letter('e', new Tuple<int, int>(5, 1), 6),
                    new Letter('n', new Tuple<int, int>(0, 5), 3),
                    new Letter('b', new Tuple<int, int>(4, 3), 4),
                    new Letter('e', new Tuple<int, int>(1, 1), 4),
                    new Letter('f', new Tuple<int, int>(0, 1), 7),
                    new Letter('n', new Tuple<int, int>(3, 1), 1),
                    new Letter('r', new Tuple<int, int>(2, 3), 3),
                    new Letter('o', new Tuple<int, int>(5, 3), 3),
                    new Letter('n', new Tuple<int, int>(0, 3), 3),
                    new Letter('n', new Tuple<int, int>(4, 5), 1),
                    new Letter('t', new Tuple<int, int>(4, 1), 1),
                    new Letter('b', new Tuple<int, int>(0, 4), 2),
                    new Letter('e', new Tuple<int, int>(0, 2), 3),
                    new Letter('e', new Tuple<int, int>(2, 4), 2),
                    new Letter('i', new Tuple<int, int>(1, 0), 6),
                    new Letter('i', new Tuple<int, int>(4, 0), 4),
                    new Letter('i', new Tuple<int, int>(3, 0), 3),
                    new Letter('e', new Tuple<int, int>(4, 4), 3),
                    new Letter('i', new Tuple<int, int>(1, 4), 3),
                    new Letter('i', new Tuple<int, int>(0, 0), 6),
                    new Letter('i', new Tuple<int, int>(2, 2), 1),
                    new Letter('e', new Tuple<int, int>(5, 2), 1),
                    new Letter('o', new Tuple<int, int>(4, 2), 1),
                    new Letter('h', new Tuple<int, int>(5, 0), 1),
                    new Letter('m', new Tuple<int, int>(3, 2), 1),
                    new Letter('n', new Tuple<int, int>(5, 4), 1),
                    new Letter('r', new Tuple<int, int>(1, 2), 1),
                    new Letter('n', new Tuple<int, int>(3, 4), 1),
                    new Letter('a', new Tuple<int, int>(2, 5), 1),
                    new Letter('t', new Tuple<int, int>(2, 0), 1),
                    new Letter('e', new Tuple<int, int>(1, 3), 1),
                    new Letter('a', new Tuple<int, int>(3, 5), 1),
                    new Letter('a', new Tuple<int, int>(3, 3), 1),
                    new Letter('a', new Tuple<int, int>(5, 5), 1)
                }
            };

            var grid = generator.Generate();

            Assert.IsFalse(grid is null);
        }
    }
}