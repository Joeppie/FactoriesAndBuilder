using Products.ScifiCars.Propulsion;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Products.ScifiVehicle
{
    public class Vehicle
    {
        internal Vehicle() { }

        public Color color { get; internal set; }
        public List<PropulsionSystem> PropulsionSystems { get; internal set; }
        public int NumberOfWheels { get; internal set; }
        public bool canFly = false;

        public string Description
        {
            get
            {
                StringBuilder builder = new StringBuilder();

                builder.Append($"A {color.ToString()} vehicle {(canFly ? "which can fly" : "")}  with {NumberOfWheels} wheels powered by");

                if (PropulsionSystems.Count == 1)
                    builder.Append($"{PropulsionSystems.First().Description}");
                else if (PropulsionSystems.Count == 2)
                    builder.Append($"{String.Join(",", PropulsionSystems)}");
                else if (PropulsionSystems.Count > 2)
                    builder.Append($"{String.Join(",", PropulsionSystems.Take(PropulsionSystems.Count - 1))} and { PropulsionSystems.Last().Description}");

                return builder.ToString();
            }

        }
    }
}
