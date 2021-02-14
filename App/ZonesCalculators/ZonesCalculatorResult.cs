namespace TheRainyCoders.Trainer.ZonesCalculators
{
    using System.Collections.Generic;

    /// <summary>
    ///     Class that represents the result of calculated zones.
    /// </summary>
    public class ZonesCalculatorResult
    {
        /// <summary>
        ///     Gets the zones.
        /// </summary>
        public List<ZonesCalculatorZone> Zones { get; } = new List<ZonesCalculatorZone>();
    }
}
