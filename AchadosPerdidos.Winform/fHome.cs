using AchadosPerdidos.Winform.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AchadosPerdidos.Winform
{
    public partial class fHome : Form
    {
        public fHome()
        {
            InitializeComponent();
        }

		private void sairToolStripMenuItem_Click(object sender, EventArgs e)
		{
            this.Close();
		}

		private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
		{
            pnlHome.Controls.Clear();
            pnlHome.Controls.Add(new AddLostView());
 		}
	}
}
