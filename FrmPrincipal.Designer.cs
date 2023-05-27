namespace BibliotecaSisInf
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarMaterialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosDevolucionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarMaterialToolStripMenuItem,
            this.gestionarMaterialToolStripMenuItem,
            this.gestionarUsuarioToolStripMenuItem,
            this.prestamosDevolucionToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1030, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buscarMaterialToolStripMenuItem
            // 
            this.buscarMaterialToolStripMenuItem.Name = "buscarMaterialToolStripMenuItem";
            this.buscarMaterialToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.buscarMaterialToolStripMenuItem.Text = "Buscar Material";
            this.buscarMaterialToolStripMenuItem.Click += new System.EventHandler(this.buscarMaterialToolStripMenuItem_Click);
            // 
            // gestionarMaterialToolStripMenuItem
            // 
            this.gestionarMaterialToolStripMenuItem.Name = "gestionarMaterialToolStripMenuItem";
            this.gestionarMaterialToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.gestionarMaterialToolStripMenuItem.Text = "Gestionar Material";
            // 
            // gestionarUsuarioToolStripMenuItem
            // 
            this.gestionarUsuarioToolStripMenuItem.Name = "gestionarUsuarioToolStripMenuItem";
            this.gestionarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.gestionarUsuarioToolStripMenuItem.Text = "Gestionar Usuario";
            // 
            // prestamosDevolucionToolStripMenuItem
            // 
            this.prestamosDevolucionToolStripMenuItem.Name = "prestamosDevolucionToolStripMenuItem";
            this.prestamosDevolucionToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.prestamosDevolucionToolStripMenuItem.Text = "Prestamos / Devolucion";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1030, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(158, 20);
            this.toolStripStatusLabel1.Text = "Biblioteca SIS-INF v1.0";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 657);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowInTaskbar = false;
            this.Text = "FrmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarMaterialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosDevolucionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}