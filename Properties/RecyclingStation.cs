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
            Menu.Menu.speach("----------Creation d'un centre de tri pair ");
            for (int i = 0; i < stationSize; i++)
            {
                switch (RandomGenerator.getRandomInt(0,2))
                {
                    case (int) SortingCenterType.EVEN_CENTER:
                        Menu.Menu.speach("----------Creation d'un centre de tri pair");
                        AddNewlyGeneratedSortingCenterToPile(new EvenSortingCenter(Menu.Menu.nbofships, null));
                        break;
                    case (int) SortingCenterType.ODD_CENTER:
                        Menu.Menu.speach("----------Creation d'un centre de tri impair");
                        AddNewlyGeneratedSortingCenterToPile(new OddSortingCenter(Menu.Menu.nbofships , null));
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

        public void launchRecyclingProcess(){
            do
            {
                int indexOfShip = 0;
                do
                {
                    indexOfShip++;
                    Ship indexShip = sortingCenters.getShipAtIndex(indexOfShip);

                    int indexOfMatter = 0;
                    do
                    {
                        indexOfMatter++;
                        Matter matterIndex = indexShip.getMatterAtIndex(indexOfMatter);
                        //add tryCatch if center is filled
                        sortingCenters.storeMatterInCenter(matterIndex.matterInQuestion);
                    } while (indexShip.getMatterAtIndex(indexOfMatter).NextMatterCrate != null);
                    //need to set ship in waiting line
                } while (sortingCenters.getShipAtIndex(indexOfShip).NextShip != null);
                sortingCenters = sortingCenters.NextSortingCenter;
            } while (sortingCenters.NextSortingCenter != null);
        }

        public void processData(){
            //need to implement
        }
    }
}