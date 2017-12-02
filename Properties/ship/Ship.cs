using System.Runtime.Serialization.Formatters;
using FinalProject.Properties.Interface;

namespace FinalProject.Properties
{
    public abstract class Ship : IShip
    {
        public enum ShipType
        {
            LIGHT_SHIP,
            CARGO_SHIP
        }

        protected float Capacity;
        protected Matter LoadContent;

        public Ship NextShip;
        public Ship PreviousShip;

        public Ship(Ship nextShip, Ship previousShip)
        {
            NextShip = nextShip;
            PreviousShip = previousShip;

            while (getQuantityOfMatterCrate() <= Capacity)
            {
                switch (RandomGenerator.getRandomInt(0,5))
                {
                    case (int) Matter.MatterType.PLUTONIUM:
                        // assign
                        break;
                    case (int) Matter.MatterType.URANIUM:
                        // assign
                        break;
                    case (int) Matter.MatterType.HEAVYMETAL:
                        // assign
                        break;
                    case (int) Matter.MatterType.CONTAMINATED_SOIL:
                        // assign
                        break;
                    case (int) Matter.MatterType.FOSSIL_FUEL:
                        // assign
                        break;
                }
            }
        }

        public int getQuantityOfMatterCrate()
        {
            //need to make a loop that count the length
            return 0;
        }

        public Ship getMatterAtIndex(int index)
        {
            //need to make a loop that count the length
            return new LightShip();
        }
    }
}