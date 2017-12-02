using NUnit.Framework;

namespace FinalProject.Properties.unitTest
{
    [TestFixture]
    public class GeneralUnitTest
    {
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
                Assert.AreEqual(sortingCenter.getQuantityOfShipWaiting(), countOfGeneratedShip);
            }
        }
    }
}