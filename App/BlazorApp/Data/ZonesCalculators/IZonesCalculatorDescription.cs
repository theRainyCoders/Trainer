namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators
{
    using System.Collections.Generic;

    using TheRainyCoders.Commonplace.Data;

    internal interface IZonesCalculatorDescription : IReadonlyDescribe
    {
        IReadOnlyCollection<ZoneCalculatorInputValueDescription> InputValueDescriptions { get; }
    }
}