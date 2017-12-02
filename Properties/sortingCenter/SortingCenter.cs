using System.Threading;
using static FinalProject.Properties.Ship.ShipType;

namespace FinalProject.Properties
{
    public abstract class SortingCenter
    {
        protected int plutoniumCapacity;
        protected int uraniumCapacity;
        protected int heavyMetalCapacity;
        protected int contaminatedSoilCapacity;
        protected int fossilFuelCapacity;

        protected Ship shipWaitingLine;

        protected int NumberOfShips;

        public SortingCenter(
            int NumberOfShips, 
            SortingCenter nextCenter)
        {
            this.NumberOfShips = NumberOfShips;

            //Create a amounts of ships

            for (int i = 0; i < NumberOfShips; i++)
            {
                switch (RandomGenerator.getRandomInt(0, 2))
                {
                    case (int) CARGO_SHIP:
                        CargoShip UnCargo = new CargoShip();
                        break;
                    case (int) LIGHT_SHIP:
                        // assign
                        break;
                }
            }
        }

        public int getQuantityOfShipWaiting()
        {
            //need to make a loop that count the length
            return 0;
        }

        public Matter getShipAtIndex(int index)
        {
            //need to make a loop that count the length
            return new Plutonium();
        }
    }
}