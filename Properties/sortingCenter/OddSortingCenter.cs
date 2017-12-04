namespace FinalProject.Properties
{
    public class OddSortingCenter : SortingCenter
    {
        public OddSortingCenter(int waitingLineSize) : this(waitingLineSize, null)
        {
            // Override constructor
        }

        public OddSortingCenter(int waitingLineSize, SortingCenter previousCenter) :
            base(waitingLineSize, previousCenter)
        {
            plutoniumCapacity = 3067;
            uraniumCapacity = 2456;
            heavyMetalCapacity = 561;
            contaminatedSoilCapacity = 2658;
            fossilFuelCapacity = 8234;
        }
    }
}