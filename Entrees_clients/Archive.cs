using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Archive : Form
    {
        public Archive()
        {
            InitializeComponent();
        }

        public static string matchng = "";
        private void Archive_Load(object sender, EventArgs e)
        {
            //TIM_arch.Enabled = true;
            //lecture:
            if (FORM.fenet_arch == 1)
            {
                //Archives
                StreamReader sor = new StreamReader("Archives.dat");
                //int n = dataGridView1.Rows.Add();
                int j = 0;
                string donnee = "";
                int bcl = 1;

                while (bcl == 1)
                {
                    donnee = sor.ReadLine();
                    if (donnee == "X")
                    {
                        //MessageBox.Show("Ok");
                        dataGridView2.Rows.Add();
                        donnee = sor.ReadLine();
                        if (donnee == "1")
                        {
                            dataGridView2.Rows[j].Cells[0].Style.BackColor = Color.Red;
                            dataGridView2.Rows[j].Cells[0].Style.ForeColor = Color.Red;
                            dataGridView2.Rows[j].Cells[0].Value = "En cour...";
                        }
                        else
                        {
                            dataGridView2.Rows[j].Cells[0].Style.BackColor = Color.Blue;
                            dataGridView2.Rows[j].Cells[0].Style.ForeColor = Color.Blue;
                            dataGridView2.Rows[j].Cells[0].Value = "Terminé.";
                        }
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[1].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[2].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[3].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[4].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[5].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[6].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[7].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[8].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[9].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[10].Value = donnee;
                        //neuvieme donnee;
                        j++;
                    }
                    else
                    {
                        bcl = 0;
                    }
                    //TIM_arch.Enabled = true;
                }
                sor.Close();


                //access temp
                StreamReader tempp = new StreamReader("temp.dat");
                while (bcl == 1)
                {
                    donnee = sor.ReadLine();
                    if (donnee == "X")
                    {
                        //MessageBox.Show("Ok");
                        dataGridView2.Rows.Add();
                        donnee = tempp.ReadLine();
                        if (donnee == "1")
                        {
                            dataGridView2.Rows[j].Cells[0].Style.BackColor = Color.Red;
                            dataGridView2.Rows[j].Cells[0].Style.ForeColor = Color.Red;
                            dataGridView2.Rows[j].Cells[0].Value = "En cour...";
                        }
                        else
                        {
                            dataGridView2.Rows[j].Cells[0].Style.BackColor = Color.Blue;
                            dataGridView2.Rows[j].Cells[0].Style.ForeColor = Color.Blue;
                            dataGridView2.Rows[j].Cells[0].Value = "Terminé.";
                        }
                        donnee = tempp.ReadLine();
                        dataGridView2.Rows[j].Cells[1].Value = donnee;
                        donnee = tempp.ReadLine();
                        dataGridView2.Rows[j].Cells[2].Value = donnee;
                        donnee = tempp.ReadLine();
                        dataGridView2.Rows[j].Cells[3].Value = donnee;
                        donnee = tempp.ReadLine();
                        dataGridView2.Rows[j].Cells[4].Value = donnee;
                        donnee = tempp.ReadLine();
                        dataGridView2.Rows[j].Cells[5].Value = donnee;
                        donnee = tempp.ReadLine();
                        dataGridView2.Rows[j].Cells[6].Value = donnee;
                        donnee = tempp.ReadLine();
                        dataGridView2.Rows[j].Cells[7].Value = donnee;
                        donnee = tempp.ReadLine();
                        dataGridView2.Rows[j].Cells[8].Value = donnee;
                        donnee = tempp.ReadLine();
                        dataGridView2.Rows[j].Cells[9].Value = donnee;
                        donnee = tempp.ReadLine();
                        dataGridView2.Rows[j].Cells[10].Value = donnee;
                        //neuvieme donnee;
                        j++;
                    }
                    else
                    {
                        bcl = 0;
                    }
                }
                    tempp.Close(); //
            }
            TIM_arch.Enabled = true;

            //Detection de materiaux changés//
            /*
            int rc = dataGridView2.RowCount, compt=0;
            while (compt < rc)
            {
                if (dataGridView2.Rows[0].Cells[10].Value == "")
                {
                    Fmat matchange = new Fmat();
                    matchange.Show();

                }
                compt++;
            }*/

        }

        private void Archive_FormClosing(object sender, FormClosingEventArgs e)
        {
            FORM.verif_arch = 0;
            //FORM.fenet_arch = 3;
            //FORM.ActiveForm.Visible = true;
        }

        public static int indexarchiv = 0;
        private void TIM_arch_Tick(object sender, EventArgs e)
        {
            

            //ecriture

            if (FORM.fenet_arch == 1)
            {
                indexarchiv = dataGridView2.CurrentCellAddress.Y;

                StreamWriter swa = new StreamWriter("Archives.dat");
                swa.Write("");
                int i = 0;

                while (i < dataGridView2.Rows.Count)
                {
                    /*
                    if (dataGridView1.Rows[i].Cells[0] == 1)
                    { }
                     */
                    swa.WriteLine("X");
                    if (dataGridView2.Rows[i].Cells[0].Style.BackColor == Color.Red)
                    {
                        swa.WriteLine("1");
                    }
                    else
                    {
                        swa.WriteLine("2");
                    }
                    swa.WriteLine(dataGridView2.Rows[i].Cells[1].Value);
                    swa.WriteLine(dataGridView2.Rows[i].Cells[2].Value);
                    swa.WriteLine(dataGridView2.Rows[i].Cells[3].Value);
                    swa.WriteLine(dataGridView2.Rows[i].Cells[4].Value);
                    swa.WriteLine(dataGridView2.Rows[i].Cells[5].Value);
                    swa.WriteLine(dataGridView2.Rows[i].Cells[6].Value);
                    swa.WriteLine(dataGridView2.Rows[i].Cells[7].Value);
                    swa.WriteLine(dataGridView2.Rows[i].Cells[8].Value);
                    swa.WriteLine(dataGridView2.Rows[i].Cells[9].Value);
                    swa.WriteLine(dataGridView2.Rows[i].Cells[10].Value);
                    //ataGridView1.Rows[i].Cells[0].ToString();
                    //dataGridView1.Rows[i].Cells[8].ToString();
                    i++;
                }
                swa.WriteLine("End");
                swa.Close();
                Console.WriteLine("Executing finally block.");
            }
            
            //lecture:
            if (FORM.fenet_arch == 1)
            {
                //Archives
                StreamReader sor = new StreamReader("Archives.dat");
                //int n = dataGridView1.Rows.Add();
                int j = 0;
                string donnee = "";
                int bcl = 1;

                while (bcl == 1)
                {
                    donnee = sor.ReadLine();
                    if (donnee == "X")
                    {
                        //MessageBox.Show("Ok");
                        //dataGridView2.Rows.Add();
                        donnee = sor.ReadLine();
                        if (donnee == "1")
                        {
                            dataGridView2.Rows[j].Cells[0].Style.BackColor = Color.Red;
                            dataGridView2.Rows[j].Cells[0].Style.ForeColor = Color.Red;
                            dataGridView2.Rows[j].Cells[0].Value = "En cour...";
                        }
                        else
                        {
                            dataGridView2.Rows[j].Cells[0].Style.BackColor = Color.Blue;
                            dataGridView2.Rows[j].Cells[0].Style.ForeColor = Color.Blue;
                            dataGridView2.Rows[j].Cells[0].Value = "Terminé.";
                        }
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[1].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[2].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[3].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[4].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[5].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[6].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[7].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[8].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[9].Value = donnee;
                        donnee = sor.ReadLine();
                        dataGridView2.Rows[j].Cells[10].Value = donnee;
                        //neuvieme donnee;
                        j++;
                    }
                    else
                    {
                        bcl = 0;
                    }
                    //TIM_arch.Enabled = true;
                }
                sor.Close();

                // // /// nouveau cli
                //MessageBox.Show(dataGridView2.RowCount.ToString());
                
                if (FORM.nouveau_arch == 1)
                {
                    int nl = dataGridView2.Rows.Add();
                    //int nl = dataGridView2.RowCount-1;

                    if (FORM.cli_statu == "1")
                    {
                        dataGridView2.Rows[nl].Cells[0].Style.BackColor = Color.Red;
                        dataGridView2.Rows[nl].Cells[0].Style.ForeColor = Color.Red;
                        dataGridView2.Rows[nl].Cells[0].Value = "En cour...";
                    }
                    else
                    {
                        dataGridView2.Rows[nl].Cells[0].Style.BackColor = Color.Blue;
                        dataGridView2.Rows[nl].Cells[0].Style.ForeColor = Color.Blue;
                        dataGridView2.Rows[nl].Cells[0].Value = "Terminé.";
                    }
                    dataGridView2.Rows[nl].Cells[1].Value = FORM.cli_num;
                    dataGridView2.Rows[nl].Cells[2].Value = FORM.cli_date;
                    dataGridView2.Rows[nl].Cells[3].Value = FORM.cli_nom;
                    dataGridView2.Rows[nl].Cells[4].Value = FORM.cli_prenom;
                    dataGridView2.Rows[nl].Cells[5].Value = FORM.cli_gsm;
                    dataGridView2.Rows[nl].Cells[6].Value = FORM.cli_fixe;
                    dataGridView2.Rows[nl].Cells[7].Value = FORM.cli_fournisseur;
                    dataGridView2.Rows[nl].Cells[8].Value = FORM.cli_probleme;
                    dataGridView2.Rows[nl].Cells[9].Value = FORM.cli_motdepasse;
                    dataGridView2.Rows[nl].Cells[10].Value = FORM.cli_materielchange;

                    FORM.nouveau_arch = 0;
                }

            }
        }

        private void Archive_FormClosed(object sender, FormClosedEventArgs e)
        {
            FORM.fenet_arch = 0;
        }

        private void supprDeffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer définitivement cette cellule ?", "Attention !!",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                ///
                dataGridView2.Rows.RemoveAt(indexarchiv);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
