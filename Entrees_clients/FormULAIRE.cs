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
    public partial class Formulaire_entree : Form
    {
        public Formulaire_entree()
        {
            InitializeComponent();
        }

        private void Calendarr_DateChanged(object sender, DateRangeEventArgs e)
        {
           
        }

        private void Formulaire_entree_Load(object sender, EventArgs e)
        {
            string num_cli = "";
            int num_cliNB = 0;
            TXT_date.Text = Calendarr.TodayDate.ToShortDateString();
            FORM.lien = 1;
            if (FORM.numero_client == 0)
            {
                StreamReader recup = new StreamReader("tmp.dat");
                num_cli = recup.ReadLine();
                num_cliNB = Convert.ToInt32(num_cli);
                if (num_cliNB == 0)
                {
                    FORM.numero_client = 1;
                }
                else
                {
                    FORM.numero_client = num_cliNB++; //+1?
                }
                recup.Close();
            }
        }

        private void BT_ajouter_Click(object sender, EventArgs e)
        {
            FORM.lien = 0;
            FORM.date_dentree = TXT_date.Text;
            if (TXT_nom_client.Text != "") { FORM.nom_client = TXT_nom_client.Text; }
            else { FORM.nom_client = "/"; }
            if (TXT_prenom_client.Text != "") { FORM.prenom_client = TXT_prenom_client.Text; }
            else { FORM.prenom_client = "/"; }
            if (TXT_fixe.Text != "") { FORM.tel_fixe = TXT_fixe.Text; }
            else { FORM.tel_fixe = "/"; }
            if (TXT_gsm.Text != "") { FORM.tel_gsm = TXT_gsm.Text; }
            else { FORM.tel_gsm = "/"; }
            if (TXT_fournisseur.Text != "") { FORM.nom_fournisseur = TXT_fournisseur.Text; }
            else { FORM.nom_fournisseur = "/"; }
            if (TXT_probleme.Text != "") { FORM.nom_probleme= TXT_probleme.Text; }
            else { FORM.nom_probleme = "/"; }
            if (TXT_mot_de_passe.Text != "") { FORM.nom_motdepasse = TXT_mot_de_passe.Text; }
            else { FORM.nom_motdepasse = "/"; }

            FORM.nouvelledonnee = 1;
            FORM.conf_form--;
            
            StreamWriter sauv = new StreamWriter("tmp.dat");
            FORM.numero_client++;
            sauv.Write(FORM.numero_client.ToString());
            //FORM.numero_client--;
            sauv.Dispose();
            sauv.Close();
            this.Close();
        }

        public string fdate
        {
            get { return this.TXT_date.Text; }
            set { TXT_date.Text = value; }
        }

        public string fnom
        {
            get { return this.TXT_nom_client.Text; }
            set { TXT_nom_client.Text = value; }
        }

        public string fprenom
        {
            get { return this.TXT_prenom_client.Text; }
            set { TXT_prenom_client.Text = value; }
        }

        public string ffixe
        {
            get { return this.TXT_gsm.Text; }
            set { TXT_gsm.Text = value; }
        }

        public string fgsm
        {
            get { return this.TXT_fixe.Text; }
            set { TXT_fixe.Text = value; }
        }

        public string ffournisseur
        {
            get { return this.TXT_fournisseur.Text; }
            set { TXT_fournisseur.Text = value; }
        }

        public string fprobleme
        {
            get { return this.TXT_probleme.Text; }
            set { TXT_probleme.Text = value; }
        }

        public string fmotdepasse
        {
            get { return this.TXT_mot_de_passe.Text; }
            set { TXT_mot_de_passe.Text = value; }
        }

        private void LBL_date_Click(object sender, EventArgs e)
        {
            LBL_date.Text = this.Focused.ToString();
        }

        private void Formulaire_entree_FormClosed(object sender, FormClosedEventArgs e)
        {
            FORM.conf_form--;
        }
    }
}
