using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.Bible.GlasOcean
{
    class Individual
    {
        public Individual Parent;
        public float BirthTime;
        public float BirthPosition;
        public Decision DecisionChain;
        public float Reality;

        private IEnumerable<LifeStep> IterateSteps(LifePoint from, Decision by, bool withAlternatives)
        {
            var p1 = new LifePoint(
                time: from.Time + by.TimeDuration,
                position: from.Position,
                value: from.Value,
                reality: by.Reality);
            var p2 = new LifePoint(
                time: p1.Time + by.TimeDelta,
                position: p1.Position + by.Shift,
                value: p1.Value + by.Value,
                reality: by.Reality);
            yield return new LifeStep(from, p1);
            yield return new LifeStep(p1, p2);
            if (by.FollowUp != null)
            {
                foreach (var s in IterateSteps(p2, by.FollowUp, withAlternatives)) yield return s;
            }
            if (withAlternatives && by.Alternatives != null)
            {
                foreach (var a in by.Alternatives)
                {
                    foreach (var s in IterateSteps(p2, a, true)) yield return s;
                }
            }
        }

        public LifePoint BirthPoint
            => new LifePoint(BirthTime, BirthPosition, 0f, Reality);

        public IEnumerable<LifeStep> Steps(bool withAlternatives = true)
            => DecisionChain != null
                ? IterateSteps(BirthPoint, DecisionChain, withAlternatives)
                : Array.Empty<LifeStep>();
    }

    class Decision
    {
        public float TimeDelta;
        public float TimeDuration;
        public float Value;
        public float Shift;
        public float Reality;

        public Decision FollowUp;
        public Decision[] Alternatives;

        public Decision(float timeDelta, float timeDuration, float value, float shift, float reality)
        {
            TimeDelta = timeDelta;
            TimeDuration = timeDuration;
            Value = value;
            Shift = shift;
            Reality = reality;
        }
    }

    struct LifePoint
    {
        public float Time;
        public float Position;
        public float Value;
        public float Reality;

        public LifePoint(float time, float position, float value, float reality)
        {
            Time = time;
            Position = position;
            Value = value;
            Reality = reality;
        }
    }

    struct LifeStep
    {
        public LifePoint From;
        public LifePoint To;

        public LifeStep(LifePoint from, LifePoint to)
        {
            From = from;
            To = to;
        }
    }
}
