using System;
using System.Threading;

namespace FinalProject.Properties
{
	public class RecyclingStation
	{
		public enum SortingCenterType
		{
			ODD_CENTER,
			EVEN_CENTER
		}

		private SortingCenter sortingCenters;

		public RecyclingStation(int stationSize)
		{
            Menu.Menu.speach("Creation d'un centre de tri pair ");
            Thread.Sleep(200);
            sortingCenters = new EvenSortingCenter(stationSize, null);
            for (int i = 1; i < Menu.Menu.nbofsites; i++)
			{
				switch (RandomGenerator.getRandomInt(0, 2))
				{
					case (int)SortingCenterType.EVEN_CENTER:
						Menu.Menu.speach("Creation d'un centre de tri pair");
                        Thread.Sleep(200);
                        AddNewlyGeneratedSortingCenterToPile(new EvenSortingCenter(stationSize, null));
						break;
					case (int)SortingCenterType.ODD_CENTER:
						Menu.Menu.speach("Creation d'un centre de tri impair");
                        Thread.Sleep(200);
                        AddNewlyGeneratedSortingCenterToPile(new OddSortingCenter(stationSize, null));
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

		public void launchRecyclingProcess()
		{
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
						try
						{
							sortingCenters.changeMatterStorageInCenter(matterIndex.matterInQuestion, -1);
						}
						catch (Exception e)
						{
							Ship emptyShip = sortingCenters.shipDepartureLine;
							sortingCenters.shipDepartureLine = emptyShip.PreviousShip;
							emptyShip.PreviousShip = null;
							while (emptyShip.getQuantityOfMatterCrate() > emptyShip.Capacity)
							{
								emptyShip.addMatterCrateToShip(UtilMatter.getMatterByType(matterIndex.matterInQuestion));
                                sortingCenters.changeMatterStorageInCenter(matterIndex.matterInQuestion, 1);
							}
                            sortingCenters.AddNewlyGeneratedShipToPile(emptyShip);
							sortingCenters.changeMatterStorageInCenter(matterIndex.matterInQuestion, -1);
						}
					} while (indexShip.getMatterAtIndex(indexOfMatter).NextMatterCrate != null);

                    sortingCenters.NextSortingCenter.shipDepartureLine.NextShip = indexShip;
                    sortingCenters = sortingCenters.NextSortingCenter;

				} while (sortingCenters.getShipAtIndex(indexOfShip).NextShip != null);
				sortingCenters = sortingCenters.NextSortingCenter;
			} while (sortingCenters.NextSortingCenter != null);
		}

		public void processData()
		{
            sortingCenters.getShipAtIndex(1);

            int count = 0;
            while (sortingCenters.NextSortingCenter != null)
            {
                count++;
                Console.WriteLine("Station"+ count + " have " + sortingCenters.shipDepartureLine + " empty ship");
                Console.WriteLine("Plutonium " + sortingCenters.plutoniumCapacity);
                Console.WriteLine("HeavyMetal " + sortingCenters.heavyMetalCapacity);
                Console.WriteLine("Uranium " + sortingCenters.uraniumCapacity);
                Console.WriteLine("fossilFuel " + sortingCenters.fossilFuelCapacity);
                Console.WriteLine("contaminedSoil " + sortingCenters.contaminatedSoilCapacity);
                Console.WriteLine("");
            }
		}
	}
}