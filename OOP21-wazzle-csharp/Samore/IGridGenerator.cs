namespace OOP21_wazzle_csharp.Samore
{
    /// <summary>
    /// This interface provides a method for creating a Grid object.
    /// </summary>
    public interface IGridGenerator
    {
        /// <summary>
        /// Returns a new Grid object.
        /// </summary>
        /// <returns></returns>
        IGrid Generate();
    }
}
