namespace FinalProject.Properties
{
    public class Plutonium : Matter
    {
        public Plutonium() : this(null, null)
        {
            // override constructor
        }

        public Plutonium(Matter nextMatterCrate, Matter previousMatterCrate) : 
            base(nextMatterCrate, previousMatterCrate)
        {
            LoadingTime = 1;
        }
    }
}