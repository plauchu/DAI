namespace Préstamos {
  partial class FrmConsClientes {
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
      this.cboCliente = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnMostar = new System.Windows.Forms.Button();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.grdCliente = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // cboCliente
      // 
      this.cboCliente.FormattingEnabled = true;
      this.cboCliente.Location = new System.Drawing.Point(243, 35);
      this.cboCliente.Name = "cboCliente";
      this.cboCliente.Size = new System.Drawing.Size(192, 21);
      this.cboCliente.TabIndex = 0;
      this.cboCliente.Visible = false;
      this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.CboCliente_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(101, 35);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Clientes:";
      this.label1.Visible = false;
      // 
      // btnMostar
      // 
      this.btnMostar.Location = new System.Drawing.Point(519, 16);
      this.btnMostar.Name = "btnMostar";
      this.btnMostar.Size = new System.Drawing.Size(170, 57);
      this.btnMostar.TabIndex = 2;
      this.btnMostar.Text = "Mostar datos";
      this.btnMostar.UseVisualStyleBackColor = true;
      this.btnMostar.Click += new System.EventHandler(this.BtnMostar_Click);
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(104, 133);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(585, 150);
      this.dataGridView1.TabIndex = 3;
      this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
      // 
      // grdCliente
      // 
      this.grdCliente.AutoSize = true;
      this.grdCliente.Location = new System.Drawing.Point(104, 95);
      this.grdCliente.Name = "grdCliente";
      this.grdCliente.Size = new System.Drawing.Size(89, 13);
      this.grdCliente.TabIndex = 4;
      this.grdCliente.Text = "Datos del cliente:";
      // 
      // FrmConsClientes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.grdCliente);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.btnMostar);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cboCliente);
      this.Name = "FrmConsClientes";
      this.Text = "Consulta de la información de clientes";
      this.Load += new System.EventHandler(this.FrmConsClientes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox cboCliente;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnMostar;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label grdCliente;
  }
}