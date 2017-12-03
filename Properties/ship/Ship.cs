using System.Runtime.Serialization.Formatters;

namespace FinalProject.Properties
{
    public abstract class Ship
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
            resetStockPile();
            int count = 0;
            while (LoadContent.NextMatterCrate != null)
            {
                count++;
            }
            
            return count;
        }

        public Ship getMatterAtIndex(int index)
        {
            //need to make a loop that count the length
            return new LightShip();
        }
        
        private void resetStockPile()
        {
            while (LoadContent.PreviousMatterCrate != null)
            {
                LoadContent = LoadContent.PreviousMatterCrate;
            }
        } 
    }
}