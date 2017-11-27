using System;

namespace FinalProject.Properties
{
    public static class RandomGenerator
    {
        static private Random random;

        static RandomGenerator()
        {
            random = new Random();
        }

        public static int getRandomInt()
        {
            return random.Next();
        }

        public static int getRandomInt(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }
    }
}