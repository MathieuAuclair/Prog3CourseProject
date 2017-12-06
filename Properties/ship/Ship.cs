using System.Runtime.Serialization.Formatters;
using FinalProject.Properties.Interface;
using System.Runtime.Serialization.Formatters;
using System.ComponentModel;
﻿using System;


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
        }

        protected void FillShipWithMatter()
        {
            LoadContent = new Plutonium(null, null);
            
            while (getQuantityOfMatterCrate() <= Capacity)
            {
                switch (RandomGenerator.getRandomInt(0,5))
                {
                    case (int) Matter.MatterType.PLUTONIUM:
                        addMatterCrateToShip(new Plutonium(null, LoadContent));
                        break;
                    case (int) Matter.MatterType.URANIUM:
                        addMatterCrateToShip(new Uranium(null, LoadContent));
                        break;
                    case (int) Matter.MatterType.HEAVYMETAL:
                        addMatterCrateToShip(new HeavyMetal(null, LoadContent));
                        break;
                    case (int) Matter.MatterType.CONTAMINATED_SOIL:
                        addMatterCrateToShip(new ContaminatedSoil(null, LoadContent));
                        break;
                    case (int) Matter.MatterType.FOSSIL_FUEL:
                        addMatterCrateToShip(new FossilFuel(null, LoadContent));
                        break;
                }
            }
        }

        public void addMatterCrateToShip(Matter matter)
        {
            Matter oldMatter = LoadContent;
            oldMatter.NextMatterCrate = matter;
            LoadContent = matter;
            LoadContent.PreviousMatterCrate = oldMatter;
        }
        

        public int getQuantityOfMatterCrate()
        {
            resetStockPile();
            int count = 0;
            while (LoadContent.NextMatterCrate != null)
            {
                LoadContent = LoadContent.NextMatterCrate;
                count++;
            }
            
            return count;
        }

        public Matter getMatterAtIndex(int index)
        {
            resetStockPile();
            int count = 0;
            while(count < index){
                count++;
                LoadContent = LoadContent.NextMatterCrate;
            }
            return LoadContent;
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