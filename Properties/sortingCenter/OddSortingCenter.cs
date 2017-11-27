namespace FinalProject.Properties
{
    public class OddSortingCenter : SortingCenter
    {
        public OddSortingCenter(int waitingLineSize) : this(waitingLineSize, null, null)
        {
            // Override constructor
        }

        public OddSortingCenter(int waitingLineSize, SortingCenter nextCenter, SortingCenter previousCenter) :
            base(waitingLineSize, nextCenter, previousCenter)
        {
            plutoniumCapacity = 3067;
            uraniumCapacity = 2456;
            heavyMetalCapacity = 561;
            contaminatedSoilCapacity = 2658;
            fossilFuelCapacity = 8234;
        }
    }
}