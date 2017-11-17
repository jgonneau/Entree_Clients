namespace WindowsFormsApplication1
{
    partial class Apropos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Apropos));
            this.ap_lbl = new System.Windows.Forms.Label();
            this.ap_lbl2 = new System.Windows.Forms.Label();
            this.ap_lbl3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // ap_lbl
            // 
            this.ap_lbl.AutoSize = true;
            this.ap_lbl.Location = new System.Drawing.Point(74, 29);
            this.ap_lbl.Name = "ap_lbl";
            this.ap_lbl.Size = new System.Drawing.Size(238, 17);
            this.ap_lbl.TabIndex = 0;
            this.ap_lbl.Text = "Developpeur : GONNEAU Jean Paul";
            // 
            // ap_lbl2
            // 
            this.ap_lbl2.AutoSize = true;
            this.ap_lbl2.Location = new System.Drawing.Point(74, 74);
            this.ap_lbl2.Name = "ap_lbl2";
            this.ap_lbl2.Size = new System.Drawing.Size(292, 17);
            this.ap_lbl2.TabIndex = 1;
            this.ap_lbl2.Text = "Adresse Mail : gonneau.jeanpaul@gmail.com";
            // 
            // ap_lbl3
            // 
            this.ap_lbl3.AutoSize = true;
            this.ap_lbl3.Location = new System.Drawing.Point(74, 118);
            this.ap_lbl3.Name = "ap_lbl3";
            this.ap_lbl3.Size = new System.Drawing.Size(100, 17);
            this.ap_lbl3.TabIndex = 2;
            this.ap_lbl3.Text = "Version : 1.0.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(50, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 141);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Apropos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 178);
            this.Controls.Add(this.ap_lbl3);
            this.Controls.Add(this.ap_lbl2);
            this.Controls.Add(this.ap_lbl);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Apropos";
            this.Text = "A propos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Apropos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ap_lbl;
        private System.Windows.Forms.Label ap_lbl2;
        private System.Windows.Forms.Label ap_lbl3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}