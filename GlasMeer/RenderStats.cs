using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.Bible.GlasOcean
{
    class RenderStats
    {
        public TimeSpan Time { get; private set; }
        public long IndividualCount { get; private set; }
        public long DecisionCount { get; private set; }
        public long AlternativeIndividualCount { get; private set; }
        public long AlternativeDecisionCount { get; private set; }

        public RenderStats(TimeSpan time,
            long individualCount, long decisionCount, 
            long alternativeIndividualCount, long alternativeDecisionCount)
        {
            Time = time;
            IndividualCount = individualCount;
            DecisionCount = decisionCount;
            AlternativeIndividualCount = alternativeIndividualCount;
            AlternativeDecisionCount = alternativeDecisionCount;
        }
    }
}
