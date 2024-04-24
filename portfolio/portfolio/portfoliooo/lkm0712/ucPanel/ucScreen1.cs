using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lkm0712.ucPanel
{
    public partial class ucScreen1 : UserControl
    {
        public ucScreen1()
        {
            InitializeComponent();
        }

        private void ucScreen1_Load(object sender, EventArgs e)
        {
            pictureBox1.Tag = "hello!";
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pictureBox1.Tag.ToString());
        }
    }
}
