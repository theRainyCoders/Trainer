namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators
{
    using System;

    using TheRainyCoders.Commonplace.Data;

    /// <summary>
    ///     Class that represent the description of a zone calculator input value.
    /// </summary>
    internal struct ZoneCalculatorInputValueDescription : IReadonlyDescribe
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ZoneCalculatorInputValueDescription" /> struct.
        /// </summary>
        /// <param name="id">
        ///     The unique id of the input value.
        /// </param>
        /// <param name="name">
        ///     The name.
        /// </param>
        /// <param name="description">
        ///     The description.
        /// </param>
        public ZoneCalculatorInputValueDescription(Guid id, string name, string? description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
        }

        /// <inheritdoc />
        public Guid Id { get; set; }

        /// <inheritdoc />
        public string Name { get; set; }

        /// <inheritdoc />
        public string? Description { get; set; }
    }
}
