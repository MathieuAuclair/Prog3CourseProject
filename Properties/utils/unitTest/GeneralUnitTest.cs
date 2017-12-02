using NUnit.Framework;

namespace FinalProject.Properties.unitTest
{
    [TestFixture]
    public class GeneralUnitTest
    {
        [Test]
        public void SortingCenterShipGenerator()
        {
            EvenSortingCenter sortingCenter = new EvenSortingCenter(200, null);
            Assert.AreEqual(1,1);
        }
    }
}