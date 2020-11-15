namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators
{
    using System.ComponentModel.DataAnnotations;

    internal interface IZonesCalculator : IValidatableObject
    {
        IZonesCalculatorDescription Description
        {
            get;
        }


        ZonesCalculatorResult Calculate(ZonesCalculatorInput input);
    }
}