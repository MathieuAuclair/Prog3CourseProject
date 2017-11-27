namespace FinalProject.Properties
{
    public class CargoShip : Ship
    {
        public CargoShip() : this(null, null)
        {
            //Override constructor
        }

        public CargoShip(Ship nextShip, Ship previouShip) : base(nextShip, previouShip)
        {
            Capacity = 367;
        }
    }
}