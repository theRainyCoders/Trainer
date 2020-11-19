namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators
{
    using System;

    /// <summary>
    ///     Interface that describes a builder for creating the description of a <see cref="IZonesCalculator" />.
    /// </summary>
    internal interface IZonesCalculatorDescriptionBuilder
    {
        /// <summary>
        ///     Add the general description of the zone calculator.
        /// </summary>
        /// <param name="id">
        ///     The unique id of the zone calculator.
        /// </param>
        /// <param name="name">
        ///     The name.
        /// </param>
        /// <param name="description">
        ///     The description.
        /// </param>
        /// <returns>
        ///     The <see cref="IZonesCalculatorDescriptionBuilder" />.
        /// </returns>
        IZonesCalculatorDescriptionBuilder AddDescription(Guid id, string name, string? description = null);

        /// <summary>
        ///     Add the description for an input value.
        /// </summary>
        /// <param name="id">
        ///     The unique id of an input value.
        /// </param>
        /// <param name="name">
        ///     The name.
        /// </param>
        /// <param name="description">
        ///     The description.
        /// </param>
        /// <returns>
        ///     The <see cref="IZonesCalculatorDescriptionBuilder" />.
        /// </returns>
        IZonesCalculatorDescriptionBuilder AddInputValueDescription(Guid id, string name, string? description = null);

        /// <summary>
        ///     Creates the description of the zone calculator.
        /// </summary>
        /// <returns>
        ///     The <see cref="ZonesCalculatorDescription" />.
        /// </returns>
        ZonesCalculatorDescription Build();
    }
}
