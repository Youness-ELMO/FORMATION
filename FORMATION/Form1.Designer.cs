namespace FORMATION
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionÉtablissementScolaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.academieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.délégationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lycéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionÉtablissementScolaireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionÉtablissementScolaireToolStripMenuItem
            // 
            this.gestionÉtablissementScolaireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.academieToolStripMenuItem,
            this.délégationToolStripMenuItem,
            this.lycéeToolStripMenuItem,
            this.professeurToolStripMenuItem});
            this.gestionÉtablissementScolaireToolStripMenuItem.Name = "gestionÉtablissementScolaireToolStripMenuItem";
            this.gestionÉtablissementScolaireToolStripMenuItem.Size = new System.Drawing.Size(179, 20);
            this.gestionÉtablissementScolaireToolStripMenuItem.Text = "Gestion établissement Scolaire";
            // 
            // academieToolStripMenuItem
            // 
            this.academieToolStripMenuItem.Name = "academieToolStripMenuItem";
            this.academieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.academieToolStripMenuItem.Text = "Academie ";
            this.academieToolStripMenuItem.Click += new System.EventHandler(this.academieToolStripMenuItem_Click);
            // 
            // délégationToolStripMenuItem
            // 
            this.délégationToolStripMenuItem.Name = "délégationToolStripMenuItem";
            this.délégationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.délégationToolStripMenuItem.Text = "Délégation";
            // 
            // lycéeToolStripMenuItem
            // 
            this.lycéeToolStripMenuItem.Name = "lycéeToolStripMenuItem";
            this.lycéeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lycéeToolStripMenuItem.Text = "Lycée";
            // 
            // professeurToolStripMenuItem
            // 
            this.professeurToolStripMenuItem.Name = "professeurToolStripMenuItem";
            this.professeurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.professeurToolStripMenuItem.Text = "Professeur";
            this.professeurToolStripMenuItem.Click += new System.EventHandler(this.professeurToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionÉtablissementScolaireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem academieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem délégationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lycéeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professeurToolStripMenuItem;
    }
}

