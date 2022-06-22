namespace Préstamos {
  partial class FrmMenúGeneral {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenúGeneral));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAltaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.préstamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAltaPres = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsPres = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAltaPag = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuConsPag = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.préstamosToolStripMenuItem,
            this.pagosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MnuSalir";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStrip1_ItemClicked);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SalirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // SalirToolStripMenuItem
            // 
            this.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem";
            this.SalirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.SalirToolStripMenuItem.Text = "Salir";
            this.SalirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAltaClientes,
            this.MnuConsClientes});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // MnuAltaClientes
            // 
            this.MnuAltaClientes.Enabled = false;
            this.MnuAltaClientes.Name = "MnuAltaClientes";
            this.MnuAltaClientes.Size = new System.Drawing.Size(180, 22);
            this.MnuAltaClientes.Text = "Alta";
            this.MnuAltaClientes.Click += new System.EventHandler(this.MnuAltaClientes_Click);
            // 
            // MnuConsClientes
            // 
            this.MnuConsClientes.Name = "MnuConsClientes";
            this.MnuConsClientes.Size = new System.Drawing.Size(180, 22);
            this.MnuConsClientes.Text = "Consulta";
            this.MnuConsClientes.Click += new System.EventHandler(this.MnuConsClientes_Click);
            // 
            // préstamosToolStripMenuItem
            // 
            this.préstamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAltaPres,
            this.MnuConsPres});
            this.préstamosToolStripMenuItem.Name = "préstamosToolStripMenuItem";
            this.préstamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.préstamosToolStripMenuItem.Text = "Préstamos";
            // 
            // MnuAltaPres
            // 
            this.MnuAltaPres.Enabled = false;
            this.MnuAltaPres.Name = "MnuAltaPres";
            this.MnuAltaPres.Size = new System.Drawing.Size(180, 22);
            this.MnuAltaPres.Text = "Alta";
            this.MnuAltaPres.Click += new System.EventHandler(this.MnuAltaPres_Click);
            // 
            // MnuConsPres
            // 
            this.MnuConsPres.Name = "MnuConsPres";
            this.MnuConsPres.Size = new System.Drawing.Size(180, 22);
            this.MnuConsPres.Text = "Consulta";
            this.MnuConsPres.Click += new System.EventHandler(this.MnuConsPres_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAltaPag,
            this.MnuConsPag});
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.pagosToolStripMenuItem.Text = "Pagos";
            // 
            // MnuAltaPag
            // 
            this.MnuAltaPag.Enabled = false;
            this.MnuAltaPag.Name = "MnuAltaPag";
            this.MnuAltaPag.Size = new System.Drawing.Size(180, 22);
            this.MnuAltaPag.Text = "Alta";
            this.MnuAltaPag.Click += new System.EventHandler(this.MnuAltaPag_Click);
            // 
            // MnuConsPag
            // 
            this.MnuConsPag.Name = "MnuConsPag";
            this.MnuConsPag.Size = new System.Drawing.Size(180, 22);
            this.MnuConsPag.Text = "Consulta";
            this.MnuConsPag.Click += new System.EventHandler(this.MnuConsPag_Click);
            // 
            // FrmMenúGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenúGeneral";
            this.Text = "Menú General";
            this.Load += new System.EventHandler(this.FrmMenúGeneral_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem SalirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuAltaClientes;
    private System.Windows.Forms.ToolStripMenuItem MnuConsClientes;
    private System.Windows.Forms.ToolStripMenuItem préstamosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuAltaPres;
    private System.Windows.Forms.ToolStripMenuItem MnuConsPres;
    private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem MnuAltaPag;
    private System.Windows.Forms.ToolStripMenuItem MnuConsPag;
  }
}