using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladat0407
{
    public partial class Form1 : Form
    {
        int oszto;
        int osztando; 
        int eredmeny; 

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void osztásToolStripMenuItem_Click(object sender, EventArgs e)
        {

             oszto = 5;
             osztando = 10;
             eredmeny = osztando / oszto;
            lbMuvelet.Text = $"{osztando}/{oszto}";
        
        }

        private void btEllenoriz_Click(object sender, EventArgs e)
        {

            if (nValasz.Value == eredmeny)
            {
                lbEredmeny.Text = "A megoldás jó";
            }
            else
            {
                lbEredmeny.Text = "A megoldás helytelen";
            }
        }
    }
}
