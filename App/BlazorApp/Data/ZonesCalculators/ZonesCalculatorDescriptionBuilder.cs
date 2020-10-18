namespace TheRainyCoders.Trainer.BlazorApp.Data.ZonesCalculators
{
    using System;

    internal class ZonesCalculatorDescriptionBuilder : IZonesCalculatorDescriptionBuilder
    {
        public ZonesCalculatorDescriptionBuilder()
        {
            this.Description = new ZonesCalculatorDescription();
        }

        public ZonesCalculatorDescription Description { get; protected set; }

        public virtual IZonesCalculatorDescriptionBuilder AddDescription(Guid id, string name, string description = null)
        {
            this.Description.Id = id;
            this.Description.Name = name;
            this.Description.Description = description;

            return this;
        }


        public virtual IZonesCalculatorDescriptionBuilder AddInputValueDescription(Guid id, string name, string description = null)
        {
            var inputValueDescription = new ZoneCalculatorInputValueDescription
                                            {
                                                Id = id, Name = name, Description = description
                                            };

            this.Description.InputValueDescriptions2.Add(inputValueDescription);

            return this;
        }

        public virtual IZonesCalculatorDescription Build()
        {
            return this.Description;
        }
    }
}