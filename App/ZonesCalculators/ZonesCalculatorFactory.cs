namespace TheRainyCoders.Trainer.ZonesCalculators
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    ///     Factory to create instances of the available <see cref="IZonesCalculator" />.
    /// </summary>
    public class ZonesCalculatorFactory : IZonesCalculatorFactory
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ZonesCalculatorFactory" /> class.
        /// </summary>
        public ZonesCalculatorFactory()
        {
            this.Calculators = GetAvailableZoneCalculatorsOfThisAssembly();
        }

        /// <summary>
        ///     Gets available calculators.
        /// </summary>
        protected Dictionary<Guid, IZonesCalculator> Calculators { get; }

        /// <inheritdoc />
        public virtual IEnumerable<ZonesCalculatorDescription> GetAvailableCalculators()
        {
            return this.Calculators.Values.Select(x => x.Description);
        }

        /// <inheritdoc />
        public virtual IZonesCalculator Create(Guid id)
        {
            return this.Calculators[id];
        }

        /// <summary>
        ///     Get available zone calculators of this assembly via reflection.
        /// </summary>
        /// <returns>
        ///     The <see cref="Dictionary{Guid, IZonesCalculator}" />.
        /// </returns>
        private static Dictionary<Guid, IZonesCalculator> GetAvailableZoneCalculatorsOfThisAssembly()
        {
            var calculators = new Dictionary<Guid, IZonesCalculator>();

            var type = typeof(IZonesCalculator);
            var calculatorTypes = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes())
                .Where(p => p.IsClass && type.IsAssignableFrom(p));

            foreach (var calculatorType in calculatorTypes)
            {
                if (Activator.CreateInstance(calculatorType) is IZonesCalculator calculator)
                {
                    calculators[calculator.Description.Id] = calculator;
                }
            }

            return calculators;
        }
    }
}
