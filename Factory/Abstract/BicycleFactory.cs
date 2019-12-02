using Products.ScifiVehicle;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Factory.Abstract
{
    public class BicycleFactory : IVehicleFactory
    {
        public Vehicle CreateGasolinePowered()
        {
            return new VehicleBuilder().AddWheels(2).WithGasolineEngine.WithColor(Color.FromName("Red")).Build();
        }

        /// <summary>
        /// Colin Furze's bicycle.
        /// <seealso cref="https://www.youtube.com/watch?v=bKHz7wOjb9w"/>
        /// </summary>
        /// <returns></returns>
        public Vehicle CreateJetPowered()
        {
            return new VehicleBuilder().AddWheels(2).WithJetEngine.WithPeddles.WithColor(Color.FromName("Gray")).Build();
        }

        public Vehicle CreatePeddlePowered()
        {
            return new VehicleBuilder().AddWheels(2).WithPeddles.WithColor(Color.FromName("Yellow")).Build();
        }
    }








}
