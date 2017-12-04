using System;

namespace FinalProject.Properties
{
    public class RecyclingStation
    {
        public enum SortingCenterType {
            ODD_CENTER,
            EVEN_CENTER
        }

        private SortingCenter sortingCenters;

        public RecyclingStation(int stationSize)
        {
            sortingCenters = new EvenSortingCenter(stationSize, null);
            for (int i = 0; i < stationSize; i++)
            {
                switch (RandomGenerator.getRandomInt(0,2))
                {
                    case (int) SortingCenterType.EVEN_CENTER:
                        AddNewlyGeneratedSortingCenterToPile(new EvenSortingCenter(30, null));
                        break;
                    case (int) SortingCenterType.ODD_CENTER:
                        AddNewlyGeneratedSortingCenterToPile(new OddSortingCenter(30, null));
                        break;
                }
            }
        }

        private void AddNewlyGeneratedSortingCenterToPile(SortingCenter center)
        {
            SortingCenter currentStation = sortingCenters;
            currentStation.NextSortingCenter = center;
            sortingCenters = center;
            sortingCenters.PreviouSortingCenter = currentStation;
        }

        public int getQuantityOfStation()
        {
            resetStationPile();

            int count = 0;
            while (sortingCenters.NextSortingCenter != null)
            {
                count++;
                sortingCenters = sortingCenters.NextSortingCenter;
            }
            return count;
        }

        public SortingCenter GetSortingCenterAtIndex(int index)
        {
            resetStationPile();
            for (int i = 0; i < index; i++)
            {
                SortingCenter currentCenter = sortingCenters;
                sortingCenters = currentCenter.NextSortingCenter;
            }
            return sortingCenters;
        }


        private void resetStationPile()
        {
            while (sortingCenters.PreviouSortingCenter != null)
            {
                sortingCenters = sortingCenters.PreviouSortingCenter;
            }
        }
    }
}