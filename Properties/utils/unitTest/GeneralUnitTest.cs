using System.Runtime.Serialization.Formatters;
using NUnit.Framework;

namespace FinalProject.Properties.unitTest
{
    [TestFixture]
    public class GeneralUnitTest
    {
        [Test]
        public void ShipGenerator()
        {
            Ship lightShip = new LightShip();
            Ship cargoShip = new CargoShip();
            
            // when we create a new ship it should be filled
            Assert.AreNotEqual(lightShip.getQuantityOfMatterCrate(), 0);
            Assert.AreEqual(lightShip.getQuantityOfMatterCrate(), 109);
        }

        [Test]
        public void SortingCenterShipLine()
        {
            int iterationCount = 500;

            for (int i = 0; i < iterationCount; i++)
            {
                int countOfShip = RandomGenerator.getRandomInt(3, 4);
                SortingCenter sortingCenter = new OddSortingCenter(countOfShip, null);
                Assert.AreEqual(sortingCenter.getQuantityOfShipWaiting(), countOfShip);
            }
        }


        [Test]
        public void SortingCenterShipGenerator()
        {
            int countOfIteration = 500;

            for (int i = 0; i < countOfIteration; i++)
            {
                int countOfGeneratedShip  = RandomGenerator.getRandomInt(1, 500);
                EvenSortingCenter sortingCenter = new EvenSortingCenter(countOfGeneratedShip, null);
                Ship ship = sortingCenter.getShipAtIndex(countOfGeneratedShip);

                //the last ship should not be null
                Assert.AreNotEqual(ship, null);

                //the quantity of ship should be equal as we previously entered
                int countOfShip = sortingCenter.getQuantityOfShipWaiting();
                Assert.AreEqual(countOfShip, countOfGeneratedShip);
            }
        }
    }
}