using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aksiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contohToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.TopLevel = false;
            panel4.Controls.Add(s);
            s.BringToFront();
            s.Show();
        }

        private void ajibToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 t = new Form3();
            t.TopLevel = false;
            panel4.Controls.Add(t);
            t.BringToFront();
            t.Show();
        }
    }
}
