using System.Collections.Generic;

namespace OOP21_wazzle_csharp.Samore
{
    /// <summary>
    /// An interface for modeling the dataset.
    /// </summary>
    public interface IDataset
    {
        /// <summary>
        /// Returns a set of strings containing all the words inside the dataset.
        /// </summary>
        ISet<string> Words { get; }
    }
}
