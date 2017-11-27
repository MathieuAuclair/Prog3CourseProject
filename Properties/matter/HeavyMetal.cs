namespace FinalProject.Properties
{
    public class HeavyMetal : Matter
    {
        public HeavyMetal() : this(null, null)
        {
            // override constructor
        }

        public HeavyMetal(Matter nextMatterCrate, Matter previousMatterCrate) :
            base(nextMatterCrate, previousMatterCrate)
        {
            LoadingTime = 1;
        }
    }
}