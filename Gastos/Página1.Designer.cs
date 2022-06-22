namespace Gastos {
  partial class Página1 {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose (bool disposing) {
      if (disposing && ( components != null )) {
        components.Dispose();
        }
      base.Dispose(disposing);
      }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent () {
      this.cbClaves = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtBoxMonto = new System.Windows.Forms.TextBox();
      this.cbMes = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btnAlta = new System.Windows.Forms.Button();
      this.btn2 = new System.Windows.Forms.Button();
      this.btn3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cbClaves
      // 
      this.cbClaves.FormattingEnabled = true;
      this.cbClaves.Location = new System.Drawing.Point(160, 57);
      this.cbClaves.Name = "cbClaves";
      this.cbClaves.Size = new System.Drawing.Size(121, 21);
      this.cbClaves.TabIndex = 0;
      this.cbClaves.SelectedIndexChanged += new System.EventHandler(this.cbClaves_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(69, 57);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(42, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Claves:";
      // 
      // txtBoxMonto
      // 
      this.txtBoxMonto.Location = new System.Drawing.Point(160, 116);
      this.txtBoxMonto.Name = "txtBoxMonto";
      this.txtBoxMonto.Size = new System.Drawing.Size(100, 20);
      this.txtBoxMonto.TabIndex = 2;
      this.txtBoxMonto.TextChanged += new System.EventHandler(this.txtBoxMonto_TextChanged);
      // 
      // cbMes
      // 
      this.cbMes.FormattingEnabled = true;
      this.cbMes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
      this.cbMes.Location = new System.Drawing.Point(160, 163);
      this.cbMes.Name = "cbMes";
      this.cbMes.Size = new System.Drawing.Size(121, 21);
      this.cbMes.TabIndex = 3;
      this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(69, 119);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Monto:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(69, 166);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Mes(número):";
      // 
      // btnAlta
      // 
      this.btnAlta.Location = new System.Drawing.Point(437, 119);
      this.btnAlta.Name = "btnAlta";
      this.btnAlta.Size = new System.Drawing.Size(75, 23);
      this.btnAlta.TabIndex = 6;
      this.btnAlta.Text = "alta";
      this.btnAlta.UseVisualStyleBackColor = true;
      this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
      // 
      // btn2
      // 
      this.btn2.Location = new System.Drawing.Point(385, 161);
      this.btn2.Name = "btn2";
      this.btn2.Size = new System.Drawing.Size(75, 23);
      this.btn2.TabIndex = 7;
      this.btn2.Text = "Página2";
      this.btn2.UseVisualStyleBackColor = true;
      this.btn2.Click += new System.EventHandler(this.btn2_Click);
      // 
      // btn3
      // 
      this.btn3.Location = new System.Drawing.Point(490, 161);
      this.btn3.Name = "btn3";
      this.btn3.Size = new System.Drawing.Size(75, 23);
      this.btn3.TabIndex = 8;
      this.btn3.Text = "Página3";
      this.btn3.UseVisualStyleBackColor = true;
      this.btn3.Click += new System.EventHandler(this.btn3_Click);
      // 
      // Página1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btn3);
      this.Controls.Add(this.btn2);
      this.Controls.Add(this.btnAlta);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cbMes);
      this.Controls.Add(this.txtBoxMonto);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cbClaves);
      this.Name = "Página1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.ComboBox cbClaves;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtBoxMonto;
    private System.Windows.Forms.ComboBox cbMes;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnAlta;
    private System.Windows.Forms.Button btn2;
    private System.Windows.Forms.Button btn3;
    }
  }

