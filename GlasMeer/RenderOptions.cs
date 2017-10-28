using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Mastersign.Bible.GlasOcean
{
    public class RenderOptions
    {
        public Size CanvasSize { get; set; }

        public float LineWidth { get; set; }

        public Padding Padding { get; set; }

        public float TimeStretch { get; set; }

        public float HorizonRatio { get; set; }

        public float PositionStretch { get; set; }

        [XmlIgnore]
        public Color BackgroundColor { get; set; }

        [XmlElement(nameof(BackgroundColor))]
        [Browsable(false)]
        public string BackgroundHtml
        {
            get { return ColorTranslator.ToHtml(BackgroundColor); }
            set { BackgroundColor = ColorTranslator.FromHtml(value); }
        }

        [XmlIgnore]
        public Color BirthPointColor { get; set; }

        [XmlElement(nameof(BirthPointColor))]
        [Browsable(false)]
        public string BirthHtml
        {
            get { return ColorTranslator.ToHtml(BirthPointColor); }
            set { BirthPointColor = ColorTranslator.FromHtml(value); }
        }

        public float BirthPointSize { get; set; }

        [XmlIgnore]
        public Color NeutralColor { get; set; }

        [XmlElement(nameof(NeutralColor))]
        [Browsable(false)]
        public string NeutralHtml
        {
            get { return ColorTranslator.ToHtml(NeutralColor); }
            set { NeutralColor = ColorTranslator.FromHtml(value); }
        }

        [XmlIgnore]
        public Color GoodColor { get; set; }

        [XmlElement(nameof(GoodColor))]
        [Browsable(false)]
        public string GoodColorHtml
        {
            get { return ColorTranslator.ToHtml(GoodColor); }
            set { GoodColor = ColorTranslator.FromHtml(value); }
        }

        [XmlIgnore]
        public Color BadColor { get; set; }

        [XmlElement(nameof(BadColor))]
        [Browsable(false)]
        public string BadColorHtml
        {
            get { return ColorTranslator.ToHtml(BadColor); }
            set { BadColor = ColorTranslator.FromHtml(value); }
        }

        public bool ShowAlternatives { get; set; }

        public bool ShowBirthPoint { get; set; }

        public long PivotIndex { get; set; }

        public bool PivotOnly { get; set; }

        public bool HighlightPivot { get; set; }

        [XmlIgnore]
        public Color HighlightColor { get; set; }

        [XmlElement(nameof(HighlightColor))]
        [Browsable(false)]
        public string HighlightColorHtml
        {
            get { return ColorTranslator.ToHtml(HighlightColor); }
            set { HighlightColor = ColorTranslator.FromHtml(value); }
        }

        public float HighlightDimOpacity { get; set; }

        public RenderOptions Scale(float factor)
        {
            return new RenderOptions
            {
                CanvasSize = new Size(
                    (int)(CanvasSize.Width * factor),
                    (int)(CanvasSize.Height * factor)),
                LineWidth = LineWidth * factor,
                Padding = new Padding(
                    (int)(Padding.Left * factor),
                    (int)(Padding.Top * factor),
                    (int)(Padding.Right * factor),
                    (int)(Padding.Bottom * factor)),
                TimeStretch = TimeStretch * factor,
                HorizonRatio = HorizonRatio,
                PositionStretch = PositionStretch * factor,
                BackgroundColor = BackgroundColor,
                BirthPointColor = BirthPointColor,
                BirthPointSize = BirthPointSize * factor,
                NeutralColor = NeutralColor,
                GoodColor = GoodColor,
                BadColor = BadColor,
                ShowAlternatives = ShowAlternatives,
                ShowBirthPoint = ShowBirthPoint,
                PivotIndex = PivotIndex,
                PivotOnly = PivotOnly,
                HighlightPivot = HighlightPivot,
                HighlightColor = HighlightColor,
                HighlightDimOpacity = HighlightDimOpacity
            };
        }
    }
}
