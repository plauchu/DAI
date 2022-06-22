namespace Gastos {
  partial class Página2 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose (bool disposing) {
      if (disposing && ( components != null )) {
        components.Dispose();
        }
      base.Dispose(disposing);
      }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent () {
      this.btnRe = new System.Windows.Forms.Button();
      this.txtGasto = new System.Windows.Forms.TextBox();
      this.cboCat = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnAlta = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnRe
      // 
      this.btnRe.Location = new System.Drawing.Point(551, 251);
      this.btnRe.Name = "btnRe";
      this.btnRe.Size = new System.Drawing.Size(75, 23);
      this.btnRe.TabIndex = 0;
      this.btnRe.Text = "Regresar";
      this.btnRe.UseVisualStyleBackColor = true;
      this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
      // 
      // txtGasto
      // 
      this.txtGasto.Location = new System.Drawing.Point(145, 55);
      this.txtGasto.Name = "txtGasto";
      this.txtGasto.Size = new System.Drawing.Size(100, 20);
      this.txtGasto.TabIndex = 1;
      this.txtGasto.TextChanged += new System.EventHandler(this.txtGasto_TextChanged);
      // 
      // cboCat
      // 
      this.cboCat.FormattingEnabled = true;
      this.cboCat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
      this.cboCat.Location = new System.Drawing.Point(145, 125);
      this.cboCat.Name = "cboCat";
      this.cboCat.Size = new System.Drawing.Size(121, 21);
      this.cboCat.TabIndex = 2;
      this.cboCat.SelectedIndexChanged += new System.EventHandler(this.cboCat_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(64, 58);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Gasto:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(64, 133);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Categoría:";
      // 
      // btnAlta
      // 
      this.btnAlta.Location = new System.Drawing.Point(371, 85);
      this.btnAlta.Name = "btnAlta";
      this.btnAlta.Size = new System.Drawing.Size(75, 23);
      this.btnAlta.TabIndex = 5;
      this.btnAlta.Text = "alta";
      this.btnAlta.UseVisualStyleBackColor = true;
      this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
      // 
      // Página2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnAlta);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cboCat);
      this.Controls.Add(this.txtGasto);
      this.Controls.Add(this.btnRe);
      this.Name = "Página2";
      this.Text = "página2";
      this.Load += new System.EventHandler(this.Página2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.Button btnRe;
    private System.Windows.Forms.TextBox txtGasto;
    private System.Windows.Forms.ComboBox cboCat;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAlta;
    }
  }