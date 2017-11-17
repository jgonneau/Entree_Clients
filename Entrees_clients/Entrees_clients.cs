﻿using System;
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
    public partial class FORM : Form
    {
        public FORM()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView llo = new DataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("donnees.dat");
            int j = 0;
            string donnee;
            int bcl = 1;

            while (bcl == 1)
            {
                donnee = sr.ReadLine();
                if (donnee == "X")
                {
                    dataGridView1.Rows.Add();
                    donnee = sr.ReadLine();
                    if (donnee == "1")
                    {
                        dataGridView1.Rows[j].Cells[0].Style.BackColor = Color.Red;
                        dataGridView1.Rows[j].Cells[0].Style.ForeColor = Color.Red;
                        dataGridView1.Rows[j].Cells[0].Value = "En cour...";
                    }
                    else
                    {
                        dataGridView1.Rows[j].Cells[0].Style.BackColor = Color.Blue;
                        dataGridView1.Rows[j].Cells[0].Style.ForeColor = Color.Blue;
                        dataGridView1.Rows[j].Cells[0].Value = "Terminé.";
                    }
                    donnee = sr.ReadLine();
                    dataGridView1.Rows[j].Cells[1].Value = donnee;
                    donnee = sr.ReadLine();
                    if (donnee == "")
                    {
                        while (cbpd < 11)
                        {
                            dataGridView1.Rows[bpd].Cells[cbpd].Style.BackColor = Color.LightGray;
                            cbpd++;
                        }
                        dataGridView1.Rows[0].Cells[0].Style.ForeColor = Color.LightGray;
                    }
                    dataGridView1.Rows[j].Cells[2].Value = donnee;
                    donnee = sr.ReadLine();
                    dataGridView1.Rows[j].Cells[3].Value = donnee;
                    donnee = sr.ReadLine();
                    dataGridView1.Rows[j].Cells[4].Value = donnee;
                    donnee = sr.ReadLine();
                    dataGridView1.Rows[j].Cells[5].Value = donnee;
                    donnee = sr.ReadLine();
                    dataGridView1.Rows[j].Cells[6].Value = donnee;
                    donnee = sr.ReadLine();
                    dataGridView1.Rows[j].Cells[7].Value = donnee;
                    donnee = sr.ReadLine();
                    dataGridView1.Rows[j].Cells[8].Value = donnee;
                    donnee = sr.ReadLine();
                    dataGridView1.Rows[j].Cells[9].Value = donnee;
                    donnee = sr.ReadLine();
                    dataGridView1.Rows[j].Cells[10].Value = donnee;
                    j++;
                }
                else
                {
                    bcl = 0;
                }
            }

            sr.Close();
            
           
            ///
            //Archives
            StreamReader sor = new StreamReader("Archives.dat");
            j = 0;
            donnee = "";
            bcl = 1;

            while (bcl == 1)
            {
                donnee = sor.ReadLine();
                if (donnee == "X")
                {
                    dgv_arch.Rows.Add();
                    donnee = sor.ReadLine();
                    if (donnee == "1")
                    {
                        dgv_arch.Rows[j].Cells[0].Style.BackColor = Color.Red;
                        dgv_arch.Rows[j].Cells[0].Style.ForeColor = Color.Red;
                        dgv_arch.Rows[j].Cells[0].Value = "En cour...";
                    }
                    else
                    {
                        dgv_arch.Rows[j].Cells[0].Style.BackColor = Color.Blue;
                        dgv_arch.Rows[j].Cells[0].Style.ForeColor = Color.Blue;
                        dgv_arch.Rows[j].Cells[0].Value = "Terminé.";
                    }
                    donnee = sor.ReadLine();
                    dgv_arch.Rows[j].Cells[1].Value = donnee;
                    donnee = sor.ReadLine();
                    dgv_arch.Rows[j].Cells[2].Value = donnee;
                    donnee = sor.ReadLine();
                    dgv_arch.Rows[j].Cells[3].Value = donnee;
                    donnee = sor.ReadLine();
                    dgv_arch.Rows[j].Cells[4].Value = donnee;
                    donnee = sor.ReadLine();
                    dgv_arch.Rows[j].Cells[5].Value = donnee;
                    donnee = sor.ReadLine();
                    dgv_arch.Rows[j].Cells[6].Value = donnee;
                    donnee = sor.ReadLine();
                    dgv_arch.Rows[j].Cells[7].Value = donnee;
                    donnee = sor.ReadLine();
                    dgv_arch.Rows[j].Cells[8].Value = donnee;
                    donnee = sor.ReadLine();
                    dgv_arch.Rows[j].Cells[9].Value = donnee;
                    donnee = sor.ReadLine();
                    dgv_arch.Rows[j].Cells[10].Value = donnee;
                    //neuvieme donnee;
                    j++;
                }
                else
                {
                    bcl = 0;
                }
            }

            sor.Close();

            mem_indexo = 0;

            TIK.Enabled = true;

            //+
            archiverToolStripMenuItem.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
        public int indexo;
        public void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexo = e.RowIndex;
        }

        int loool;
        public void dataGridView1_MouseOver(object sender, DataGridViewCellEventArgs e)
        {

            indexo = e.RowIndex;
            bt_exit.Text = e.RowIndex.ToString();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            string[] row0 = { "donnee1", "donnee2", "donnee3", "donnee4", "donnee5", "donnee6", "donnee7", "donnee8", "donnee9" };
            DataGridViewRowCollection rows = this.dataGridView1.Rows;
            rows.Add(row0);
        }


        private void colonneetat_Click(object sender, EventArgs e)
        {
            string[] row0 = { "donnee1", "donnee2", "donnee3", "donnee4", "donnee5", "donnee6", "donnee7", "donnee8", "donnee9" };
            DataGridViewRowCollection rows = this.dataGridView1.Rows;
            rows.Add(row0);
        }

        public static int conf_form = 0;
        private void bt_ajout_entree_Click(object sender, EventArgs e)
        {

            if (conf_form < 1)
            {
                Formulaire_entree lol = new Formulaire_entree();
                lol.Show();
                lol.Visible = true;
                conf_form++;
            }

        }

        private void bt_retrait_entree_Click(object sender, EventArgs e)
        {
            if (indexo >= 0)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette cellule ?", "Avertissement !",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    dataGridView1.Rows[indexo].Cells[0].Value = "";
                    dataGridView1.Rows[indexo].Cells[1].Value = "";
                    dataGridView1.Rows[indexo].Cells[2].Value = "";
                    dataGridView1.Rows[indexo].Cells[3].Value = "";
                    dataGridView1.Rows[indexo].Cells[4].Value = "";
                    dataGridView1.Rows[indexo].Cells[5].Value = "";
                    dataGridView1.Rows[indexo].Cells[6].Value = "";
                    dataGridView1.Rows[indexo].Cells[7].Value = "";
                    dataGridView1.Rows[indexo].Cells[8].Value = "";
                    dataGridView1.Rows.RemoveAt(indexo);
                }
            }


        }

        public static int lien = 0;
        public static int apropos = 0;
        private void bt_a_propos_Click(object sender, EventArgs e)
        {       
            if (apropos == 0)
            {
                apropos++;
                Apropos appr = new Apropos();
                appr.Show();
            }

        }

        bool modif = false;
        private void bt_modification_Click(object sender, EventArgs e)
        {
            if (modif == true)
            {
                DialogResult result = MessageBox.Show("Le mode d'édition des cellules est désactivé.", "Information :",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);
                modif = false;
            }
            else
            {
               DialogResult result = MessageBox.Show("Êtes-vous sûr de bien vouloir éditer le contenues des cellules ?", "ATTENTION /!\\",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);
               if (result == System.Windows.Forms.DialogResult.Yes)
               {

                   modif = true;

               }
                
            }

            if (modif == true)
            {
                bt_modification.BackColor = Color.Red;
                dataGridView1.ReadOnly = false;
            }
            else
            {
                bt_modification.BackColor = Color.White;
                dataGridView1.ReadOnly = true;
            }

            
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Voulez-vous quitter le programme : 'Entrees Clients' ?\nVos données seront sauvegardées.", "FERMETURE DU PROGRAMME !",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Stop);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                this.Close();

            }

            
            
        }

        private void FORM_MouseHover(object sender, EventArgs e)
        {
            //FORM.ActiveForm.Focus = "true";
        }

        public string lolilol
        {
            get { return this.bt_modification.Text; }
            set { bt_modification.Text = value; }
        }


        public static int nouvelledonnee = 0;
        public static int numero_client = 0;
        public static string date_dentree = "";
        public static string nom_client = "";
        public static string prenom_client = "";
        public static string tel_fixe = "";
        public static string tel_gsm = "";
        public static string nom_probleme = "";
        public static string nom_motdepasse = "";
        public static string nom_fournisseur = "";
        public static int fenet_arch = 0;

        int cbpd = 0, bpd;
        private void TIK_Tick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 0)
            {
                cbpd = 0;
                bpd = dataGridView1.Rows.Add();
                while (cbpd < 11)
                {
                    dataGridView1.Rows[bpd].Cells[cbpd].Style.BackColor = Color.LightGray;
                    cbpd++;
                }
            }
            indexo = dataGridView1.CurrentCellAddress.Y;

   

            if (nouvelledonnee == 1)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Style.BackColor = Color.Red;
                dataGridView1.Rows[n].Cells[0].Style.ForeColor = Color.Red;
                dataGridView1.Rows[n].Cells[0].Value = "En cour...";
                string NCstr = "";
                if (numero_client < 10)
                {
                    NCstr = "00000"+numero_client.ToString();
                }
                else if (numero_client < 100)
                {
                    NCstr = "0000" + numero_client.ToString();
                }
                else if (numero_client < 1000)
                {
                    NCstr = "000" + numero_client.ToString();
                }
                else if (numero_client < 10000)
                {
                    NCstr = "00" + numero_client.ToString();
                }
                else if (numero_client < 100000)
                {
                    NCstr = "0" + numero_client.ToString();
                }
                else
                {
                    NCstr = numero_client.ToString();
                }
                dataGridView1.Rows[n].Cells[1].Value = NCstr;
                dataGridView1.Rows[n].Cells[2].Value = date_dentree;
                dataGridView1.Rows[n].Cells[3].Value = nom_client;
                dataGridView1.Rows[n].Cells[4].Value = prenom_client;
                dataGridView1.Rows[n].Cells[5].Value = tel_fixe;
                dataGridView1.Rows[n].Cells[6].Value = tel_gsm;
                dataGridView1.Rows[n].Cells[7].Value = nom_fournisseur;
                dataGridView1.Rows[n].Cells[8].Value = nom_probleme;
                dataGridView1.Rows[n].Cells[9].Value = nom_motdepasse;

                //numero_client = "";
                date_dentree = "";
                nom_client = "";
                prenom_client = "";
                tel_fixe = "";
                tel_gsm = "";
                nom_fournisseur = "";
                nom_probleme = "";
                nom_motdepasse = "";

                nouvelledonnee = 0;
            }

            StreamWriter sw = new StreamWriter("donnees.dat");
            sw.Write("");
            int i = 0;

            while (i < dataGridView1.Rows.Count)
            {
                sw.WriteLine("X");
                if (dataGridView1.Rows[i].Cells[0].Style.BackColor == Color.Red)
                {
                    sw.WriteLine("1");
                }
                else
                {
                    sw.WriteLine("2");
                }
                sw.WriteLine(dataGridView1.Rows[i].Cells[1].Value);
                sw.WriteLine(dataGridView1.Rows[i].Cells[2].Value);
                sw.WriteLine(dataGridView1.Rows[i].Cells[3].Value);
                sw.WriteLine(dataGridView1.Rows[i].Cells[4].Value);
                sw.WriteLine(dataGridView1.Rows[i].Cells[5].Value);
                sw.WriteLine(dataGridView1.Rows[i].Cells[6].Value);
                sw.WriteLine(dataGridView1.Rows[i].Cells[7].Value);
                sw.WriteLine(dataGridView1.Rows[i].Cells[8].Value);
                sw.WriteLine(dataGridView1.Rows[i].Cells[9].Value);
                sw.WriteLine(dataGridView1.Rows[i].Cells[10].Value);
                i++;
            }
            sw.WriteLine("End");
            sw.Close();
            Console.WriteLine("Executing finally block.");
            //
            if (fenet_arch == 0)
            {
                StreamWriter swa = new StreamWriter("Archives.dat");
                swa.Write("");
                i = 0;

                while (i < dgv_arch.Rows.Count)
                {
                    swa.WriteLine("X");
                    if (dgv_arch.Rows[i].Cells[0].Style.BackColor == Color.Red)
                    {
                        swa.WriteLine("1");
                    }
                    else
                    {
                        swa.WriteLine("2");
                    }
                    swa.WriteLine(dgv_arch.Rows[i].Cells[1].Value);
                    swa.WriteLine(dgv_arch.Rows[i].Cells[2].Value);
                    swa.WriteLine(dgv_arch.Rows[i].Cells[3].Value);
                    swa.WriteLine(dgv_arch.Rows[i].Cells[4].Value);
                    swa.WriteLine(dgv_arch.Rows[i].Cells[5].Value);
                    swa.WriteLine(dgv_arch.Rows[i].Cells[6].Value);
                    swa.WriteLine(dgv_arch.Rows[i].Cells[7].Value);
                    swa.WriteLine(dgv_arch.Rows[i].Cells[8].Value);
                    swa.WriteLine(dgv_arch.Rows[i].Cells[9].Value);
                    swa.WriteLine(dgv_arch.Rows[i].Cells[10].Value);
                    i++;
                }
                swa.WriteLine("End");
                swa.Close();
                Console.WriteLine("Executing finally block.");
            }
            else
            {
               
            }
            ///

            if (dataGridView1.RowCount > 0)
            {
                if (dataGridView1.Rows[indexo].Cells[0].Value == "En cour...")
                {
                    archiverToolStripMenuItem.Enabled = false;
                    finDeTâchesToolStripMenuItem.Enabled = true;
                }
                else
                {
                    if (dataGridView1.Rows[indexo].Cells[2].Value != "")
                    {
                        archiverToolStripMenuItem.Enabled = true;
                    }
                    
                    finDeTâchesToolStripMenuItem.Enabled = false;
                }
            }


            if (mem_mater_chg != "")
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    dataGridView1.Rows[mem_indexo].Cells[10].Value = mem_mater_chg;
                }
                mem_mater_chg = "";
            }

        }

        public static int verif_arch = 0;
        public static string str_archive = "";
        public static string str_a_archive = "";
        private void bt_archives_Click(object sender, EventArgs e)
        {

            //Archive
            Archive fen_arch = new Archive();

            if (verif_arch == 0)
            {
                verif_arch++;
                fenet_arch = 1;
                fen_arch.Show();

            }
            else if (verif_arch == 4)
            {
                Archive.ActiveForm.Visible = true;
            }
        }

        public static int nouveau_arch = 0;
        public static string cli_statu = "";
        public static string cli_num = "";
        public static string cli_date = "";
        public static string cli_nom = "";
        public static string cli_prenom = "";
        public static string cli_gsm = "";
        public static string cli_fixe = "";
        public static string cli_fournisseur = "";
        public static string cli_probleme = "";
        public static string cli_motdepasse = "";
        public static string cli_materielchange = "";
        private void archiverToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ///
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show("Voulez-vous mettre cette donnée client dans les archives ?\n", "Avertissement", buttons, MessageBoxIcon.Information);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

            

            int o = dgv_arch.Rows.Add(), nb=0;
            for (nb = 0; nb < 11; nb++)
            {
                dgv_arch.Rows[o].Cells[nb].Value = dataGridView1.Rows[indexo].Cells[nb].Value;
            }

            if (verif_arch == 0)
            {
                StreamWriter tempo = new StreamWriter("temp.dat");
                //verif_arch
                tempo.Write("");
                for (nb = 0; nb < dgv_arch.Rows.Count; nb++)
                {
                    tempo.WriteLine("X");
                    tempo.WriteLine(dgv_arch.Rows[nb].Cells[0].Value);
                    tempo.WriteLine(dgv_arch.Rows[nb].Cells[1].Value);
                    tempo.WriteLine(dgv_arch.Rows[nb].Cells[2].Value);
                    tempo.WriteLine(dgv_arch.Rows[nb].Cells[3].Value);
                    tempo.WriteLine(dgv_arch.Rows[nb].Cells[4].Value);
                    tempo.WriteLine(dgv_arch.Rows[nb].Cells[5].Value);
                    tempo.WriteLine(dgv_arch.Rows[nb].Cells[6].Value);
                    tempo.WriteLine(dgv_arch.Rows[nb].Cells[7].Value);
                    tempo.WriteLine(dgv_arch.Rows[nb].Cells[8].Value);
                    tempo.WriteLine(dgv_arch.Rows[nb].Cells[9].Value);
                    tempo.WriteLine(dgv_arch.Rows[nb].Cells[10].Value);
                }
                tempo.WriteLine("End");
                tempo.Close();
            }
            else
            {//verif_arch=1

                cli_statu = dataGridView1.Rows[indexo].Cells[0].Value.ToString();
                cli_num = dataGridView1.Rows[indexo].Cells[1].Value.ToString();
                cli_date = dataGridView1.Rows[indexo].Cells[2].Value.ToString();
                cli_nom = dataGridView1.Rows[indexo].Cells[3].Value.ToString();
                cli_prenom = dataGridView1.Rows[indexo].Cells[4].Value.ToString();
                cli_fixe = dataGridView1.Rows[indexo].Cells[5].Value.ToString();
                cli_gsm = dataGridView1.Rows[indexo].Cells[6].Value.ToString();
                cli_fournisseur = dataGridView1.Rows[indexo].Cells[7].Value.ToString();
                cli_probleme = dataGridView1.Rows[indexo].Cells[8].Value.ToString();
                cli_motdepasse = dataGridView1.Rows[indexo].Cells[9].Value.ToString();
                cli_materielchange = dataGridView1.Rows[indexo].Cells[10].Value.ToString();
                nouveau_arch = 1;
            }

            dataGridView1.Rows.RemoveAt(indexo);
            }
            ///
        }

        public static int mem_indexo;
        public static string mem_mater_chg;
        public static int fen_chang_opoc = 0;
        private void finDeTâchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fen_chang_opoc == 0)
            {
                Fmat fen_change = new Fmat();
                fen_change.Show();
                fen_chang_opoc = 1;
            }

            mem_indexo = indexo;

            dataGridView1.Rows[indexo].Cells[0].Style.BackColor = Color.Blue;
            dataGridView1.Rows[indexo].Cells[0].Style.ForeColor = Color.Blue;
            dataGridView1.Rows[indexo].Cells[0].Value = "Terminé.";
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez-vous quitter le programme : 'Entrees Clients' ?\nVos données seront sauvegardées.", "FERMETURE DU PROGRAMME !",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Stop);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                this.Close();

            }
        }

        
    }
}
