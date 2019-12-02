namespace Products.ScifiCars.Propulsion
{
    public abstract class PropulsionSystem
    {
        public bool CanFly { get; protected set; }
        public double fuelEfficiencyPercent { get; protected set; }


        public override string ToString()
        {
            return Description;
        }

        public abstract string Description
        {
            get;
        }
    }
}
