using Products.ScifiVehicle;
using System.Drawing;

namespace Factory.Abstract
{
    public class AirplaneFactory : IVehicleFactory
    {
        public Vehicle CreateGasolinePowered()
        {
            return new VehicleBuilder().AddWheels(3).WithGasolineEngine.WithColor(Color.FromName("White")).Build();
        }

        public Vehicle CreateJetPowered()
        {
            return new VehicleBuilder().AddWheels(3).WithJetEngine.WithColor(Color.FromName("White")).Build();
        }

        public Vehicle CreatePeddlePowered()
        {
            return new VehicleBuilder().AddWheels(3).WithPeddles.WithColor(Color.FromName("White")).Build();
        }
    }








}
