namespace FinalProject.Properties
{
    public class LightShip : Ship
    {
        public LightShip() : this(null, null)
        {
            //Override constructor
        }

        public LightShip(Ship nextShip, Ship previousShip) : base(nextShip, previousShip)
        {
            Capacity = 108;
            FillShipWithMatter();
        }
    }
}