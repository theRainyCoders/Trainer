namespace TheRainyCoders.Trainer.ZonesCalculators.Calculators.PowerAndPace
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    /// <summary>
    ///     Power and Pace zone calculator that calculates heart rate zones by the maximum heart rate.
    /// </summary>
    internal sealed class RunMaximumHeartRateZonesCalculator : IZonesCalculator
    {
        /// <summary>
        ///     Get the description of the calculator.
        /// </summary>
        public static readonly ZonesCalculatorDescription Description;

        internal static readonly Guid CalculatorId = Guid.Parse("{B08E13BD-EA30-446D-A105-3206A0C73DB9}");

        internal static readonly Guid MaxHeartRateInputValueId = Guid.Parse("{B0C6D2A6-65FB-4954-B845-208180BECA08}");

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
            var maxHeartRateInputValue = inputValues.First(x => x.Id == MaxHeartRateInputValueId);
            var maxHeartRate = int.Parse(maxHeartRateInputValue.Value);

            var resultBuilder = new ZoneCalculatorResultBuilder();
            resultBuilder.SetUnit("S/m").AddZone(
                    "DLreg",
                    0,
                    CalculationHelper.CalculateAndRoundUp(maxHeartRate, 60),
                    "Regenerativer Dauerlauf <= 60% HFmax")
                .AddZone(
                    "DLext",
                    CalculationHelper.CalculateAndRoundDown(maxHeartRate, 61),
                    CalculationHelper.CalculateAndRoundUp(maxHeartRate, 75),
                    "Extensiver Dauerlauf 61-75% HFmax")
                .AddZone(
                    "DLint",
                    CalculationHelper.CalculateAndRoundDown(maxHeartRate, 76),
                    CalculationHelper.CalculateAndRoundUp(maxHeartRate, 85),
                    "Intensiver Dauerlauf 76-85% HFmax")
                .AddZone(
                    "DLTempo",
                    CalculationHelper.CalculateAndRoundDown(maxHeartRate, 86),
                    CalculationHelper.CalculateAndRoundUp(maxHeartRate, 95),
                    "Tempdauerlauf 86-95% HFmax")
                .AddZone(
                    "TText",
                    CalculationHelper.CalculateAndRoundDown(maxHeartRate, 95),
                    CalculationHelper.CalculateAndRoundUp(maxHeartRate, 100),
                    "Tempdauerlauf >95% HFmax")
                .AddZone(
                    "TTint",
                    CalculationHelper.CalculateAndRoundDown(maxHeartRate, 95),
                    CalculationHelper.CalculateAndRoundUp(maxHeartRate, 100),
                    "Tempdauerlauf >95% HFmax");

            return resultBuilder.Build();
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
                .AddDescription(CalculatorId, "Power&Pace - Run - Maximum Heart Rate")
                .AddInputValueDescription(MaxHeartRateInputValueId, "Maximum Heart Rate");

            return descriptionBuilder.Build();
        }
    }
}
