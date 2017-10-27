using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.Bible.GlasOcean
{
    static class LifeMath
    {
        public static float NextFloat(this Random rand, float min, float max)
            => (float)(min + rand.NextDouble() * (max - min));

        public static bool ProbableEvent(this Random rand, double probability)
            => rand.NextDouble() < probability;
    }
}
