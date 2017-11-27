﻿namespace FinalProject.Properties
{
    public abstract class Matter
    {
        public enum MatterType
        {
            PLUTONIUM,
            URANIUM,
            HEAVYMETAL,
            CONTAMINATED_SOIL,
            FOSSIL_FUEL
        }
        
        public int LoadingTime;

        public Matter NextMatterCrate;
        public Matter PreviousMatterCrate;

        public Matter(Matter nextMatterCrate, Matter previousMatterCrate)
        {
            NextMatterCrate = nextMatterCrate;
            PreviousMatterCrate = previousMatterCrate;
        }
    }
}