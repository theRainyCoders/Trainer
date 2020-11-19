namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    ///     Interface that describes a zone calculator.
    /// </summary>
    internal interface IZonesCalculator : IValidatableObject
    {
        /// <summary>
        ///     Gets the description.
        /// </summary>
        ZonesCalculatorDescription Description { get; }

        /// <summary>
        ///     Calculate the zones by the given inputValues values.
        /// </summary>
        /// <param name="inputValues">
        ///     The input values.
        /// </param>
        /// <returns>
        ///     The <see cref="ZonesCalculatorResult" />.
        /// </returns>
        ZonesCalculatorResult Calculate(IReadOnlyCollection<ZonesCalculatorInputValue> inputValues);
    }
}
