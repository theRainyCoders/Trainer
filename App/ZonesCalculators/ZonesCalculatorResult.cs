namespace TheRainyCoders.Trainer.ZonesCalculators
{
    using System.Collections.Generic;

    /// <summary>
    ///     Class that represents the result of calculated zones.
    /// </summary>
    public class ZonesCalculatorResult
    {
        /// <summary>
        ///     Gets the calculated zones.
        /// </summary>
        public List<ZonesCalculatorZone> Zones { get; } = new ();

        /// <summary>
        ///     Gets or sets the unit.
        /// </summary>
        public string Unit { get; set; }
    }
}
