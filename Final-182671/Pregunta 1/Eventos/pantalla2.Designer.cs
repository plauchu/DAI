namespace Eventos {
  partial class pantalla2 {
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
      this.cboAl = new System.Windows.Forms.ComboBox();
      this.cboEv = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnAlta = new System.Windows.Forms.Button();
      this.btnReg = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // cboAl
      // 
      this.cboAl.FormattingEnabled = true;
      this.cboAl.Location = new System.Drawing.Point(309, 99);
      this.cboAl.Name = "cboAl";
      this.cboAl.Size = new System.Drawing.Size(121, 21);
      this.cboAl.TabIndex = 0;
      this.cboAl.SelectedIndexChanged += new System.EventHandler(this.CboAl_SelectedIndexChanged);
      // 
      // cboEv
      // 
      this.cboEv.FormattingEnabled = true;
      this.cboEv.Location = new System.Drawing.Point(309, 158);
      this.cboEv.Name = "cboEv";
      this.cboEv.Size = new System.Drawing.Size(121, 21);
      this.cboEv.TabIndex = 1;
      this.cboEv.SelectedIndexChanged += new System.EventHandler(this.CboEv_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(173, 99);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Clave Alu:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(173, 166);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(52, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Clave ev:";
      // 
      // btnAlta
      // 
      this.btnAlta.Location = new System.Drawing.Point(550, 97);
      this.btnAlta.Name = "btnAlta";
      this.btnAlta.Size = new System.Drawing.Size(75, 23);
      this.btnAlta.TabIndex = 4;
      this.btnAlta.Text = "Alta";
      this.btnAlta.UseVisualStyleBackColor = true;
      this.btnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
      // 
      // btnReg
      // 
      this.btnReg.Location = new System.Drawing.Point(550, 142);
      this.btnReg.Name = "btnReg";
      this.btnReg.Size = new System.Drawing.Size(75, 23);
      this.btnReg.TabIndex = 5;
      this.btnReg.Text = "Regresar";
      this.btnReg.UseVisualStyleBackColor = true;
      this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
      // 
      // pantalla2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnReg);
      this.Controls.Add(this.btnAlta);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cboEv);
      this.Controls.Add(this.cboAl);
      this.Name = "pantalla2";
      this.Text = "pantalla2";
      this.Load += new System.EventHandler(this.Pantalla2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.ComboBox cboAl;
    private System.Windows.Forms.ComboBox cboEv;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAlta;
    private System.Windows.Forms.Button btnReg;
    }
  }