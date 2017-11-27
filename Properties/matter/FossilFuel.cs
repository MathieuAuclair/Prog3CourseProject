namespace FinalProject.Properties
{
    public class FossilFuel : Matter
    {
        public FossilFuel() : this(null, null)
        {
            // override constructor
        }

        public FossilFuel(Matter nextMatterCrate, Matter previousMatterCrate) :
            base(nextMatterCrate, previousMatterCrate)
        {
            LoadingTime = 1;
        }
    }
}