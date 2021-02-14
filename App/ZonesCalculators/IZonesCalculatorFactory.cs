namespace TheRainyCoders.Trainer.ZonesCalculators
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     Interface that describes a factory for creating <see cref="IZonesCalculator" />.
    /// </summary>
    public interface IZonesCalculatorFactory
    {
        /// <summary>
        ///     Get the description of all available zone calculators.
        /// </summary>
        /// <returns>
        ///     The <see cref="IReadOnlyCollection{ZoonesCalculatorDescription}" />.
        /// </returns>
        IEnumerable<ZonesCalculatorDescription> GetAvailableCalculators();

        /// <summary>
        ///     Creates a instance of a zone calculator.
        /// </summary>
        /// <param name="id">
        ///     The unique id of the zone calculator that should be created.
        /// </param>
        /// <returns>
        ///     The <see cref="IZonesCalculator" />.
        /// </returns>
        IZonesCalculator Create(Guid id);
    }
}
