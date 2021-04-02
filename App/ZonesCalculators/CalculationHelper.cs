namespace TheRainyCoders.Trainer.ZonesCalculators
{
    using System;

    public static class CalculationHelper
    {
        public static double CalculateAndRoundDown(double input, int percentage)
        {
            var result = input / 100D * percentage;
            return Math.Round(result, MidpointRounding.ToZero);
        }

        public static double CalculateAndRoundUp(double input, int percentage)
        {
            var result = input / 100D * percentage;
            return Math.Round(result, MidpointRounding.AwayFromZero);
        }
    }
}
