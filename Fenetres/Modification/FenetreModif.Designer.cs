namespace dotnet.Fenetres.Modification
{
    partial class FenetreModif
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAnnuler = new System.Windows.Forms.Button();
            this.bValider = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lErreur = new System.Windows.Forms.Label();
            this.gBAffElement = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.gBAffElement.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAnnuler
            // 
            this.bAnnuler.Location = new System.Drawing.Point(42, 171);
            this.bAnnuler.Name = "bAnnuler";
            this.bAnnuler.Size = new System.Drawing.Size(75, 23);
            this.bAnnuler.TabIndex = 10;
            this.bAnnuler.Text = "Annuler";
            this.bAnnuler.UseVisualStyleBackColor = true;
            // 
            // bValider
            // 
            this.bValider.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bValider.Location = new System.Drawing.Point(411, 171);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(75, 23);
            this.bValider.TabIndex = 9;
            this.bValider.Text = "Valider";
            this.bValider.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lErreur);
            this.panel1.Controls.Add(this.gBAffElement);
            this.panel1.Controls.Add(this.bValider);
            this.panel1.Controls.Add(this.bAnnuler);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 216);
            this.panel1.TabIndex = 12;
            // 
            // lErreur
            // 
            this.lErreur.AutoSize = true;
            this.lErreur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErreur.ForeColor = System.Drawing.Color.Red;
            this.lErreur.Location = new System.Drawing.Point(405, 197);
            this.lErreur.Name = "lErreur";
            this.lErreur.Size = new System.Drawing.Size(88, 13);
            this.lErreur.TabIndex = 15;
            this.lErreur.Text = "Erreur, réessayez";
            this.lErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lErreur.Visible = false;
            // 
            // gBAffElement
            // 
            this.gBAffElement.Controls.Add(this.panel2);
            this.gBAffElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBAffElement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gBAffElement.Location = new System.Drawing.Point(36, 15);
            this.gBAffElement.Name = "gBAffElement";
            this.gBAffElement.Size = new System.Drawing.Size(457, 146);
            this.gBAffElement.TabIndex = 13;
            this.gBAffElement.TabStop = false;
            this.gBAffElement.Text = "Appliquez vos modifications : ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(185)))), ((int)(((byte)(213)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(6, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(445, 123);
            this.panel2.TabIndex = 0;
            // 
            // FenetreModif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 240);
            this.Controls.Add(this.panel1);
            this.Name = "FenetreModif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fenêtre de modifications";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBAffElement.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button bAnnuler;
        protected System.Windows.Forms.Button bValider;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.GroupBox gBAffElement;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label lErreur;
    }
}