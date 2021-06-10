using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Biz
{
    internal static class RandomNumBiz
    {
        private static Random r = new Random();
        private static object l = new object();
        private static Random globalRandom = new Random();
        [ThreadStatic]
        private static Random localRandom;
        public static int GenerateNewRandom(int min, int max)
        {
            return new Random().Next(min, max);
        }
        public static int GenerateLockedRandom(int min, int max)
        {
            int result;
            lock (RandomNumBiz.l)
            {
                result = RandomNumBiz.r.Next(min, max);
            }
            return result;
        }
        public static int GenerateRandom(int min, int max)
        {
            Random random = RandomNumBiz.localRandom;
            if (random == null)
            {
                int seed;
                lock (RandomNumBiz.globalRandom)
                {
                    seed = RandomNumBiz.globalRandom.Next();
                }
                random = (RandomNumBiz.localRandom = new Random(seed));
            }
            return random.Next(min, max);
        }

        public static int GenerateRandom(int min, List<int> numList)
        {
            Random random = RandomNumBiz.localRandom;
            if (random == null)
            {
                int seed;
                lock (RandomNumBiz.globalRandom)
                {
                    seed = RandomNumBiz.globalRandom.Next();
                }
                random = (RandomNumBiz.localRandom = new Random(seed));
            }
            return numList[random.Next(min, numList.Count)];
        }
    }
}
