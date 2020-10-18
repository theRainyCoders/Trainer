namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators
{
    using System;
    using System.Collections.Generic;

    internal interface IZonesCalculatorDescription
    {
        Guid Id { get; }

        string Name { get; }

        IReadOnlyCollection<ZoneCalculatorInputValueDescription> InputValueDescriptions
        {
            get;
        }
        
    }
}