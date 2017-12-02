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
            SortingCenter previousCenter)
        {
            this.NumberOfShips = NumberOfShips;

            //Create a amounts of ships

            for (int i = 0; i < NumberOfShips; i++)
            {
                switch (RandomGenerator.getRandomInt(0, 2))
                {
                    case (int) CARGO_SHIP:
                        if (shipWaitingLine.PreviousShip != null)
                        {
                            Ship currentShip = shipWaitingLine;
                            shipWaitingLine = new CargoShip(null, currentShip);
                            currentShip.NextShip = shipWaitingLine;
                        }
                        break;
                    case (int) LIGHT_SHIP:
                        if (shipWaitingLine.PreviousShip != null)
                        {
                            Ship currentShip = shipWaitingLine;
                            shipWaitingLine = new LightShip(null, currentShip);
                            currentShip.NextShip = shipWaitingLine;
                        }
                        break;
                }
            }
        }

        public int getQuantityOfShipWaiting()
        {
            resetShipPile();
            int count = 0;
            while (shipWaitingLine.NextShip != null)
            {
                count++;
            }
            return count;
        }

        public Matter getShipAtIndex(int index)
        {
            resetShipPile();
            for (int i = 0; i < index; i++)
            {
                Ship currentShip = shipWaitingLine;
                shipWaitingLine = currentShip.NextShip;
            }
            return new Plutonium();
        }


        private void resetShipPile()
        {
             while (shipWaitingLine.PreviousShip != null)
            {
                Ship previousShip = shipWaitingLine.PreviousShip;
            }
        }
    }
}