using System.Collections.Generic;
using System.IO;
using System;

namespace OOP21_wazzle_csharp.Samore
{
    public sealed class DatasetReader
    {
        private DatasetReader() { }

        public static IDataset ReadDataset(string path) => new Dataset(new HashSet<string>(File.ReadAllLines(path)));
    }
}
