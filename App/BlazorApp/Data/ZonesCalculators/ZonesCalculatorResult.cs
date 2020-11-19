namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators
{
    using System.Collections.Generic;

    /// <summary>
    ///     Class that represents the result of calculated zones.
    /// </summary>
    internal class ZonesCalculatorResult
    {
        /// <summary>
        ///     Gets the zones.
        /// </summary>
        public List<ZonesCalculatorZone> Zones { get; } = new List<ZonesCalculatorZone>();
    }
}
