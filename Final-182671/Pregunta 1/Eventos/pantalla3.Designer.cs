namespace Eventos {
  partial class pantalla3 {
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
      this.btnReg = new System.Windows.Forms.Button();
      this.grdEv = new System.Windows.Forms.DataGridView();
      this.btnCons = new System.Windows.Forms.Button();
      this.txtF1 = new System.Windows.Forms.TextBox();
      this.cboAl = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txtF2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.grdEv)).BeginInit();
      this.SuspendLayout();
      // 
      // btnReg
      // 
      this.btnReg.Location = new System.Drawing.Point(565, 339);
      this.btnReg.Name = "btnReg";
      this.btnReg.Size = new System.Drawing.Size(75, 23);
      this.btnReg.TabIndex = 6;
      this.btnReg.Text = "Regresar";
      this.btnReg.UseVisualStyleBackColor = true;
      this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
      // 
      // grdEv
      // 
      this.grdEv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdEv.Location = new System.Drawing.Point(95, 160);
      this.grdEv.Name = "grdEv";
      this.grdEv.Size = new System.Drawing.Size(624, 150);
      this.grdEv.TabIndex = 7;
      // 
      // btnCons
      // 
      this.btnCons.Location = new System.Drawing.Point(95, 339);
      this.btnCons.Name = "btnCons";
      this.btnCons.Size = new System.Drawing.Size(75, 23);
      this.btnCons.TabIndex = 8;
      this.btnCons.Text = "Consultar";
      this.btnCons.UseVisualStyleBackColor = true;
      this.btnCons.Click += new System.EventHandler(this.BtnCons_Click);
      // 
      // txtF1
      // 
      this.txtF1.Location = new System.Drawing.Point(341, 55);
      this.txtF1.Name = "txtF1";
      this.txtF1.Size = new System.Drawing.Size(100, 20);
      this.txtF1.TabIndex = 9;
      // 
      // cboAl
      // 
      this.cboAl.FormattingEnabled = true;
      this.cboAl.Location = new System.Drawing.Point(95, 54);
      this.cboAl.Name = "cboAl";
      this.cboAl.Size = new System.Drawing.Size(121, 21);
      this.cboAl.TabIndex = 10;
      this.cboAl.SelectedIndexChanged += new System.EventHandler(this.CboAl_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(92, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(45, 13);
      this.label1.TabIndex = 11;
      this.label1.Text = "Alumno:";
      // 
      // txtF2
      // 
      this.txtF2.Location = new System.Drawing.Point(565, 54);
      this.txtF2.Name = "txtF2";
      this.txtF2.Size = new System.Drawing.Size(100, 20);
      this.txtF2.TabIndex = 12;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(338, 24);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 13;
      this.label2.Text = "Entre:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(519, 24);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(15, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "y:";
      // 
      // pantalla3
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtF2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cboAl);
      this.Controls.Add(this.txtF1);
      this.Controls.Add(this.btnCons);
      this.Controls.Add(this.grdEv);
      this.Controls.Add(this.btnReg);
      this.Name = "pantalla3";
      this.Text = "pantalla3";
      this.Load += new System.EventHandler(this.Pantalla3_Load);
      ((System.ComponentModel.ISupportInitialize)(this.grdEv)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.Button btnReg;
    private System.Windows.Forms.DataGridView grdEv;
    private System.Windows.Forms.Button btnCons;
    private System.Windows.Forms.TextBox txtF1;
    private System.Windows.Forms.ComboBox cboAl;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtF2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    }
  }