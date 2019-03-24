namespace dotnet.UserControler.Affichage
{
    partial class UC_Element
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Element));
            this.gBAffElement = new System.Windows.Forms.GroupBox();
            this.panel = new System.Windows.Forms.Panel();
            this.pBModifier = new System.Windows.Forms.PictureBox();
            this.pBSupprimer = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gBAffElement.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).BeginInit();
            this.SuspendLayout();
            // 
            // gBAffElement
            // 
            this.gBAffElement.Controls.Add(this.panel);
            this.gBAffElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBAffElement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBAffElement.Location = new System.Drawing.Point(3, 0);
            this.gBAffElement.Name = "gBAffElement";
            this.gBAffElement.Size = new System.Drawing.Size(951, 66);
            this.gBAffElement.TabIndex = 0;
            this.gBAffElement.TabStop = false;
            this.gBAffElement.Text = "TitreElement";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.pBModifier);
            this.panel.Controls.Add(this.pBSupprimer);
            this.panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel.Location = new System.Drawing.Point(6, 17);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(938, 42);
            this.panel.TabIndex = 0;
            // 
            // pBModifier
            // 
            this.pBModifier.Image = ((System.Drawing.Image)(resources.GetObject("pBModifier.Image")));
            this.pBModifier.InitialImage = null;
            this.pBModifier.Location = new System.Drawing.Point(857, 3);
            this.pBModifier.Name = "pBModifier";
            this.pBModifier.Size = new System.Drawing.Size(37, 34);
            this.pBModifier.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBModifier.TabIndex = 1;
            this.pBModifier.TabStop = false;
            // 
            // pBSupprimer
            // 
            this.pBSupprimer.Image = ((System.Drawing.Image)(resources.GetObject("pBSupprimer.Image")));
            this.pBSupprimer.InitialImage = null;
            this.pBSupprimer.Location = new System.Drawing.Point(900, 3);
            this.pBSupprimer.Name = "pBSupprimer";
            this.pBSupprimer.Size = new System.Drawing.Size(33, 34);
            this.pBSupprimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBSupprimer.TabIndex = 0;
            this.pBSupprimer.TabStop = false;
            // 
            // UC_Element
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gBAffElement);
            this.Name = "UC_Element";
            this.Size = new System.Drawing.Size(955, 70);
            this.Load += new System.EventHandler(this.UC_Element_Load);
            this.gBAffElement.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSupprimer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox gBAffElement;
        protected System.Windows.Forms.Panel panel;
        protected System.Windows.Forms.PictureBox pBModifier;
        protected System.Windows.Forms.PictureBox pBSupprimer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
