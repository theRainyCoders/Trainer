namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators
{
    using System;

    /// <summary>
    ///     Class that represents a zones calculator input value.
    /// </summary>
    internal struct ZonesCalculatorInput
    {
        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        ///     Gets or sets the value.
        /// </summary>
        public string Value { get; set; }
    }
}
