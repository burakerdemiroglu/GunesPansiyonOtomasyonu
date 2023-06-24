using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gunes_Pansiyon_Uygulaması
{
    public partial class FrmGazeteler : Form
    {
        public FrmGazeteler()
        {
            InitializeComponent();
            Gazeteler.ScriptErrorsSuppressed = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gazeteler.Navigate("https://www.hurriyet.com.tr/");
        }

        private void FrmGazeteler_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gazeteler.Navigate("https://www.haberturk.com/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gazeteler.Navigate("https://www.milliyet.com.tr/");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Gazeteler.Navigate("https://www.sozcu.com.tr/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Gazeteler.Navigate("https://www.fanatik.com.tr/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Gazeteler.Navigate("https://www.mynet.com/");
        }
    }
}
