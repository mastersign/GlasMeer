using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.Bible.GlasOcean
{
    public class LifeParameter
    {
        public int PopulationRandomSeed { get; set; }

        public int DecisionRandomSeed { get; set; }

        public float MaxTime { get; set; }

        public float MinLifeSpan { get; set; }

        public float MaxLifeSpan { get; set; }

        public float DeathProbability { get; set; }

        public float MinDecisionDelta { get; set; }

        public float MaxDecisionDelta { get; set; }

        public float MinDecisionDuration { get; set; }

        public float MaxDecisionDuration { get; set; }

        public float MinDecisionValue { get; set; }

        public float MaxDecisionValue { get; set; }

        public float MinShiftFactor { get; set; }

        public float MaxShiftFactor { get; set; }

        public int MinAlternatives { get; set; }

        public int MaxAlternatives { get; set; }

        public float AlternativeFactor { get; set; }

        public float AlternativeDecay { get; set; }

        public float AlternativeDepthThreshold { get; set; }

        public float MinPregnancyAge { get; set; }

        public float MaxPregnancyAge { get; set; }

        public float PregnancyProbability { get; set; }

        public float MinBirthShift { get; set; }

        public float MaxBirthShift { get; set; }
    }
}
