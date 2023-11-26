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
    public partial class FrmLoginAtendente : Form
    {
        public FrmLoginAtendente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAtendente frmAtendente = new FrmAtendente();
            frmAtendente.Show();
        }
    }
}
