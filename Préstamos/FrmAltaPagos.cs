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
    public partial class FrmAltaPagos : Form {
        //Atributos de la clase.
        GestorBD.GestorBD GestorBD;
        DataSet DsGeneral = new DataSet();
        Comunes mc = new Comunes();
        string rfc, cadSql;
        private const int OK = 1;
        public FrmAltaPagos (GestorBD.GestorBD GestorBD , string rfc) {
            InitializeComponent();
            this.GestorBD = GestorBD;
            this.rfc = rfc;
            }

        private void btnAlta_Click (object sender , EventArgs e) {
            int IdP;
            string fecha;
            DataRow fila;

            //Genera el nuevo folio.
            cadSql = "select top 1 IdP from Pago order by IdP desc";    //Verifica si hay pagos registrados.
            GestorBD.consBD(cadSql , DsGeneral , "Pago");
            if (DsGeneral.Tables ["Pago"].Rows.Count != 0) {
                fila = DsGeneral.Tables ["Pago"].Rows [0];   //Si sí, recupera el máximo folio.
                IdP = (int)fila ["Pago"] + 1;              //Genera el nuevo pago.
                }
            else
                IdP = 1;       //Si no, crea el primer folio.

            //Aquí se deben obtener los diversos valores del préstamo, para construir la cadena de inserción.
            //Los valores del préstamo se recuperan usando las propiedades definidas en FrmCalculaPagos.
            //La siguiente cadena de inserción sólo es un ejemplo rápido.
            fecha = dtpFecha.Value.ToShortDateString();     //Recupera la fecha.
            cadSql = "insert into Pagos values (" + txtFolio.Text + ",'" + IdP + "'," + fecha + "," + txtMontoPago.Text +  ")";
            MessageBox.Show(cadSql);

            if (GestorBD.altaBD(cadSql) == OK)    //Envía a ejecución la cadena.
                MessageBox.Show("Alta de préstamo exitosa");
            else
                MessageBox.Show("Alta de préstamo incorrecta");
            btnAlta.Enabled = false;
            }

        private void FrmAltaPagos_Load (object sender , EventArgs e) {

            }
        }
    }
