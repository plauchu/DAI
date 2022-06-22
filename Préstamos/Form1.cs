using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Préstamos {
    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent();
            }
        //Variables de clase.
        double tasa;
        int plazo;
        decimal monto, pagoMensual;
        Fórmulas f = new Fórmulas();

        //Propiedades de la clase.
        //La siguiente propiedad permite recuperar el monto del préstamo.
        public decimal Monto {
            get {
                return Convert.ToDecimal(txtMonto.Text);
                }
            }
        //Propiedades de la clase.
        //La siguiente propiedad permite recuperar el plazo.
        public int Plazo {
            get {
                return plazo;
                }
            }

        public decimal Tasa {
            get {
                return Convert.ToDecimal(cboTasa.Text);
                }
            }

        public decimal Mensualidad {
            get {
                return pagoMensual;
                }
            }

        public decimal PagoTotal {
            get {
                return pagoMensual * ( plazo * 12 );
                }
            }
        //Acciones iniciales.
        private void Form1_Load (object sender , EventArgs e) {

            txtMonto.Text = "5000.00";
            cboTasa.Text = "10.0";
            radioButton1.Checked = true;
            }

        //Plazo del préstamo en años.
        private void RadioButton1_CheckedChanged (object sender , EventArgs e) {
            plazo = 1;
            }

        private void RadioButton2_CheckedChanged (object sender , EventArgs e) {
            plazo = 3;
            }

        private void RadioButton3_CheckedChanged (object sender , EventArgs e) {
            plazo = 5;
            }

        private void RadioButton4_CheckedChanged (object sender , EventArgs e) {
            plazo = 10;
            }
        //Cálcula el total a pagar del préstamo.
        private void btnTotal_Click (object sender , EventArgs e) {
            monto = Convert.ToDecimal(txtMonto.Text);
            tasa = Convert.ToDouble(cboTasa.Text);
            pagoMensual = f.mensualidad(tasa , plazo , monto);
            pagoMensual = pagoMensual * (plazo * 12);
            MessageBox.Show("Pago Total: " + pagoMensual.ToString("c"));
            }

        private void cboTasa_SelectedIndexChanged (object sender , EventArgs e) {

            }

        //Cálculo del pago mensual del préstamo.
        private void BtnMensual_Click (object sender , EventArgs e) {
            monto = Convert.ToDecimal(txtMonto.Text);
            tasa = Convert.ToDouble(cboTasa.Text);
            pagoMensual = f.mensualidad(tasa , plazo , monto);
            MessageBox.Show("Pago mensual: " + pagoMensual.ToString("c"));
            }
        }
    }
