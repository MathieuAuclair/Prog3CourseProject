namespace FinalProject.Properties
{
    public class EvenSortingCenter : SortingCenter
    {
        public EvenSortingCenter(int waitingLineSize) : this(waitingLineSize, null, null)
        {
            // Override constructor
        }

        public EvenSortingCenter(int WaitingLineSize, SortingCenter nextCenter, SortingCenter previousCenter) :
            base(WaitingLineSize, nextCenter, nextCenter)
        {
            plutoniumCapacity = 1003;
            uraniumCapacity = 857;
            heavyMetalCapacity = 3456;
            contaminatedSoilCapacity = 457;
            fossilFuelCapacity = 639;
        }
    }
}