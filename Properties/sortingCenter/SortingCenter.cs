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

        protected int waitingLineSize;

        public SortingCenter(
            int waitingLineSize, 
            SortingCenter nextCenter, 
            SortingCenter previousCenter)
        {
            this.waitingLineSize = waitingLineSize;

            for (int i = 0; i < waitingLineSize; i++)
            {
                switch (RandomGenerator.getRandomInt(0, 2))
                {
                    case (int) CARGO_SHIP:
                        // assign
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