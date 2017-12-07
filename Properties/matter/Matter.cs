using FinalProject.Properties.Interface;

namespace FinalProject.Properties
{
    public static class UtilMatter {
		public static Matter getMatterByType(int type)
		{
            switch (type){
                case (int)Matter.MatterType.CONTAMINATED_SOIL:
                    return new ContaminatedSoil();
                case (int)Matter.MatterType.FOSSIL_FUEL:
                    return new FossilFuel();
                case (int)Matter.MatterType.HEAVYMETAL:
                    return new HeavyMetal();
                case (int)Matter.MatterType.PLUTONIUM:
                    return new Plutonium();
                case (int)Matter.MatterType.URANIUM:
                    return new Uranium();
            }
            return new ContaminatedSoil();
        }
    }

    public abstract class Matter : IMatter
    {
        public enum MatterType
        {
            PLUTONIUM,
            URANIUM,
            HEAVYMETAL,
            CONTAMINATED_SOIL,
            FOSSIL_FUEL
        }
        public int matterInQuestion;
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