namespace TheRainyCoders.Trainer.ZonesCalculators.Calculators.PowerAndPace
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    ///     Power and Pace zone calculator that calculates heart rate zones by the maximum heart rate.
    /// </summary>
    internal sealed class RunMaximumHeartRateZonesCalculator : IZonesCalculator
    {
        /// <summary>
        ///     Get the description of the calculator.
        /// </summary>
        public static readonly ZonesCalculatorDescription Description;

        /// <summary>
        ///     Initializes static members of the <see cref="RunMaximumHeartRateZonesCalculator" /> class.
        /// </summary>
        static RunMaximumHeartRateZonesCalculator()
        {
            Description = CreateCalculatorDescription();
        }

        /// <inheritdoc />
        ZonesCalculatorDescription IZonesCalculator.Description => Description;

        /// <inheritdoc />
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public ZonesCalculatorResult Calculate(IReadOnlyCollection<ZonesCalculatorInputValue> inputValues)
        {
            var zoneOne = new ZonesCalculatorZone
                              {
                                  Id = Guid.NewGuid(),
                                  Name = "DLext",
                                  Minimum = 0,
                                  Maximum = 1,
                                  Description = "Info desc.",
                              };

            var result = new ZonesCalculatorResult();
            result.Zones.Add(zoneOne);

            return result;
        }

        /// <summary>
        ///     Create calculator description.
        /// </summary>
        /// <returns>
        ///     The <see cref="ZonesCalculatorDescription" />.
        /// </returns>
        private static ZonesCalculatorDescription CreateCalculatorDescription()
        {
            var descriptionBuilder = new ZonesCalculatorDescriptionBuilder();

            descriptionBuilder
                .AddDescription(
                    Guid.Parse("{B08E13BD-EA30-446D-A105-3206A0C73DB9}"),
                    "Power&Pace - Run - Maximum Heart Rate").AddInputValueDescription(
                    Guid.Parse("{B0C6D2A6-65FB-4954-B845-208180BECA08}"),
                    "Maximum Heart Rate");

            return descriptionBuilder.Build();
        }
    }
}
