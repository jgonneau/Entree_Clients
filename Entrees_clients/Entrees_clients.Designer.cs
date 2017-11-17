namespace WindowsFormsApplication1
{
    partial class FORM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.MATERIAUX_CHANGES_AUTRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.archiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finDeTâchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Entrees_clients = new System.Windows.Forms.NotifyIcon(this.components);
            this.bt_ajout_entree = new System.Windows.Forms.Button();
            this.bt_retrait_entree = new System.Windows.Forms.Button();
            this.bt_exit = new System.Windows.Forms.Button();
            this.bt_a_propos = new System.Windows.Forms.Button();
            this.bt_modification = new System.Windows.Forms.Button();
            this.TIM = new System.Windows.Forms.Timer(this.components);
            this.TIK = new System.Windows.Forms.Timer(this.components);
            this.bt_archives = new System.Windows.Forms.Button();
            this.dgv_arch = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonneautres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arch)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(1000, 50);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(0, 50);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 50);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.MATERIAUX_CHANGES_AUTRES});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGreen;
            this.dataGridView1.Location = new System.Drawing.Point(0, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 360);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            // MATERIAUX_CHANGES_AUTRES
            // 
            this.MATERIAUX_CHANGES_AUTRES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MATERIAUX_CHANGES_AUTRES.HeaderText = "MATERIAUX_CHANGES_AUTRES";
            this.MATERIAUX_CHANGES_AUTRES.Name = "MATERIAUX_CHANGES_AUTRES";
            this.MATERIAUX_CHANGES_AUTRES.ReadOnly = true;
            this.MATERIAUX_CHANGES_AUTRES.Width = 251;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archiverToolStripMenuItem,
            this.finDeTâchesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(165, 52);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // archiverToolStripMenuItem
            // 
            this.archiverToolStripMenuItem.Name = "archiverToolStripMenuItem";
            this.archiverToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.archiverToolStripMenuItem.Text = "Archiver";
            this.archiverToolStripMenuItem.Click += new System.EventHandler(this.archiverToolStripMenuItem_Click);
            this.archiverToolStripMenuItem.MouseHover += new System.EventHandler(this.archiverToolStripMenuItem_MouseHover);
            // 
            // finDeTâchesToolStripMenuItem
            // 
            this.finDeTâchesToolStripMenuItem.Name = "finDeTâchesToolStripMenuItem";
            this.finDeTâchesToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.finDeTâchesToolStripMenuItem.Text = "Fin de tâches";
            this.finDeTâchesToolStripMenuItem.Click += new System.EventHandler(this.finDeTâchesToolStripMenuItem_Click);
            this.finDeTâchesToolStripMenuItem.MouseHover += new System.EventHandler(this.finDeTâchesToolStripMenuItem_MouseHover);
            // 
            // Entrees_clients
            // 
            this.Entrees_clients.ContextMenuStrip = this.contextMenuStrip2;
            this.Entrees_clients.Icon = ((System.Drawing.Icon)(resources.GetObject("Entrees_clients.Icon")));
            this.Entrees_clients.Text = "Entrees_clients (SUDINFO)";
            this.Entrees_clients.Visible = true;
            this.Entrees_clients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // bt_ajout_entree
            // 
            this.bt_ajout_entree.BackColor = System.Drawing.Color.Transparent;
            this.bt_ajout_entree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ajout_entree.Location = new System.Drawing.Point(0, 0);
            this.bt_ajout_entree.Name = "bt_ajout_entree";
            this.bt_ajout_entree.Size = new System.Drawing.Size(148, 50);
            this.bt_ajout_entree.TabIndex = 12;
            this.bt_ajout_entree.Text = "_Ajout Client";
            this.bt_ajout_entree.UseVisualStyleBackColor = false;
            this.bt_ajout_entree.Click += new System.EventHandler(this.bt_ajout_entree_Click);
            // 
            // bt_retrait_entree
            // 
            this.bt_retrait_entree.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_retrait_entree.Location = new System.Drawing.Point(154, 0);
            this.bt_retrait_entree.Name = "bt_retrait_entree";
            this.bt_retrait_entree.Size = new System.Drawing.Size(153, 50);
            this.bt_retrait_entree.TabIndex = 13;
            this.bt_retrait_entree.Text = "_Retrait Client";
            this.bt_retrait_entree.UseVisualStyleBackColor = true;
            this.bt_retrait_entree.Click += new System.EventHandler(this.bt_retrait_entree_Click);
            // 
            // bt_exit
            // 
            this.bt_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_exit.Location = new System.Drawing.Point(867, 0);
            this.bt_exit.Name = "bt_exit";
            this.bt_exit.Size = new System.Drawing.Size(133, 50);
            this.bt_exit.TabIndex = 14;
            this.bt_exit.Text = "_Exit";
            this.bt_exit.UseVisualStyleBackColor = true;
            this.bt_exit.Click += new System.EventHandler(this.bt_exit_Click);
            // 
            // bt_a_propos
            // 
            this.bt_a_propos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_a_propos.Location = new System.Drawing.Point(699, 0);
            this.bt_a_propos.Name = "bt_a_propos";
            this.bt_a_propos.Size = new System.Drawing.Size(162, 50);
            this.bt_a_propos.TabIndex = 15;
            this.bt_a_propos.Text = "_A propos";
            this.bt_a_propos.UseVisualStyleBackColor = true;
            this.bt_a_propos.Click += new System.EventHandler(this.bt_a_propos_Click);
            // 
            // bt_modification
            // 
            this.bt_modification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_modification.Location = new System.Drawing.Point(313, 0);
            this.bt_modification.Name = "bt_modification";
            this.bt_modification.Size = new System.Drawing.Size(191, 50);
            this.bt_modification.TabIndex = 16;
            this.bt_modification.Text = "_Modifications";
            this.bt_modification.UseVisualStyleBackColor = true;
            this.bt_modification.Click += new System.EventHandler(this.bt_modification_Click);
            // 
            // TIM
            // 
            this.TIM.Tick += new System.EventHandler(this.TIM_Tick);
            // 
            // TIK
            // 
            this.TIK.Tick += new System.EventHandler(this.TIK_Tick);
            // 
            // bt_archives
            // 
            this.bt_archives.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_archives.Location = new System.Drawing.Point(510, 0);
            this.bt_archives.Name = "bt_archives";
            this.bt_archives.Size = new System.Drawing.Size(183, 50);
            this.bt_archives.TabIndex = 17;
            this.bt_archives.Text = "_Archives";
            this.bt_archives.UseVisualStyleBackColor = true;
            this.bt_archives.Click += new System.EventHandler(this.bt_archives_Click);
            // 
            // dgv_arch
            // 
            this.dgv_arch.AllowUserToAddRows = false;
            this.dgv_arch.AllowUserToDeleteRows = false;
            this.dgv_arch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_arch.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgv_arch.ColumnHeadersHeight = 40;
            this.dgv_arch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_arch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.colonneautres});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_arch.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_arch.Location = new System.Drawing.Point(30, 150);
            this.dgv_arch.Margin = new System.Windows.Forms.Padding(3, 100, 3, 3);
            this.dgv_arch.MultiSelect = false;
            this.dgv_arch.Name = "dgv_arch";
            this.dgv_arch.ReadOnly = true;
            this.dgv_arch.RowHeadersWidth = 50;
            this.dgv_arch.RowTemplate.Height = 24;
            this.dgv_arch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_arch.Size = new System.Drawing.Size(849, 322);
            this.dgv_arch.TabIndex = 18;
            this.dgv_arch.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ETAT";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 200F;
            this.dataGridViewTextBoxColumn2.HeaderText = "N°CLIENT";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 200F;
            this.dataGridViewTextBoxColumn4.HeaderText = "NOM";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 200F;
            this.dataGridViewTextBoxColumn5.HeaderText = "PRENOM";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.FillWeight = 200F;
            this.dataGridViewTextBoxColumn6.HeaderText = "FIXE";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 200F;
            this.dataGridViewTextBoxColumn7.HeaderText = "GSM";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 200F;
            this.dataGridViewTextBoxColumn8.HeaderText = "FOURNISSEUR";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 200;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.FillWeight = 200F;
            this.dataGridViewTextBoxColumn9.HeaderText = "PROBLEME";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 200;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.FillWeight = 400F;
            this.dataGridViewTextBoxColumn10.HeaderText = "MOT DE PASSE";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 200;
            // 
            // colonneautres
            // 
            this.colonneautres.HeaderText = "MATERIAUX_CHANGES_AUTRES";
            this.colonneautres.Name = "colonneautres";
            this.colonneautres.ReadOnly = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(103, 28);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1049, 410);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.dgv_arch);
            this.Controls.Add(this.bt_archives);
            this.Controls.Add(this.bt_modification);
            this.Controls.Add(this.bt_retrait_entree);
            this.Controls.Add(this.bt_ajout_entree);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_a_propos);
            this.Controls.Add(this.bt_exit);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FORM";
            this.Text = "Entrees des Clients (SUD INFORMATIQUE)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FORM_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.FORM_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_arch)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NotifyIcon Entrees_clients;
        private System.Windows.Forms.Button bt_ajout_entree;
        private System.Windows.Forms.Button bt_retrait_entree;
        private System.Windows.Forms.Button bt_exit;
        private System.Windows.Forms.Button bt_a_propos;
        private System.Windows.Forms.Button bt_modification;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archiverToolStripMenuItem;
        private System.Windows.Forms.Timer TIM;
        private System.Windows.Forms.Timer TIK;
        private System.Windows.Forms.Button bt_archives;
        private System.Windows.Forms.ToolStripMenuItem finDeTâchesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_arch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonneautres;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn MATERIAUX_CHANGES_AUTRES;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

