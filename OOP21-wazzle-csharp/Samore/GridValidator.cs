using System.Collections.Generic;
using System.Linq;

namespace OOP21_wazzle_csharp.Samore
{
    public sealed class GridValidator : IGridValidator
    {
        private readonly IDataset _dataset;
        private readonly Difficulty _difficulty;

        public GridValidator(IDataset dataset, Difficulty difficulty)
        {
            _dataset = dataset;
            _difficulty = difficulty;
        }

        public bool ApplyFilters(string word, ISet<ILetter> letters) => 
            IFilters.FilterLetters.Invoke(word, letters) && 
            IFilters.FilterPaths.Invoke(word, letters);

        public ISet<string> Validate(ISet<ILetter> letters)
        {
            var filteredLetters = _dataset.Words.Where(w => ApplyFilters(w, letters)).ToHashSet();
            return QualityCheck(filteredLetters) ? filteredLetters : null;
        }

        private bool QualityCheck(ISet<string> words) => words != null ? words.Count >= _difficulty.LowerBound && words.Count <= _difficulty.UpperBound : false;
    }
}
