namespace WindowsFormsApplication1
{
    partial class Archive
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archive));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.colonneetat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonne_numeroclient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonnedate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonnenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneprenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonnefixe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonnegsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonnefournisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneprobleme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonnemotdepasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneautres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIM_arch = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.supprDeffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1682, 655);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView2.ColumnHeadersHeight = 40;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colonneetat,
            this.colonne_numeroclient,
            this.colonnedate,
            this.colonnenom,
            this.colonneprenom,
            this.colonnefixe,
            this.colonnegsm,
            this.colonnefournisseur,
            this.colonneprobleme,
            this.colonnemotdepasse,
            this.colonneautres});
            this.dataGridView2.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 50;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1682, 655);
            this.dataGridView2.TabIndex = 12;
            // 
            // colonneetat
            // 
            this.colonneetat.HeaderText = "ETAT";
            this.colonneetat.Name = "colonneetat";
            this.colonneetat.ReadOnly = true;
            // 
            // colonne_numeroclient
            // 
            this.colonne_numeroclient.FillWeight = 200F;
            this.colonne_numeroclient.HeaderText = "N°CLIENT";
            this.colonne_numeroclient.Name = "colonne_numeroclient";
            this.colonne_numeroclient.ReadOnly = true;
            this.colonne_numeroclient.Width = 150;
            // 
            // colonnedate
            // 
            this.colonnedate.FillWeight = 200F;
            this.colonnedate.HeaderText = "DATE";
            this.colonnedate.Name = "colonnedate";
            this.colonnedate.ReadOnly = true;
            this.colonnedate.Width = 200;
            // 
            // colonnenom
            // 
            this.colonnenom.FillWeight = 200F;
            this.colonnenom.HeaderText = "NOM";
            this.colonnenom.Name = "colonnenom";
            this.colonnenom.ReadOnly = true;
            this.colonnenom.Width = 200;
            // 
            // colonneprenom
            // 
            this.colonneprenom.FillWeight = 200F;
            this.colonneprenom.HeaderText = "PRENOM";
            this.colonneprenom.Name = "colonneprenom";
            this.colonneprenom.ReadOnly = true;
            this.colonneprenom.Width = 200;
            // 
            // colonnefixe
            // 
            this.colonnefixe.FillWeight = 200F;
            this.colonnefixe.HeaderText = "FIXE";
            this.colonnefixe.Name = "colonnefixe";
            this.colonnefixe.ReadOnly = true;
            this.colonnefixe.Width = 200;
            // 
            // colonnegsm
            // 
            this.colonnegsm.FillWeight = 200F;
            this.colonnegsm.HeaderText = "GSM";
            this.colonnegsm.Name = "colonnegsm";
            this.colonnegsm.ReadOnly = true;
            this.colonnegsm.Width = 200;
            // 
            // colonnefournisseur
            // 
            this.colonnefournisseur.FillWeight = 200F;
            this.colonnefournisseur.HeaderText = "FOURNISSEUR";
            this.colonnefournisseur.Name = "colonnefournisseur";
            this.colonnefournisseur.ReadOnly = true;
            this.colonnefournisseur.Width = 200;
            // 
            // colonneprobleme
            // 
            this.colonneprobleme.FillWeight = 200F;
            this.colonneprobleme.HeaderText = "PROBLEME";
            this.colonneprobleme.Name = "colonneprobleme";
            this.colonneprobleme.ReadOnly = true;
            this.colonneprobleme.Width = 200;
            // 
            // colonnemotdepasse
            // 
            this.colonnemotdepasse.FillWeight = 400F;
            this.colonnemotdepasse.HeaderText = "MOT DE PASSE";
            this.colonnemotdepasse.Name = "colonnemotdepasse";
            this.colonnemotdepasse.ReadOnly = true;
            this.colonnemotdepasse.Width = 200;
            // 
            // colonneautres
            // 
            this.colonneautres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colonneautres.HeaderText = "MATERIAUX_CHANGES_AUTRES";
            this.colonneautres.Name = "colonneautres";
            this.colonneautres.ReadOnly = true;
            this.colonneautres.Width = 251;
            // 
            // TIM_arch
            // 
            this.TIM_arch.Interval = 500;
            this.TIM_arch.Tick += new System.EventHandler(this.TIM_arch_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supprDeffToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 28);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // supprDeffToolStripMenuItem
            // 
            this.supprDeffToolStripMenuItem.Name = "supprDeffToolStripMenuItem";
            this.supprDeffToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.supprDeffToolStripMenuItem.Text = "Suppr. deff.";
            this.supprDeffToolStripMenuItem.Click += new System.EventHandler(this.supprDeffToolStripMenuItem_Click);
            // 
            // Archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 655);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Archive";
            this.Text = ".::ARCHIVES::.";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Archive_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Archive_FormClosed);
            this.Load += new System.EventHandler(this.Archive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Timer TIM_arch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneetat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonne_numeroclient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonnedate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonnenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneprenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonnefixe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonnegsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonnefournisseur;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneprobleme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonnemotdepasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneautres;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supprDeffToolStripMenuItem;
    }
}