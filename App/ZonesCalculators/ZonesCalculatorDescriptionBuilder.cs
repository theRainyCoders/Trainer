namespace TheRainyCoders.Trainer.ZonesCalculators
{
    using System;

    /// <summary>
    ///     Builder to create a description of a <see cref="IZonesCalculator" />.
    /// </summary>
    public class ZonesCalculatorDescriptionBuilder : IZonesCalculatorDescriptionBuilder
    {
        /// <summary>
        ///     Gets or sets the description.
        /// </summary>
        protected ZonesCalculatorDescription Description { get; set; }

        /// <inheritdoc />
        public virtual IZonesCalculatorDescriptionBuilder AddDescription(
            Guid id,
            string name,
            string? description = null)
        {
            this.Description = new ZonesCalculatorDescription(id, name, description);
            return this;
        }

        /// <inheritdoc />
        public virtual IZonesCalculatorDescriptionBuilder AddInputValueDescription(
            Guid id,
            string name,
            string? description = null)
        {
            var inputValueDescription = new ZoneCalculatorInputValueDescription(id, name, description);

            this.Description.InputValueDescriptions.Add(inputValueDescription);

            return this;
        }

        /// <inheritdoc />
        public virtual ZonesCalculatorDescription Build()
        {
            return this.Description;
        }
    }
}
