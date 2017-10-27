using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Mastersign.Bible.GlasOcean
{
    public class GlasMeerConfiguration
    {
        public LifeParameter LifeParameter { get; set; }

        public RenderOptions RenderOptions { get; set; }

        public void Safe(string fileName)
        {
            XmlSerializer s = new XmlSerializer(typeof(GlasMeerConfiguration));
            using (var w = new StreamWriter(fileName, false, Encoding.UTF8))
            {
                s.Serialize(w, this);
            }
        }

        public static GlasMeerConfiguration Load(string fileName)
        {
            XmlSerializer s = new XmlSerializer(typeof(GlasMeerConfiguration));
            try
            {
                using (var r = new StreamReader(fileName, Encoding.UTF8))
                {
                    return (GlasMeerConfiguration)s.Deserialize(r);
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Failed: " + e.Message,
                    "Load Configuration",
                    System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
