using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFaculdade
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmLoginAtendente fa = new FrmLoginAtendente();
            fa.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLoginGerente fg = new FrmLoginGerente();
            fg.Show();
        }
    }
}
