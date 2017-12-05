namespace FinalProject.Properties
{
    public class FossilFuel : Matter
    {
        public FossilFuel() : this(null, null)
        {
            matterInQuestion = (int)MatterType.FOSSIL_FUEL;
            // override constructor
        }

        public FossilFuel(Matter nextMatterCrate, Matter previousMatterCrate) :
            base(nextMatterCrate, previousMatterCrate)
        {
            LoadingTime = 1;
        }
    }
}