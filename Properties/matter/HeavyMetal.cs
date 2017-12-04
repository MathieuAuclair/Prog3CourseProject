namespace FinalProject.Properties
{
    public class HeavyMetal : Matter
    {
        public HeavyMetal() : this(null, null)
        {
            matterInQuestion = (int)MatterType.HEAVYMETAL;  
            // override constructor
        }

        public HeavyMetal(Matter nextMatterCrate, Matter previousMatterCrate) :
            base(nextMatterCrate, previousMatterCrate)
        {
            
            LoadingTime = 1;
        }
    }
}