namespace FinalProject.Properties
{
    public class RecyclingStation
    {
        private SortingCenter sortingCenter;

        public RecyclingStation(int stationSize)
        {

            for (int i = 0; i < stationSize; i++)
            {
                // assign sorting center
            }
        }

        public SortingCenter GetSortingCenterAtIndex(int index)
        {
            return new OddSortingCenter(0);
        }
    }
}