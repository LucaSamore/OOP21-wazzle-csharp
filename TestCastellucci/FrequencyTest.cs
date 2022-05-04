using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP21_wazzle_csharp.Castellucci;
using System;
using System.Collections.Generic;
using System.Text;
using WazzleLuca;
using System.IO;

namespace TestCastellucci
{
    [TestClass]
    class FrequencyTest
    {
        private static readonly char SEPARATOR = Path.DirectorySeparatorChar;
        private readonly IDataset _dataset = DatasetReader.ReadDataset($"..{SEPARATOR}..{SEPARATOR}testDictionary.txt");
        private readonly IDictionary<char, double> _dictionary = new Dictionary<char, double>();
        

        [TestMethod]
        public void TestFrequency()
        {
            _dictionary.Add('A', 0.3125);
            _dictionary.Add('B', 0.25);
            _dictionary.Add('C', 0.1875);
            _dictionary.Add('D', 0.125);
            _dictionary.Add('E', 0.0625);
            _dictionary.Add('(', 0.0625);
            var weightedAlphabet = new WeightedAlphabet(_dictionary);
            var _frequency = new Frequency(_dataset);
            Assert.AreEqual(_dictionary, _frequency.ComputeFrequency().WeightedAlphabetMap);
        }
    }
}
