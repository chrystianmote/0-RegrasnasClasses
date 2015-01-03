namespace Revisao_11._06
{
    partial class formPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.MenuSup = new System.Windows.Forms.MenuStrip();
            this.msCalcular = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSup.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuSup
            // 
            this.MenuSup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msCalcular,
            this.listarToolStripMenuItem,
            this.sobreToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.MenuSup.Location = new System.Drawing.Point(0, 0);
            this.MenuSup.Name = "MenuSup";
            this.MenuSup.Size = new System.Drawing.Size(338, 24);
            this.MenuSup.TabIndex = 0;
            this.MenuSup.Text = "menuStrip1";
            // 
            // msCalcular
            // 
            this.msCalcular.Name = "msCalcular";
            this.msCalcular.Size = new System.Drawing.Size(57, 20);
            this.msCalcular.Text = "Calcular";
            this.msCalcular.Click += new System.EventHandler(this.msCalcular_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Revisao_11._06.Properties.Resources.auxiliar2;
            this.ClientSize = new System.Drawing.Size(338, 296);
            this.Controls.Add(this.MenuSup);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuSup;
            this.Name = "formPrincipal";
            this.Text = "Calculador de Salários";
            this.MenuSup.ResumeLayout(false);
            this.MenuSup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuSup;
        private System.Windows.Forms.ToolStripMenuItem msCalcular;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;

    }
}

