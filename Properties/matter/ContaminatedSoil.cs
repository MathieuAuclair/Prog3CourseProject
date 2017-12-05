namespace FinalProject.Properties
{
    public class ContaminatedSoil : Matter
    {
        public ContaminatedSoil() : this(null, null)
        {
            matterInQuestion = (int)MatterType.CONTAMINATED_SOIL;
            // override constructor
        }

        public ContaminatedSoil(Matter nextMatterCrate, Matter previousMatterCrate) :
            base(nextMatterCrate, previousMatterCrate)
        {
            LoadingTime = 1;
        }
    }
}