using System;
using System.ComponentModel;
using System.Threading;
using static FinalProject.Properties.Ship.ShipType;

namespace FinalProject.Properties
{
    public abstract class SortingCenter
    {
        public int plutoniumCapacity;
        public int uraniumCapacity;
        public int heavyMetalCapacity;
        public int contaminatedSoilCapacity;
        public int fossilFuelCapacity;

        public SortingCenter PreviouSortingCenter;
        public SortingCenter NextSortingCenter;

        protected Ship shipWaitingLine;
        public Ship shipDepartureLine;

        protected int NumberOfShips;
       

        public SortingCenter(
            int NumberOfShips,
            SortingCenter previousCenter)
        {
            PreviouSortingCenter = previousCenter;
            shipWaitingLine = new LightShip(null, null);
            this.NumberOfShips = NumberOfShips;

            for (int i = 0; i < NumberOfShips; i++)
            {
                switch (RandomGenerator.getRandomInt(0, 2))
                {
                    case (int) CARGO_SHIP:
                        Menu.Menu.speach("        ~ ~ ~ ~ ~ Vaisseau Cargo Crée ~ ~ ~ ~ ~         ");
                        Thread.Sleep(250);
                        AddNewlyGeneratedShipToPile(new CargoShip(null, null));
                    
                        break; 
                    case (int) LIGHT_SHIP:
                        Menu.Menu.speach("        ~ ~ ~ ~ ~ Vaisseau Léger Crée ~ ~ ~ ~ ~         ");
                        Thread.Sleep(250);
                        AddNewlyGeneratedShipToPile(new LightShip(null, null));
                        break;
                }
            }
        }

        public void sendShipToDeparture(){
            shipWaitingLine = getShipAtIndex(getQuantityOfShipWaiting());
            Ship ship = shipWaitingLine;
            shipWaitingLine = ship.NextShip;
            shipWaitingLine.PreviousShip = null;
            ship.PreviousShip = null;

        }

        public void AddNewlyGeneratedShipToPile(Ship ship)
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
                shipWaitingLine = shipWaitingLine.NextShip;
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
                shipWaitingLine = shipWaitingLine.PreviousShip;
            }
        }

        public void releasePlaceForMatterByType(int matterType)
        {
            switch (matterType)
            {
                case (int)Matter.MatterType.CONTAMINATED_SOIL:
                    
                    break;
                case (int)Matter.MatterType.FOSSIL_FUEL:
                   
                    break;
                case (int)Matter.MatterType.HEAVYMETAL:
                   
                    break;
                case (int)Matter.MatterType.PLUTONIUM:
                   
                    break;
                case (int)Matter.MatterType.URANIUM:
                   
                    break;
            }
        }

        public void changeMatterStorageInCenter(int matterType, int storage){
            switch(matterType){
                case (int)Matter.MatterType.CONTAMINATED_SOIL:
                    if (contaminatedSoilCapacity > 0)
                    {
                        contaminatedSoilCapacity += storage;
                    } else {
                        throw new StationOverflowException();
                    }
                    break;
                case (int)Matter.MatterType.FOSSIL_FUEL:
                    if (fossilFuelCapacity > 0)
                    {
                        fossilFuelCapacity += storage;
                    } else {
                        throw new StationOverflowException();
                    }
                    break;
                case (int)Matter.MatterType.HEAVYMETAL:
                    if (heavyMetalCapacity > 0)
                    {
                        heavyMetalCapacity += storage;
                    } else {
                        throw new StationOverflowException();
                    }
                    break;
                case (int)Matter.MatterType.PLUTONIUM:
                    if (plutoniumCapacity > 0)
                    {
                        plutoniumCapacity += storage;
                    } else {
                        throw new StationOverflowException();
                    }
                    break;
                case (int)Matter.MatterType.URANIUM:
                    if (uraniumCapacity > 0)
                    {
                        uraniumCapacity += storage;
                    } else {
                        throw new StationOverflowException();
                    }
                    break;
            }
        }
    }
}