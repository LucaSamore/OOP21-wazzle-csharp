using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP21_wazzle_csharp.Barbanti;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Barbanti.Tests
{
    [TestClass()]
    public sealed class WordElementTest
    {
        [TestMethod()]
        public void TestWordElementGetterAndSetter()
        {
            var wordElement1 = new WordElement('a', Result.WRONG);
            var wordElement2 = new WordElement('b', Result.CORRECT_WRONG_PLACE);
            var wordElement3 = new WordElement('c', Result.CORRECT);
            Assert.IsTrue(wordElement1.Result == Result.WRONG && wordElement1.Character == 'a');
            Assert.IsTrue(wordElement2.Result == Result.CORRECT_WRONG_PLACE && wordElement2.Character == 'b');
            Assert.IsTrue(wordElement3.Result == Result.CORRECT && wordElement3.Character == 'c');
        }
    }
}