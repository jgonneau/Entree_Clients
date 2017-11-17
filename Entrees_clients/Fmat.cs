using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Fmat : Form
    {
        public Fmat()
        {
            InitializeComponent();
        }

        private void Fmat_Load(object sender, EventArgs e)
        {

        }

        private void btt_Click(object sender, EventArgs e)
        {
            FORM.mem_mater_chg = tb.Text;
            FORM.fen_chang_opoc = 0;
            this.Close();
            
        }

        private void Fmat_FormClosed(object sender, FormClosedEventArgs e)
        {
            FORM.fen_chang_opoc = 0;
        }
    }
}
