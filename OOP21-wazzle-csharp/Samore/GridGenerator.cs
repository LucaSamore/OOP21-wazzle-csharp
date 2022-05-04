using System;
using System.Collections.Generic;

namespace WazzleLuca
{
    public sealed class GridGenerator : IGridGenerator
    {
        private readonly IGridValidator _validator;
        private ISet<ILetter> _letters;
        public ISet<ILetter> Letters
        {
            get => _letters;
            set => _letters = value ?? throw new ArgumentNullException(nameof(value), $"{nameof(Letters)} cannot be null");
        }

        public GridGenerator(IDataset dataset, Difficulty difficulty) => _validator = new GridValidator(dataset, difficulty);
        public IGrid Generate()
        {
            Tuple<ISet<ILetter>, ISet<string>> newGrid = null;

            while(newGrid is null)
            {
                newGrid = TryGenerate();
            }

            return new Grid(newGrid.Item1, newGrid.Item2);
        }

        private Tuple<ISet<ILetter>, ISet<string>> TryGenerate()
        {
            var validationResult = _validator.Validate(Letters);
            return validationResult != null ? new Tuple<ISet<ILetter>, ISet<string>>(Letters, validationResult) : null;
        }
    }
}
