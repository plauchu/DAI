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
    public partial class FrmConsPagos : Form {
        //Atributos de la clase.
        GestorBD.GestorBD GestorBD;
        DataSet DsGeneral = new DataSet(), DsPago = new DataSet();
        Comunes mc = new Comunes();
        string rfc, cadSql;
        public FrmConsPagos (GestorBD.GestorBD GestorBD , string rfc) {
            InitializeComponent();
            this.GestorBD = GestorBD;
            this.rfc = rfc;
            //Si es gerente carga combo box y se poner visible sino no lo carga y el cliente no lo ve.
            if (rfc == "ger") {
                cboCliente.Visible = true;
                label1.Visible = true;
                cadSql = "select Rfc from Clientes";
                GestorBD.consBD(cadSql , DsGeneral , "Cliente");
                if (DsGeneral.Tables ["Cliente"].Rows.Count != 0) {
                    mc.cargaCombo(cboCliente , DsGeneral , "Cliente" , "Rfc");
                    }
                else {
                    cboCliente.Visible = false;
                    label1.Visible = false;
                    }
                }
            }

        private void cboCliente_SelectedIndexChanged (object sender , EventArgs e) {
            rfc = cboCliente.Text;
            }

        private void btnMostar_Click (object sender , EventArgs e) {
            cadSql = "select * from Clientes c, Préstamos p, Pagos pa where p.rfc = '" + rfc + "' and c.rfc=p.rfc and p.folio = pa.folio";
            GestorBD.consBD(cadSql , DsPago , "Préstamos");

            //Muestra los datos del cliente.
            dataGridView1.DataSource = DsPago.Tables ["Préstamos"];
            }

        private void FrmConsPagos_Load (object sender , EventArgs e) {

            }
        }
    }
