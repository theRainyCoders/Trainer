namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators
{
    using System;
    using System.Collections.Generic;

    internal class ZonesCalculatorDescription : IZonesCalculatorDescription
    {
        public ZonesCalculatorDescription()
        {
            this.InputValueDescriptions2 = new List<ZoneCalculatorInputValueDescription>();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public IReadOnlyCollection<ZoneCalculatorInputValueDescription> InputValueDescriptions => this.InputValueDescriptions2;

        public string Description { get; set; }

        public List<ZoneCalculatorInputValueDescription> InputValueDescriptions2;
    }
}