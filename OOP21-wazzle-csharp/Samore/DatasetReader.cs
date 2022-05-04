﻿using System.Collections.Generic;
using System.IO;

namespace WazzleLuca
{
    public sealed class DatasetReader
    {
        private DatasetReader() { }

        public static IDataset ReadDataset(string path) => new Dataset(new HashSet<string>(File.ReadAllLines(path)));
    }
}
