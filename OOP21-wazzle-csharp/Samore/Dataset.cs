using System;
using System.Collections.Generic;

namespace OOP21_wazzle_csharp.Samore
{
    public sealed class Dataset : IDataset
    {
        public ISet<string> Words { get; }
        public Dataset(ISet<string> words) => Words = words;

        public override bool Equals(object obj) => obj is Dataset dataset &&
                   EqualityComparer<ISet<string>>.Default.Equals(Words, dataset.Words);

        public override int GetHashCode() => HashCode.Combine(Words);

        public override string ToString() => $"{Words}";
    }
}
