using Factory;
using Factory.Abstract;
using Factory.Simple;

namespace FactoriesAndBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region simple factory
            //Simple factory; geen interfaces, geen abstract classes, allemaal simpele implementaties.
            var simplePizzaFactory = new SimplePizzaFactory();
            var pizza = simplePizzaFactory.CreatePizza();
            #endregion



            #region method factory
            //method factory; geen interfaces, geen abstract classes, allemaal simpele implementaties.
            var margheritaPizzaFactory = new PizzaMargheritaFactory();
            var margherita = margheritaPizzaFactory.CreatePizza();
            #endregion


            #region abstract factory (builder pattern in background)
            //Abstract factory; iedere van de aangemaakte 'soorten' objecten zijn aan elkaar gerelateerd per factory.
            //Bijvoorbeeld een Auto, Vliegtuig en 

            //Create several bicycle objects; common in that they have two wheels.
            var bicycleFactory = new BicycleFactory();

            var motorcycle = bicycleFactory.CreateGasolinePowered();
            var colinFurzesBike = bicycleFactory.CreateJetPowered(); //Deze fiets is speciaal; hij heeft ook pedalen.
            var bike = bicycleFactory.CreatePeddlePowered();

            //Create several leased cars, common in that they have four wheels, are gray, and may be a bit boring.
            var carFactory = new LeaseCarFactory();
             
            var leaseCar = carFactory.CreateGasolinePowered();
            var leisureCar = carFactory.CreateJetPowered();

            //Create some planes
            var planeFactory = new AirplaneFactory();
            var propellerPlane = planeFactory.CreateGasolinePowered();
            var corporateJet = planeFactory.CreateJetPowered();

            #endregion



        }
    }
}
