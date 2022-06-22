namespace Eventos {
  partial class pantalla1 {
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
      this.txtNom = new System.Windows.Forms.TextBox();
      this.txtCom = new System.Windows.Forms.TextBox();
      this.cboLugar = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnAlta = new System.Windows.Forms.Button();
      this.txtFecha = new System.Windows.Forms.TextBox();
      this.btnPan2 = new System.Windows.Forms.Button();
      this.btnPan3 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // txtNom
      // 
      this.txtNom.Location = new System.Drawing.Point(227, 80);
      this.txtNom.Name = "txtNom";
      this.txtNom.Size = new System.Drawing.Size(100, 20);
      this.txtNom.TabIndex = 0;
      // 
      // txtCom
      // 
      this.txtCom.Location = new System.Drawing.Point(227, 184);
      this.txtCom.Name = "txtCom";
      this.txtCom.Size = new System.Drawing.Size(100, 20);
      this.txtCom.TabIndex = 2;
      // 
      // cboLugar
      // 
      this.cboLugar.FormattingEnabled = true;
      this.cboLugar.Location = new System.Drawing.Point(227, 235);
      this.cboLugar.Name = "cboLugar";
      this.cboLugar.Size = new System.Drawing.Size(121, 21);
      this.cboLugar.TabIndex = 3;
      this.cboLugar.SelectedIndexChanged += new System.EventHandler(this.CboLugar_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(107, 80);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(47, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "Nombre:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(107, 139);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(40, 13);
      this.label2.TabIndex = 5;
      this.label2.Text = "Fecha:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(107, 191);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Comentarios:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(107, 243);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(37, 13);
      this.label4.TabIndex = 7;
      this.label4.Text = "Lugar:";
      // 
      // btnAlta
      // 
      this.btnAlta.Location = new System.Drawing.Point(569, 139);
      this.btnAlta.Name = "btnAlta";
      this.btnAlta.Size = new System.Drawing.Size(75, 23);
      this.btnAlta.TabIndex = 8;
      this.btnAlta.Text = "Alta";
      this.btnAlta.UseVisualStyleBackColor = true;
      this.btnAlta.Click += new System.EventHandler(this.BtnAlta_Click);
      // 
      // txtFecha
      // 
      this.txtFecha.Location = new System.Drawing.Point(227, 136);
      this.txtFecha.Name = "txtFecha";
      this.txtFecha.Size = new System.Drawing.Size(100, 20);
      this.txtFecha.TabIndex = 9;
      // 
      // btnPan2
      // 
      this.btnPan2.Location = new System.Drawing.Point(475, 233);
      this.btnPan2.Name = "btnPan2";
      this.btnPan2.Size = new System.Drawing.Size(75, 23);
      this.btnPan2.TabIndex = 10;
      this.btnPan2.Text = "Pantalla2";
      this.btnPan2.UseVisualStyleBackColor = true;
      this.btnPan2.Click += new System.EventHandler(this.BtnPan2_Click);
      // 
      // btnPan3
      // 
      this.btnPan3.Location = new System.Drawing.Point(625, 233);
      this.btnPan3.Name = "btnPan3";
      this.btnPan3.Size = new System.Drawing.Size(75, 23);
      this.btnPan3.TabIndex = 11;
      this.btnPan3.Text = "Pantalla3";
      this.btnPan3.UseVisualStyleBackColor = true;
      this.btnPan3.Click += new System.EventHandler(this.BtnPan3_Click);
      // 
      // pantalla1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnPan3);
      this.Controls.Add(this.btnPan2);
      this.Controls.Add(this.txtFecha);
      this.Controls.Add(this.btnAlta);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cboLugar);
      this.Controls.Add(this.txtCom);
      this.Controls.Add(this.txtNom);
      this.Name = "pantalla1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Pantalla1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

      }

    #endregion
    private System.Windows.Forms.TextBox txtNom;
    private System.Windows.Forms.TextBox txtCom;
    private System.Windows.Forms.ComboBox cboLugar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnAlta;
    private System.Windows.Forms.TextBox txtFecha;
    private System.Windows.Forms.Button btnPan2;
    private System.Windows.Forms.Button btnPan3;
    }
  }

