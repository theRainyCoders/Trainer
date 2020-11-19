namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators
{
    using System;
    using System.Collections.Generic;

    using TheRainyCoders.Commonplace.Data;

    /// <summary>
    ///     Class that represents a zones calculator description.
    /// </summary>
    internal readonly struct ZonesCalculatorDescription : IReadonlyDescribe
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ZonesCalculatorDescription" /> struct.
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
        public ZonesCalculatorDescription(Guid id, string name, string? description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.InputValueDescriptions = new List<ZoneCalculatorInputValueDescription>();
        }

        /// <inheritdoc />
        public Guid Id { get; }

        /// <inheritdoc />
        public string Name { get; }

        /// <inheritdoc />
        public string? Description { get; }

        /// <summary>
        ///     Gets the input value descriptions.
        /// </summary>
        public List<ZoneCalculatorInputValueDescription> InputValueDescriptions { get; }
    }
}
