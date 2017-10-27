using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastersign.Bible.GlasOcean
{
    class CancellationToken
    {
        public bool IsCancelled { get; private set; }

        public void Cancel() { IsCancelled = true; }
    }
}
