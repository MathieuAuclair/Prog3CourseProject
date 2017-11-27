namespace FinalProject.Properties
{
    public class ContaminatedSoil : Matter
    {
        public ContaminatedSoil() : this(null, null)
        {
            // override constructor
        }

        public ContaminatedSoil(Matter nextMatterCrate, Matter previousMatterCrate) :
            base(nextMatterCrate, previousMatterCrate)
        {
            LoadingTime = 1;
        }
    }
}