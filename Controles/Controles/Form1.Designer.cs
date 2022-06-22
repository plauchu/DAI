namespace Controles
{
    partial class Form1
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.radioButton3 = new System.Windows.Forms.RadioButton();
      this.radioButton2 = new System.Windows.Forms.RadioButton();
      this.radioButton1 = new System.Windows.Forms.RadioButton();
      this.picGeneral = new System.Windows.Forms.PictureBox();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.cboArtículos = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lstArtículos = new System.Windows.Forms.ListBox();
      this.lstPrecio = new System.Windows.Forms.ListBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.txtCant = new System.Windows.Forms.TextBox();
      this.txtMonto = new System.Windows.Forms.TextBox();
      this.txtNeto = new System.Windows.Forms.TextBox();
      this.txtIva = new System.Windows.Forms.TextBox();
      this.txtTotal = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picGeneral)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.radioButton3);
      this.groupBox1.Controls.Add(this.radioButton2);
      this.groupBox1.Controls.Add(this.radioButton1);
      this.groupBox1.Location = new System.Drawing.Point(58, 30);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBox1.Size = new System.Drawing.Size(383, 45);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Tipo de artículo";
      // 
      // radioButton3
      // 
      this.radioButton3.AutoSize = true;
      this.radioButton3.Location = new System.Drawing.Point(286, 17);
      this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.radioButton3.Name = "radioButton3";
      this.radioButton3.Size = new System.Drawing.Size(63, 17);
      this.radioButton3.TabIndex = 2;
      this.radioButton3.TabStop = true;
      this.radioButton3.Text = "Pinturas";
      this.radioButton3.UseVisualStyleBackColor = true;
      this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton3_CheckedChanged);
      // 
      // radioButton2
      // 
      this.radioButton2.AutoSize = true;
      this.radioButton2.Location = new System.Drawing.Point(154, 17);
      this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.radioButton2.Name = "radioButton2";
      this.radioButton2.Size = new System.Drawing.Size(87, 17);
      this.radioButton2.TabIndex = 1;
      this.radioButton2.TabStop = true;
      this.radioButton2.Text = "Herramientas";
      this.radioButton2.UseVisualStyleBackColor = true;
      this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
      // 
      // radioButton1
      // 
      this.radioButton1.AutoSize = true;
      this.radioButton1.Location = new System.Drawing.Point(22, 17);
      this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.radioButton1.Name = "radioButton1";
      this.radioButton1.Size = new System.Drawing.Size(87, 17);
      this.radioButton1.TabIndex = 0;
      this.radioButton1.TabStop = true;
      this.radioButton1.Text = "Construcción";
      this.radioButton1.UseVisualStyleBackColor = true;
      this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
      // 
      // picGeneral
      // 
      this.picGeneral.Location = new System.Drawing.Point(527, 32);
      this.picGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.picGeneral.Name = "picGeneral";
      this.picGeneral.Size = new System.Drawing.Size(75, 41);
      this.picGeneral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picGeneral.TabIndex = 1;
      this.picGeneral.TabStop = false;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(358, 89);
      this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(75, 27);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Visible = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
      this.pictureBox2.Location = new System.Drawing.Point(469, 89);
      this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(75, 27);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 3;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.Visible = false;
      // 
      // pictureBox3
      // 
      this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
      this.pictureBox3.Location = new System.Drawing.Point(580, 89);
      this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(75, 27);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox3.TabIndex = 4;
      this.pictureBox3.TabStop = false;
      this.pictureBox3.Visible = false;
      // 
      // cboArtículos
      // 
      this.cboArtículos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboArtículos.FormattingEnabled = true;
      this.cboArtículos.Location = new System.Drawing.Point(169, 93);
      this.cboArtículos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.cboArtículos.Name = "cboArtículos";
      this.cboArtículos.Size = new System.Drawing.Size(129, 21);
      this.cboArtículos.TabIndex = 5;
      this.cboArtículos.SelectedIndexChanged += new System.EventHandler(this.CboArtículos_SelectedIndexChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(92, 92);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 15);
      this.label1.TabIndex = 6;
      this.label1.Text = "Artículos:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(61, 165);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(120, 13);
      this.label2.TabIndex = 7;
      this.label2.Text = "Artículos seleccionados";
      this.label2.Click += new System.EventHandler(this.Label2_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(221, 165);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 13);
      this.label3.TabIndex = 8;
      this.label3.Text = "Precio:";
      // 
      // lstArtículos
      // 
      this.lstArtículos.FormattingEnabled = true;
      this.lstArtículos.Location = new System.Drawing.Point(64, 181);
      this.lstArtículos.Name = "lstArtículos";
      this.lstArtículos.Size = new System.Drawing.Size(120, 95);
      this.lstArtículos.TabIndex = 9;
      // 
      // lstPrecio
      // 
      this.lstPrecio.FormattingEnabled = true;
      this.lstPrecio.Location = new System.Drawing.Point(224, 181);
      this.lstPrecio.Name = "lstPrecio";
      this.lstPrecio.Size = new System.Drawing.Size(120, 95);
      this.lstPrecio.TabIndex = 10;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(536, 165);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 41);
      this.button1.TabIndex = 11;
      this.button1.Text = "Calcular totales";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(536, 224);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 41);
      this.button2.TabIndex = 12;
      this.button2.Text = "Borrar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.Button2_Click);
      // 
      // txtCant
      // 
      this.txtCant.Location = new System.Drawing.Point(64, 328);
      this.txtCant.Name = "txtCant";
      this.txtCant.Size = new System.Drawing.Size(100, 20);
      this.txtCant.TabIndex = 13;
      // 
      // txtMonto
      // 
      this.txtMonto.Location = new System.Drawing.Point(212, 328);
      this.txtMonto.Name = "txtMonto";
      this.txtMonto.Size = new System.Drawing.Size(100, 20);
      this.txtMonto.TabIndex = 14;
      this.txtMonto.TextChanged += new System.EventHandler(this.TxtMonto_TextChanged);
      // 
      // txtNeto
      // 
      this.txtNeto.Location = new System.Drawing.Point(341, 328);
      this.txtNeto.Name = "txtNeto";
      this.txtNeto.Size = new System.Drawing.Size(100, 20);
      this.txtNeto.TabIndex = 15;
      // 
      // txtIva
      // 
      this.txtIva.Location = new System.Drawing.Point(469, 328);
      this.txtIva.Name = "txtIva";
      this.txtIva.Size = new System.Drawing.Size(100, 20);
      this.txtIva.TabIndex = 16;
      // 
      // txtTotal
      // 
      this.txtTotal.Location = new System.Drawing.Point(611, 328);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.Size = new System.Drawing.Size(100, 20);
      this.txtTotal.TabIndex = 17;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(64, 309);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(64, 13);
      this.label4.TabIndex = 18;
      this.label4.Text = "Cant. Artics:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(209, 309);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(40, 13);
      this.label5.TabIndex = 19;
      this.label5.Text = "Monto:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(338, 309);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(59, 13);
      this.label6.TabIndex = 20;
      this.label6.Text = "Pago neto:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(466, 309);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(27, 13);
      this.label7.TabIndex = 21;
      this.label7.Text = "IVA:";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(608, 309);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(73, 13);
      this.label8.TabIndex = 22;
      this.label8.Text = "Total a pagar:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(746, 389);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtTotal);
      this.Controls.Add(this.txtIva);
      this.Controls.Add(this.txtNeto);
      this.Controls.Add(this.txtMonto);
      this.Controls.Add(this.txtCant);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.lstPrecio);
      this.Controls.Add(this.lstArtículos);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.cboArtículos);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.picGeneral);
      this.Controls.Add(this.groupBox1);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Form1";
      this.Text = "Artículos de construcción";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picGeneral)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton radioButton3;
    private System.Windows.Forms.RadioButton radioButton2;
    private System.Windows.Forms.RadioButton radioButton1;
    private System.Windows.Forms.PictureBox picGeneral;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.ComboBox cboArtículos;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ListBox lstArtículos;
    private System.Windows.Forms.ListBox lstPrecio;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox txtCant;
    private System.Windows.Forms.TextBox txtMonto;
    private System.Windows.Forms.TextBox txtNeto;
    private System.Windows.Forms.TextBox txtIva;
    private System.Windows.Forms.TextBox txtTotal;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
  }
}

