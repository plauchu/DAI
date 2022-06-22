namespace Préstamos {
  partial class FrmIngreso {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngreso));
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtUsuario = new System.Windows.Forms.TextBox();
      this.txtContra = new System.Windows.Forms.TextBox();
      this.btnIngresar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(86, 105);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Usuario:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(86, 203);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(64, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Contraseña:";
      // 
      // txtUsuario
      // 
      this.txtUsuario.Location = new System.Drawing.Point(238, 98);
      this.txtUsuario.Name = "txtUsuario";
      this.txtUsuario.Size = new System.Drawing.Size(173, 20);
      this.txtUsuario.TabIndex = 2;
      // 
      // txtContra
      // 
      this.txtContra.Location = new System.Drawing.Point(238, 203);
      this.txtContra.Name = "txtContra";
      this.txtContra.PasswordChar = '*';
      this.txtContra.Size = new System.Drawing.Size(173, 20);
      this.txtContra.TabIndex = 3;
      // 
      // btnIngresar
      // 
      this.btnIngresar.Location = new System.Drawing.Point(532, 105);
      this.btnIngresar.Name = "btnIngresar";
      this.btnIngresar.Size = new System.Drawing.Size(191, 121);
      this.btnIngresar.TabIndex = 4;
      this.btnIngresar.Text = "Ingresar";
      this.btnIngresar.UseVisualStyleBackColor = true;
      this.btnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
      // 
      // FrmIngreso
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnIngresar);
      this.Controls.Add(this.txtContra);
      this.Controls.Add(this.txtUsuario);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Name = "FrmIngreso";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "FrmIngreso";
      this.Load += new System.EventHandler(this.FrmIngreso_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtUsuario;
    private System.Windows.Forms.TextBox txtContra;
    private System.Windows.Forms.Button btnIngresar;
  }
}