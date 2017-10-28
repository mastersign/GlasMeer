using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.Bible.GlasOcean
{
    class IndividualGenerator
    {
        public LifeParameter Parameter { get; set; }

        private Random populationRand;
        private Random decisionRand;

        public IndividualGenerator(LifeParameter parameter)
        {
            Parameter = parameter;
        }

        public IEnumerable<Individual> Generate()
        {
            populationRand = new Random(Parameter.PopulationRandomSeed);
            decisionRand = new Random(Parameter.DecisionRandomSeed);

            return GenerateIndividual(0, 0, 1f);
        }

        private IEnumerable<Individual> GenerateIndividual(float birthTime, float birthPosition, float reality, bool birthShift = false)
        {
            var individual = new Individual
            {
                Reality = reality,
                BirthTime = birthTime,
                BirthPosition = birthPosition,
                BirthShift = birthShift
                    ? (decisionRand.ProbableEvent(Parameter.PositiveBirthShiftProbability)
                        ? decisionRand.NextFloat(Parameter.MinBirthShift, Parameter.MaxBirthShift)
                        : -decisionRand.NextFloat(Parameter.MinBirthShift, Parameter.MaxBirthShift))
                    : 0f,
                DecisionChain = GenerateDecisionTree(reality, 0f, 0),
            };
            yield return individual;

            // create children
            var age = 0f;
            var p = individual.BirthPosition + individual.BirthShift;
            var d = individual.DecisionChain;
            do
            {
                if (d == null) break;
                age += d.TimeDuration + d.TimeDelta;
                p += d.Shift;
                var t = birthTime + age;
                if (t < Parameter.MaxTime &&
                    age >= Parameter.MinPregnancyAge &&
                    populationRand.ProbableEvent(Parameter.PregnancyProbability))
                {
                    foreach (var child in GenerateIndividual(t, p, d.Reality, true))
                    {
                        yield return child;
                    }
                }
                d = d.FollowUp;
            } while (age <= Parameter.MaxPregnancyAge);
        }

        private Decision GenerateDecisionTree(float baseReality, float age, int alternativeDepth)
        {
            var d = GenerateRandomDecision(baseReality);
            age += d.TimeDuration + d.TimeDelta;
            var isReal = baseReality == 1f;
            
            if ((isReal || alternativeDepth < Parameter.AlternativeDepthThreshold) &&
                age < Parameter.MaxLifeSpan &&
                !populationRand.ProbableEvent(Parameter.DeathProbability))
            {
                d.FollowUp = GenerateDecisionTree(baseReality, age, 0);
                var alternativesCount = populationRand.Next(Parameter.MinAlternatives, Parameter.MaxAlternatives + 1);
                var alternativeReality = baseReality == 1.0f
                    ? baseReality * Parameter.AlternativeFactor
                    : baseReality * Parameter.AlternativeDecay;
                d.Alternatives = new Decision[alternativesCount];
                for (int i = 0; i < alternativesCount; i++)
                {
                    d.Alternatives[i] = GenerateDecisionTree(alternativeReality, age, alternativeDepth + 1);
                }
            }
            return d;
        }

        private Decision GenerateRandomDecision(float reality)
        {
            var decisionTime = populationRand.NextFloat(Parameter.MinDecisionDelta, Parameter.MaxDecisionDelta);
            var duration = populationRand.NextFloat(Parameter.MinDecisionDuration, Parameter.MaxDecisionDuration);
            var value = decisionRand.NextFloat(Parameter.MinDecisionValue, Parameter.MaxDecisionValue);
            var shift = value * decisionRand.NextFloat(Parameter.MinShiftFactor, Parameter.MaxShiftFactor);
            return new Decision(decisionTime, duration, value, shift, reality);
        }
    }
}
