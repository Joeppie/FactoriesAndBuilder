using Products.ScifiVehicle;

namespace Factory.Abstract
{
    public interface IVehicleFactory
    {
        Vehicle CreateJetPowered();
        Vehicle CreatePeddlePowered();
        Vehicle CreateGasolinePowered();
    }








}
