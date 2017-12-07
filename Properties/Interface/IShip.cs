namespace FinalProject.Properties.Interface
{
    public interface IShip
    {
        int getQuantityOfMatterCrate();
        void addMatterCrateToShip(Matter matter);
        Matter getMatterAtIndex(int index);
    }
}