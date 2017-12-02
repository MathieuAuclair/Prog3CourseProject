﻿using System;
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
            if (shipWaitingLine.PreviousShip != null)
            {
                Ship currentShip = shipWaitingLine;
                ship.PreviousShip = currentShip;
                shipWaitingLine = ship;
                currentShip.NextShip = shipWaitingLine;
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

        public Ship getShipAtIndex(int index)
        {
            resetShipPile();
            for (int i = 0; i < index; i++)
            {
                Ship currentShip = shipWaitingLine;
                shipWaitingLine = currentShip.NextShip;
            }
            return new CargoShip();
        }


        private void resetShipPile()
        {
            Ship previousShip = shipWaitingLine;
            while (shipWaitingLine.PreviousShip != null)
            {
                previousShip = shipWaitingLine.PreviousShip;
            }
        }
    }
}