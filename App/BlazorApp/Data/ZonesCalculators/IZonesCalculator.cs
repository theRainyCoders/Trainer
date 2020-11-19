namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators
{
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
        ///     Calculate the zones by the given input values.
        /// </summary>
        /// <param name="input">
        ///     The input.
        /// </param>
        /// <returns>
        ///     The <see cref="ZonesCalculatorResult" />.
        /// </returns>
        ZonesCalculatorResult Calculate(ZonesCalculatorInput input);
    }
}
