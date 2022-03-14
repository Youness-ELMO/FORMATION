using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMATION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void academieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Academie A=new Academie();
            A.Show();
        }

        private void professeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Professeur pro=new Professeur();
            pro.Show();
        }
    }
}
