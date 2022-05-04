using System;
using System.Collections.Generic;
using System.Text;

namespace OOP21_wazzle_csharp.Castellucci
{
    /// <summary>
    /// This abstract class offers an abstraction for all the Bonuses.
    /// </summary>
    public abstract class AbstractBonus
    {
        protected string _name;

        /// <summary>
        /// Returns the quantity of the Bonus.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the name of the Bonus.
        /// </summary>
        public string Name { get => _name; set => _name = string.IsNullOrEmpty(value) ? throw new ArgumentNullException(nameof(Name), $"{Name} must not be null") : value; }

        /// <summary>
        /// Update the quantity of the bonus.
        /// </summary>
        /// <param name="operation"> represent the operation that needs to be done. </param>
        public void UpdateQuantity (Func<int, int> operation) => Quantity = operation.Invoke(Quantity);

        /// <summary>
        /// Check if the quantity is over or not.
        /// </summary>
        /// <returns> if the Bonus is over or not. </returns>
        public bool IsOver() => Quantity == 0;

        public override bool Equals(object obj) => obj is AbstractBonus bonus &&
                   Quantity == bonus.Quantity &&
                   Name == bonus.Name;

        public override int GetHashCode() => HashCode.Combine(Quantity, Name);

        public override string ToString() => $"name = {Name}, quantity = {Quantity}";
    }
}
