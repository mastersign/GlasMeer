using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.Bible.GlasOcean
{
    class RenderEngine
    {
        public RenderOptions Options { get; set; }

        public RenderEngine(RenderOptions options)
        {
            Options = options;
        }

        private PointF TransformLifePoint(LifePoint lp)
        {
            var innerHeight = Options.CanvasSize.Height - Options.Padding.Vertical;
            var horizon = Options.Padding.Top + innerHeight * (1f - Options.HorizonRatio);
            return new PointF(
                Options.Padding.Left + lp.Time * Options.TimeStretch,
                horizon - lp.Position * Options.PositionStretch);
        }

        private Color ComputeLifePointColor(float value, float reality)
            => value > 0
                ? ColorMath.Mix(Options.NeutralColor, Options.GoodColor, value, reality)
                : ColorMath.Mix(Options.NeutralColor, Options.BadColor, -value, reality);

        private void RenderIndividual(Graphics g, Individual individual, bool pivot)
        {
            if (individual.Reality < 1f && !Options.ShowAlternatives) return;

            foreach (var step in individual.Steps())
            {
                var value = step.To.Value;
                var reality = step.To.Reality;
                if (reality < 1f && !Options.ShowAlternatives) continue;
                var p1 = TransformLifePoint(step.From);
                var p2 = TransformLifePoint(step.To);
                var color = pivot && reality == 1f
                    ? Options.HighlightColor
                    : ComputeLifePointColor(value, reality);
                using (var pen = new Pen(color, Math.Max(1f, Options.LineWidth * (1 - (1 - reality) * 0.5f)))
                {
                    StartCap = LineCap.Round,
                    EndCap = LineCap.Round
                })
                {
                    g.DrawLine(pen, p1, p2);
                }
            }

            if (Options.ShowBirthPoint)
            {
                var birthPoint = TransformLifePoint(individual.BirthPoint);
                using (var birthBrush = new SolidBrush(pivot ? Options.HighlightColor : Options.BirthPointColor))
                {
                    g.FillEllipse(birthBrush,
                        birthPoint.X - Options.BirthPointSize * 0.5f,
                        birthPoint.Y - Options.BirthPointSize * 0.5f,
                        Options.BirthPointSize, Options.BirthPointSize);
                }
            }
        }

        public Bitmap Render(IEnumerable<Individual> individuals,
            Action<Bitmap> snapshotHandler, TimeSpan snapshotDelta,
            CancellationToken cancellationToken)
        {
            var bmp = new Bitmap(Options.CanvasSize.Width, Options.CanvasSize.Height, PixelFormat.Format32bppArgb);
            var g = Graphics.FromImage(bmp);
            g.Clear(Options.BackgroundColor);
            g.SmoothingMode = SmoothingMode.HighQuality;

            var t0 = DateTime.Now;
            var tRef = t0;
            Individual pivot = null;
            int index = -1;
            foreach (var individual in individuals)
            {
                index++;
                var pivotIndex = Options.PivotIndex;
                if (pivotIndex > index && index > 0) pivotIndex = pivotIndex % index;
                if (pivotIndex == index) pivot = individual;
                if (cancellationToken.IsCancelled) break;
                if (Options.PivotOnly) continue;

                RenderIndividual(g, individual, false);

                var t = DateTime.Now;
                if (t > tRef + snapshotDelta)
                {
                    tRef = t;
                    snapshotHandler?.Invoke(new Bitmap(bmp));
                }
            }
            if (Options.HighlightPivot && !Options.PivotOnly)
            {
                using (var dimBrush = new SolidBrush(Color.FromArgb(
                    ColorMath.ColorValue(Options.HighlightDimOpacity * 255f),
                    Options.BackgroundColor)))
                {
                    g.FillRectangle(dimBrush, -1, -1,
                        Options.CanvasSize.Width + 2, Options.CanvasSize.Height + 2);
                }
            }
            if (pivot != null)
            {
                if (Options.PivotOnly)
                {
                    RenderIndividual(g, pivot, false);
                }
                else if (Options.HighlightPivot)
                {
                    RenderIndividual(g, pivot, true);
                }
            }
            g.Dispose();
            return bmp;
        }
    }
}
