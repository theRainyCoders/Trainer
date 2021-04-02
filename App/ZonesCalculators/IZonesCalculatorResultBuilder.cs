namespace TheRainyCoders.Trainer.ZonesCalculators
{
    using System;

    /// <summary>
    ///     Interface that describes a builder to create a zone result.
    /// </summary>
    public interface IZonesCalculatorResultBuilder
    {
        /// <summary>
        ///     Set the unit of the calculated zones.
        /// </summary>
        /// <param name="unit">Unit of the zones.</param>
        /// <returns>The <see cref="IZonesCalculatorResultBuilder" />.</returns>
        IZonesCalculatorResultBuilder SetUnit(string unit);

        /// <summary>
        ///     Add zone to the builder.
        /// </summary>
        /// <param name="id">Unique id to identify the zone.</param>
        /// <param name="name">Name of the zone.</param>
        /// <param name="minimum">Minimum (start) of the zone range.</param>
        /// <param name="maximum">Maximum (end) of the zone range.</param>
        /// <param name="description">Some detail information.</param>
        /// <returns>The <see cref="IZonesCalculatorResultBuilder" />.</returns>
        IZonesCalculatorResultBuilder AddZone(Guid id, string name, double minimum, double maximum, string description);

        /// <summary>
        ///     Add zone to the builder.
        /// </summary>
        /// <param name="name">Name of the zone.</param>
        /// <param name="minimum">Minimum (start) of the zone range.</param>
        /// <param name="maximum">Maximum (end) of the zone range.</param>
        /// <param name="description">Some detail information.</param>
        /// <returns>The <see cref="IZonesCalculatorResultBuilder" />.</returns>
        IZonesCalculatorResultBuilder AddZone(
            string name,
            double minimum,
            double maximum,
            string? description = null);

        /// <summary>
        ///     Build up the zones result.
        /// </summary>
        /// <returns>The <see cref="ZonesCalculatorResult" />.</returns>
        ZonesCalculatorResult Build();
    }
}
