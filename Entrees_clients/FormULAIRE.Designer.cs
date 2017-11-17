namespace WindowsFormsApplication1
{
    partial class Formulaire_entree
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulaire_entree));
            this.LBL_date = new System.Windows.Forms.Label();
            this.LBL_nom_client = new System.Windows.Forms.Label();
            this.LBL_prenom_client = new System.Windows.Forms.Label();
            this.LBL_fixe = new System.Windows.Forms.Label();
            this.LBL_gsm = new System.Windows.Forms.Label();
            this.LBL_probleme = new System.Windows.Forms.Label();
            this.LBL_mot_de_passe = new System.Windows.Forms.Label();
            this.TXT_date = new System.Windows.Forms.TextBox();
            this.TXT_nom_client = new System.Windows.Forms.TextBox();
            this.TXT_prenom_client = new System.Windows.Forms.TextBox();
            this.TXT_fixe = new System.Windows.Forms.TextBox();
            this.TXT_gsm = new System.Windows.Forms.TextBox();
            this.TXT_mot_de_passe = new System.Windows.Forms.TextBox();
            this.TXT_probleme = new System.Windows.Forms.TextBox();
            this.TXT_fournisseur = new System.Windows.Forms.TextBox();
            this.LBL_fournisseur = new System.Windows.Forms.Label();
            this.PB = new System.Windows.Forms.PictureBox();
            this.BT_ajouter = new System.Windows.Forms.Button();
            this.Calendarr = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // LBL_date
            // 
            this.LBL_date.AutoSize = true;
            this.LBL_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_date.Location = new System.Drawing.Point(13, 17);
            this.LBL_date.Name = "LBL_date";
            this.LBL_date.Size = new System.Drawing.Size(203, 36);
            this.LBL_date.TabIndex = 0;
            this.LBL_date.Text = "Date d\'entree";
            this.LBL_date.Click += new System.EventHandler(this.LBL_date_Click);
            // 
            // LBL_nom_client
            // 
            this.LBL_nom_client.AutoSize = true;
            this.LBL_nom_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_nom_client.Location = new System.Drawing.Point(359, 17);
            this.LBL_nom_client.Name = "LBL_nom_client";
            this.LBL_nom_client.Size = new System.Drawing.Size(171, 36);
            this.LBL_nom_client.TabIndex = 1;
            this.LBL_nom_client.Text = "Nom Client";
            // 
            // LBL_prenom_client
            // 
            this.LBL_prenom_client.AutoSize = true;
            this.LBL_prenom_client.BackColor = System.Drawing.SystemColors.Control;
            this.LBL_prenom_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_prenom_client.Location = new System.Drawing.Point(615, 17);
            this.LBL_prenom_client.Name = "LBL_prenom_client";
            this.LBL_prenom_client.Size = new System.Drawing.Size(215, 36);
            this.LBL_prenom_client.TabIndex = 2;
            this.LBL_prenom_client.Text = "Prenom Client";
            // 
            // LBL_fixe
            // 
            this.LBL_fixe.AutoSize = true;
            this.LBL_fixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_fixe.Location = new System.Drawing.Point(359, 118);
            this.LBL_fixe.Name = "LBL_fixe";
            this.LBL_fixe.Size = new System.Drawing.Size(162, 36);
            this.LBL_fixe.TabIndex = 3;
            this.LBL_fixe.Text = "TEL: FIXE";
            // 
            // LBL_gsm
            // 
            this.LBL_gsm.AutoSize = true;
            this.LBL_gsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_gsm.Location = new System.Drawing.Point(615, 118);
            this.LBL_gsm.Name = "LBL_gsm";
            this.LBL_gsm.Size = new System.Drawing.Size(162, 36);
            this.LBL_gsm.TabIndex = 4;
            this.LBL_gsm.Text = "TEL: GSM";
            // 
            // LBL_probleme
            // 
            this.LBL_probleme.AutoSize = true;
            this.LBL_probleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_probleme.Location = new System.Drawing.Point(13, 251);
            this.LBL_probleme.Name = "LBL_probleme";
            this.LBL_probleme.Size = new System.Drawing.Size(149, 36);
            this.LBL_probleme.TabIndex = 6;
            this.LBL_probleme.Text = "Problème";
            // 
            // LBL_mot_de_passe
            // 
            this.LBL_mot_de_passe.AutoSize = true;
            this.LBL_mot_de_passe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_mot_de_passe.Location = new System.Drawing.Point(29, 213);
            this.LBL_mot_de_passe.Name = "LBL_mot_de_passe";
            this.LBL_mot_de_passe.Size = new System.Drawing.Size(205, 36);
            this.LBL_mot_de_passe.TabIndex = 7;
            this.LBL_mot_de_passe.Text = "Mot de passe";
            // 
            // TXT_date
            // 
            this.TXT_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_date.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TXT_date.Location = new System.Drawing.Point(19, 56);
            this.TXT_date.Name = "TXT_date";
            this.TXT_date.Size = new System.Drawing.Size(204, 45);
            this.TXT_date.TabIndex = 8;
            this.TXT_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TXT_nom_client
            // 
            this.TXT_nom_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_nom_client.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TXT_nom_client.Location = new System.Drawing.Point(365, 56);
            this.TXT_nom_client.Multiline = true;
            this.TXT_nom_client.Name = "TXT_nom_client";
            this.TXT_nom_client.Size = new System.Drawing.Size(190, 36);
            this.TXT_nom_client.TabIndex = 9;
            // 
            // TXT_prenom_client
            // 
            this.TXT_prenom_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_prenom_client.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TXT_prenom_client.Location = new System.Drawing.Point(621, 56);
            this.TXT_prenom_client.Multiline = true;
            this.TXT_prenom_client.Name = "TXT_prenom_client";
            this.TXT_prenom_client.Size = new System.Drawing.Size(215, 36);
            this.TXT_prenom_client.TabIndex = 10;
            // 
            // TXT_fixe
            // 
            this.TXT_fixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_fixe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TXT_fixe.Location = new System.Drawing.Point(365, 167);
            this.TXT_fixe.Multiline = true;
            this.TXT_fixe.Name = "TXT_fixe";
            this.TXT_fixe.Size = new System.Drawing.Size(190, 36);
            this.TXT_fixe.TabIndex = 11;
            // 
            // TXT_gsm
            // 
            this.TXT_gsm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_gsm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TXT_gsm.Location = new System.Drawing.Point(621, 167);
            this.TXT_gsm.Multiline = true;
            this.TXT_gsm.Name = "TXT_gsm";
            this.TXT_gsm.Size = new System.Drawing.Size(190, 36);
            this.TXT_gsm.TabIndex = 12;
            // 
            // TXT_mot_de_passe
            // 
            this.TXT_mot_de_passe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_mot_de_passe.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TXT_mot_de_passe.Location = new System.Drawing.Point(35, 252);
            this.TXT_mot_de_passe.Multiline = true;
            this.TXT_mot_de_passe.Name = "TXT_mot_de_passe";
            this.TXT_mot_de_passe.Size = new System.Drawing.Size(205, 69);
            this.TXT_mot_de_passe.TabIndex = 13;
            // 
            // TXT_probleme
            // 
            this.TXT_probleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_probleme.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TXT_probleme.Location = new System.Drawing.Point(19, 290);
            this.TXT_probleme.Multiline = true;
            this.TXT_probleme.Name = "TXT_probleme";
            this.TXT_probleme.Size = new System.Drawing.Size(204, 151);
            this.TXT_probleme.TabIndex = 14;
            // 
            // TXT_fournisseur
            // 
            this.TXT_fournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_fournisseur.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.TXT_fournisseur.Location = new System.Drawing.Point(291, 252);
            this.TXT_fournisseur.Multiline = true;
            this.TXT_fournisseur.Name = "TXT_fournisseur";
            this.TXT_fournisseur.Size = new System.Drawing.Size(186, 69);
            this.TXT_fournisseur.TabIndex = 15;
            // 
            // LBL_fournisseur
            // 
            this.LBL_fournisseur.AutoSize = true;
            this.LBL_fournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_fournisseur.Location = new System.Drawing.Point(285, 213);
            this.LBL_fournisseur.Name = "LBL_fournisseur";
            this.LBL_fournisseur.Size = new System.Drawing.Size(185, 36);
            this.LBL_fournisseur.TabIndex = 16;
            this.LBL_fournisseur.Text = "Fournisseur";
            // 
            // PB
            // 
            this.PB.Image = global::WindowsFormsApplication1.Properties.Resources.sudinfo;
            this.PB.Location = new System.Drawing.Point(0, 0);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(1024, 768);
            this.PB.TabIndex = 17;
            this.PB.TabStop = false;
            this.PB.Click += new System.EventHandler(this.PB_Click);
            // 
            // BT_ajouter
            // 
            this.BT_ajouter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BT_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BT_ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ajouter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BT_ajouter.Location = new System.Drawing.Point(254, 348);
            this.BT_ajouter.Name = "BT_ajouter";
            this.BT_ajouter.Size = new System.Drawing.Size(624, 105);
            this.BT_ajouter.TabIndex = 25;
            this.BT_ajouter.Text = "Ajouter";
            this.BT_ajouter.UseVisualStyleBackColor = false;
            this.BT_ajouter.Click += new System.EventHandler(this.BT_ajouter_Click);
            // 
            // Calendarr
            // 
            this.Calendarr.Location = new System.Drawing.Point(203, 0);
            this.Calendarr.Name = "Calendarr";
            this.Calendarr.TabIndex = 26;
            this.Calendarr.Visible = false;
            this.Calendarr.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendarr_DateChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBL_nom_client);
            this.panel1.Controls.Add(this.LBL_date);
            this.panel1.Controls.Add(this.TXT_date);
            this.panel1.Controls.Add(this.BT_ajouter);
            this.panel1.Controls.Add(this.TXT_nom_client);
            this.panel1.Controls.Add(this.TXT_probleme);
            this.panel1.Controls.Add(this.LBL_prenom_client);
            this.panel1.Controls.Add(this.TXT_prenom_client);
            this.panel1.Controls.Add(this.LBL_probleme);
            this.panel1.Controls.Add(this.LBL_fixe);
            this.panel1.Controls.Add(this.TXT_fixe);
            this.panel1.Controls.Add(this.TXT_gsm);
            this.panel1.Controls.Add(this.LBL_gsm);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(126, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 457);
            this.panel1.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 105);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBL_mot_de_passe);
            this.groupBox2.Controls.Add(this.TXT_mot_de_passe);
            this.groupBox2.Controls.Add(this.LBL_fournisseur);
            this.groupBox2.Controls.Add(this.TXT_fournisseur);
            this.groupBox2.Location = new System.Drawing.Point(330, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 327);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(4, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 202);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // Formulaire_entree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1006, 715);
            this.Controls.Add(this.Calendarr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 760);
            this.Name = "Formulaire_entree";
            this.Text = "Entree de Clients";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Formulaire_entree_FormClosed);
            this.Load += new System.EventHandler(this.Formulaire_entree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LBL_date;
        private System.Windows.Forms.Label LBL_nom_client;
        private System.Windows.Forms.Label LBL_prenom_client;
        private System.Windows.Forms.Label LBL_fixe;
        private System.Windows.Forms.Label LBL_gsm;
        private System.Windows.Forms.Label LBL_probleme;
        private System.Windows.Forms.Label LBL_mot_de_passe;
        private System.Windows.Forms.TextBox TXT_date;
        private System.Windows.Forms.TextBox TXT_nom_client;
        private System.Windows.Forms.TextBox TXT_prenom_client;
        private System.Windows.Forms.TextBox TXT_fixe;
        private System.Windows.Forms.TextBox TXT_gsm;
        private System.Windows.Forms.TextBox TXT_mot_de_passe;
        private System.Windows.Forms.TextBox TXT_probleme;
        private System.Windows.Forms.TextBox TXT_fournisseur;
        private System.Windows.Forms.Label LBL_fournisseur;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Button BT_ajouter;
        private System.Windows.Forms.MonthCalendar Calendarr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}