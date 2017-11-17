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
    public partial class Apropos : Form
    {
        public Apropos()
        {
            InitializeComponent();
        }

        private void Apropos_FormClosed(object sender, FormClosedEventArgs e)
        {
            FORM.apropos = 0;
        }
    }
}
