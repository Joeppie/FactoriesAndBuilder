using Products.ScifiCars;
using Products.ScifiCars.Propulsion;
using Products.ScifiCars.Propulsion.Conventional;
using Products.ScifiCars.Propulsion.Exotic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Products.ScifiVehicle
{

    /// <summary>
    /// Allows you to Build vehicles that just .... work!
    /// </summary>
    public class VehicleBuilder
    {
        int? wheels = 0;
        Color? vehicleColor;
        List<PropulsionSystem> propulsionSystems = new List<PropulsionSystem>();
        bool canFly = false;

        public Vehicle Build()
        {
            if (!wheels.HasValue || wheels < 0)
            {
                throw new ArgumentException("Number of wheels must be specified and wheels must not be negative number.");
            }

            if (!vehicleColor.HasValue)
            {
                throw new ArgumentException("The color of the vehicle must be specified.");
            }


            //Create properly parameterized Vehicle.
            return new Vehicle()
            {
                NumberOfWheels = wheels.Value,
                color = vehicleColor.Value,
                PropulsionSystems = propulsionSystems,
                canFly = canFly
            };
        }


        public VehicleBuilder WithJetEngine
        {
            get
            {
                propulsionSystems.Add(new JetEngine());
                return this;
            }
        }
        public VehicleBuilder WithGasolineEngine { get { propulsionSystems.Add(new GasolineEngine()); return this; } }
        public VehicleBuilder WithPeddles { get { propulsionSystems.Add(new Peddles()); return this; } }
        public VehicleBuilder CanFly { get { canFly = true; return this; } }

        public VehicleBuilder AddWheels(int number)
        {
            wheels = wheels.HasValue ? wheels + number : number;
            return this;
        }

        public VehicleBuilder WithColor(Color color)
        {
            if(vehicleColor.HasValue)
            {
                throw new ArgumentException("Vehicles can only have one color."); //Todo: is this smart?
            }
            vehicleColor = color;
            return this;
        }




    }
}
