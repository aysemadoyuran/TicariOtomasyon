using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tco_new
{
    public partial class not_detay : Form
    {
        public not_detay()
        {
            InitializeComponent();
        }
        public string metin;
        private void not_detay_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = metin;
        }
    }
}
