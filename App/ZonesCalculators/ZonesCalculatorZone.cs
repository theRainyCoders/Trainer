namespace TheRainyCoders.Trainer.ZonesCalculators
{
    using System;

    /// <summary>
    ///     Class to describe a calculated zone.
    /// </summary>
    public struct ZonesCalculatorZone
    {
        /// <summary>
        ///     Gets or sets the unique id of the zone.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        public string? Description { get; set; }

        /// <summary>
        ///     Gets or sets the minimum.
        /// </summary>
        public double Minimum { get; set; }

        /// <summary>
        ///     Gets or sets the maximum.
        /// </summary>
        public double Maximum { get; set; }
    }
}
