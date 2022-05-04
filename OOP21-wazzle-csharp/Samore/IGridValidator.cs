using System.Collections.Generic;

namespace OOP21_wazzle_csharp.Samore
{
    /// <summary>
    /// This interface provides a method for validating the quality of a given set of Letter objects.
    /// If the provided set is good, it returns a set of strings containing all the words that can be formed 
    /// using the letters inside the previous set.
    /// </summary>
    public interface IGridValidator : IFilters
    {
        /// <summary>
        /// Given a set of Letter objects, returns a set of strings containing the result of the validation process.
        /// </summary>
        /// <param name="letters"></param>
        /// <returns></returns>
        ISet<string> Validate(ISet<ILetter> letters);
    }
}
