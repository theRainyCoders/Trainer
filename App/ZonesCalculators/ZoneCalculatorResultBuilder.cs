namespace TheRainyCoders.Trainer.ZonesCalculators
{
    using System;

    /// <summary>
    ///     Class that helps to build the result of calculated zones.
    /// </summary>
    public class ZoneCalculatorResultBuilder : IZonesCalculatorResultBuilder
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ZoneCalculatorResultBuilder" /> class.
        /// </summary>
        public ZoneCalculatorResultBuilder()
        {
            this.Result = new ZonesCalculatorResult();
        }

        /// <summary>
        ///     Gets or sets the result.
        /// </summary>
        protected ZonesCalculatorResult Result { get; set; }

        /// <inheritdoc />
        public IZonesCalculatorResultBuilder AddZone(
            Guid id,
            string name,
            double minimum,
            double maximum,
            string? description = null)
        {
            var zone = new ZonesCalculatorZone
            {
                Id = id,
                Name = name,
                Minimum = minimum,
                Maximum = maximum,
                Description = description,
            };

            this.Result.Zones.Add(zone);

            return this;
        }

        /// <inheritdoc />
        public IZonesCalculatorResultBuilder AddZone(
            string name,
            double minimum,
            double maximum,
            string? description = null)
        {
            return this.AddZone(Guid.NewGuid(), name, minimum, maximum, description);
        }

        /// <inheritdoc/>
        public IZonesCalculatorResultBuilder SetUnit(string unit)
        {
            this.Result.Unit = unit;
            return this;
        }

        /// <inheritdoc />
        public ZonesCalculatorResult Build()
        {
            return this.Result;
        }
    }
}
