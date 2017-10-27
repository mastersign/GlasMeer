using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.Bible.GlasOcean
{
    static class ColorMath
    {
        public static float Mix(float a, float b, float value) => a + (b - a) * value;

        public static byte ColorValue(float v) => (byte)Math.Min(byte.MaxValue, Math.Max(byte.MinValue, v));

        public static Color Mix(Color c1, Color c2, float value, float alpha = 1.0f)
            => Color.FromArgb(
                ColorValue(Mix(c1.A, c2.A, value) * alpha),
                ColorValue(Mix(c1.R, c2.R, value)),
                ColorValue(Mix(c1.G, c2.G, value)),
                ColorValue(Mix(c1.B, c2.B, value)));
    }
}
