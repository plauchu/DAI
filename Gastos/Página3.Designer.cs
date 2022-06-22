namespace Gastos {
  partial class Página3 {
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
      this.label1 = new System.Windows.Forms.Label();
      this.cbClaves = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.cbMes = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtTotal = new System.Windows.Forms.TextBox();
      this.btnCons = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnRe
      // 
      this.btnRe.Location = new System.Drawing.Point(602, 265);
      this.btnRe.Name = "btnRe";
      this.btnRe.Size = new System.Drawing.Size(75, 23);
      this.btnRe.TabIndex = 1;
      this.btnRe.Text = "Regresar";
      this.btnRe.UseVisualStyleBackColor = true;
      this.btnRe.Click += new System.EventHandler(this.btnRe_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(60, 66);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(42, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Claves:";
      // 
      // cbClaves
      // 
      this.cbClaves.FormattingEnabled = true;
      this.cbClaves.Location = new System.Drawing.Point(167, 66);
      this.cbClaves.Name = "cbClaves";
      this.cbClaves.Size = new System.Drawing.Size(121, 21);
      this.cbClaves.TabIndex = 3;
      this.cbClaves.SelectedIndexChanged += new System.EventHandler(this.cbClaves_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(60, 136);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Mes(número):";
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
      this.cbMes.Location = new System.Drawing.Point(167, 136);
      this.cbMes.Name = "cbMes";
      this.cbMes.Size = new System.Drawing.Size(121, 21);
      this.cbMes.TabIndex = 7;
      this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(60, 222);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(34, 13);
      this.label2.TabIndex = 8;
      this.label2.Text = "Total:";
      // 
      // txtTotal
      // 
      this.txtTotal.Location = new System.Drawing.Point(167, 215);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.Size = new System.Drawing.Size(100, 20);
      this.txtTotal.TabIndex = 9;
      this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
      // 
      // btnCons
      // 
      this.btnCons.Location = new System.Drawing.Point(424, 126);
      this.btnCons.Name = "btnCons";
      this.btnCons.Size = new System.Drawing.Size(75, 23);
      this.btnCons.TabIndex = 10;
      this.btnCons.Text = "Consultar";
      this.btnCons.UseVisualStyleBackColor = true;
      this.btnCons.Click += new System.EventHandler(this.btnCons_Click);
      // 
      // Página3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnCons);
      this.Controls.Add(this.txtTotal);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.cbMes);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.cbClaves);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnRe);
      this.Name = "Página3";
      this.Text = "Página3";
      this.Load += new System.EventHandler(this.Página3_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.Button btnRe;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbClaves;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cbMes;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtTotal;
    private System.Windows.Forms.Button btnCons;
    }
  }