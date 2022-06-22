
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
    public partial class FrmAltaPréstamos : Form {

        //Atributos de la clase.
        private GestorBD.GestorBD GestorBD;        //Para manejar la BD.
        private DataSet DsGeneral = new DataSet();
        private Form1 fcp = new Form1();    //Para poder usar esta forma.
        private const int OK = 1;
        private string rfc;           //El rfc del usuario.
        private string cadSql;
        Comunes mc = new Comunes();

        public FrmAltaPréstamos (GestorBD.GestorBD GestorBD, string rfc) {
            InitializeComponent();

            this.GestorBD = GestorBD;
            this.rfc = rfc;
            //Si es gerente carga combo box y se poner visible sino no lo carga y el cliente no lo ve.
            if (rfc == "ger") {
                cadSql = "select Rfc from Clientes";
                GestorBD.consBD(cadSql , DsGeneral , "Cliente");
                if (DsGeneral.Tables ["Cliente"].Rows.Count != 0) {
                    mc.cargaCombo(comboBox1 , DsGeneral , "Cliente" , "Rfc");
                    }
                }
            }

        //Llama a FrmCalculaPagos la cual genera los valores relacionados con un préstamo:
        //monto, tasa, etc.
        //Recordatorio: tasa, plazo, mensualidad y pagoTotal deben definirse como propiedades
        //en la forma FrmCalculaPagos, tal como se hizo con monto, para poder usarlos aquí para dar
        //de alta un préstamo.
        private void btnCalculaPago_Click (object sender , EventArgs e) {
            fcp.ShowDialog();           //Abre la forma para calcular los valores de un préstamo.
            btnAlta.Enabled = true;
            }

        //Construye la cadena de inserción del nuevo préstamo y la envia a ejecución.
        private void btnAlta_Click (object sender , EventArgs e) {
            int folio;
            string fecha;
            DataRow fila;

            //Genera el nuevo folio.
            cadSql = "select top 1 folio from Préstamos order by folio desc";    //Verifica si hay préstamos registrados.
            GestorBD.consBD(cadSql , DsGeneral , "Folio");
            if (DsGeneral.Tables ["Folio"].Rows.Count != 0) {
                fila = DsGeneral.Tables ["Folio"].Rows [0];   //Si sí, recupera el máximo folio.
                folio = (int)fila ["Folio"] + 1;              //Genera el nuevo folio.
                }
            else
                folio = 1;       //Si no, crea el primer folio.

            //Aquí se deben obtener los diversos valores del préstamo, para construir la cadena de inserción.
            //Los valores del préstamo se recuperan usando las propiedades definidas en FrmCalculaPagos.
            //La siguiente cadena de inserción sólo es un ejemplo rápido.
            fecha = dtpFecha.Value.ToShortDateString();     //Recupera la fecha.
            cadSql = "insert into Préstamos values (" + folio + ",'" + fecha + "'," + fcp.Monto + "," +
              fcp.Tasa + "," + fcp.Plazo + "," + fcp.Mensualidad + "," + fcp.PagoTotal + "," + fcp.Monto + "," + rfc + ")";
            MessageBox.Show(cadSql);

            if (GestorBD.altaBD(cadSql) == OK)    //Envía a ejecución la cadena.
                MessageBox.Show("Alta de préstamo exitosa");
            else
                MessageBox.Show("Alta de préstamo incorrecta");
            btnAlta.Enabled = false;
            }

        private void FrmAltaPréstamos_Load (object sender , EventArgs e) {

            }

        private void comboBox1_SelectedIndexChanged (object sender , EventArgs e) {
            rfc = comboBox1.Text;
            }
        }
    }
