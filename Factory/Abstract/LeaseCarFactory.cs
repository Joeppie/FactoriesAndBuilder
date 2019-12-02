using Products.ScifiVehicle;
using System.Drawing;

namespace Factory.Abstract
{
    public class LeaseCarFactory : IVehicleFactory
    {
        public Vehicle CreateGasolinePowered()
        {
            return new VehicleBuilder().AddWheels(4).WithGasolineEngine.WithColor(Color.FromName("Gray")).Build();
        }

        /// <summary>
        /// Jet engines are not profitable in lease due to frequent crashes, so we just use a gasoline engine instead.
        /// </summary>
        /// <returns></returns>
        public Vehicle CreateJetPowered()
        {
            return new VehicleBuilder().AddWheels(4).WithGasolineEngine.WithColor(Color.FromName("Gray")).Build();
        }

        public Vehicle CreatePeddlePowered()
        {
            return new VehicleBuilder().AddWheels(4).WithPeddles.WithColor(Color.FromName("Gray")).Build();
        }
    }
}
