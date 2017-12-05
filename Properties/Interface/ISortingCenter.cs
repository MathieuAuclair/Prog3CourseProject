namespace FinalProject.Properties
{
    public interface ISortingCenter
    {
        int getQuantityOfShipWaiting();
        Matter getShipAtIndex(int index);
    }
}