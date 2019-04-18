namespace dotnet.Fenetres.Suppression
{
    partial class FenetreSupprimerCategorie
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
            this.SuspendLayout();
            // 
            // bValider
            // 
            this.bValider.Click += new System.EventHandler(this.bValider_Click);
            // 
            // bAnnuler
            // 
            this.bAnnuler.Click += new System.EventHandler(this.bAnnuler_Click);
            // 
            // FenetreSupprimerCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 129);
            this.Name = "FenetreSupprimerCategorie";
            this.Text = "Fenêtre de suppression d\'une catégorie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}