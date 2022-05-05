using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace OOP21_wazzle_csharp.Barbanti.Tests
{
    [TestClass()]
    public sealed class FiveLetterDictionaryTest
    {
        [TestMethod()]
        public void TestFiveLetterDictionary()
        {
            var initialDataset = new HashSet<string>
            {
                "AAAAA",
                "BBBBB",
                "CCC",
                "DD",
                "E",
            };

            var targetDataSet = new HashSet<string>
            {
                "AAAAA",
                "BBBBB"
            };

            var dictionary = new ConcreteDictionary(initialDataset);
            var filteredDictionary = new FiveLetterDictionary(dictionary);

            Assert.IsTrue(filteredDictionary.GetWords().SetEquals(targetDataSet));
        }
    }
}