using System;

namespace FinalProject.Properties
{
    public class Uranium : Matter
    {
        public Uranium() : this(null, null)
        {
            matterInQuestion = (int)MatterType.URANIUM;
            // override constructor
        }

        public Uranium(Matter nextMatterCrate, Matter previousMatterCrate) :
            base(nextMatterCrate, previousMatterCrate)
        {
            LoadingTime = 1;
        }
    }
}