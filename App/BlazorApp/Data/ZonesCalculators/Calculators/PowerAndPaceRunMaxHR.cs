namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators.Calculators
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    internal sealed class PowerAndPaceRunMaxHR : IZonesCalculator
    {

        private static readonly IZonesCalculatorDescription description;

        static PowerAndPaceRunMaxHR()
        {
            var descriptionBuilder = new ZonesCalculatorDescriptionBuilder();
            descriptionBuilder.AddInputValueDescription(
                Guid.Parse("{B0C6D2A6-65FB-4954-B845-208180BECA08}"),
                "Maximum Heart Rate");

            description = descriptionBuilder.Build();
        }


        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new System.NotImplementedException();
            // todo remove nuget submodule to commonplaceö
        }

        public IZonesCalculatorDescription Description => description;

        public ZonesCalculatorResult Calculate(ZonesCalculatorInput input)
        {
            throw new System.NotImplementedException();
        }
    }
}