using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.Bible.GlasOcean
{
    class RenderResult
    {
        public Bitmap Picture { get; private set; }

        public RenderStats Stats { get; private set; }

        public RenderResult(Bitmap picture, RenderStats stats)
        {
            Picture = picture;
            Stats = stats;
        }
    }
}
