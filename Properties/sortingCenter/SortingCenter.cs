using System;
using System.ComponentModel;
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
            shipWaitingLine = new LightShip(null, null);
            this.NumberOfShips = NumberOfShips;

            //Create a amounts of ships

            for (int i = 0; i < NumberOfShips; i++)
            {
                switch (RandomGenerator.getRandomInt(0, 2))
                {
                    case (int) CARGO_SHIP:
                        AddNewlyGeneratedShipToPile(new CargoShip(null, null));
                        break;
                    case (int) LIGHT_SHIP:
                        AddNewlyGeneratedShipToPile(new LightShip(null, null));
                        break;
                }
            }
        }

        private void AddNewlyGeneratedShipToPile(Ship ship)
        {
            Ship currentShip = shipWaitingLine;
            currentShip.NextShip = ship;
            shipWaitingLine = ship;
            shipWaitingLine.PreviousShip = currentShip;
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

        public Ship getShipAtIndex(int index)
        {
            resetShipPile();
            for (int i = 0; i < index; i++)
            {
                Ship currentShip = shipWaitingLine;
                shipWaitingLine = currentShip.NextShip;
            }
            return shipWaitingLine;
        }


        private void resetShipPile()
        {
            while (shipWaitingLine.PreviousShip != null)
            {
                Ship ship = shipWaitingLine;
                shipWaitingLine = ship.PreviousShip;
            }
        }
    }
}