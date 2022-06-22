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
    public partial class FrmConsPréstamos : Form {
        //Atributos de la clase.
        GestorBD.GestorBD GestorBD;
        DataSet DsGeneral = new DataSet(), DsPréstamos = new DataSet();
        Comunes mc = new Comunes();
        string rfc, cadSql;
        public FrmConsPréstamos (GestorBD.GestorBD GestorBD , string rfc) {
            InitializeComponent();
            this.GestorBD = GestorBD;
            this.rfc = rfc;

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

        private void label1_Click (object sender , EventArgs e) {

            }

        private void btnMostar_Click (object sender , EventArgs e) {
            cadSql = "select * from Clientes c, Préstamos p where p.rfc = '" + rfc + "' and c.rfc=p.rfc";
            GestorBD.consBD(cadSql , DsPréstamos , "Préstamos");

            //Muestra los datos del cliente.
            dataGridView1.DataSource = DsPréstamos.Tables ["Préstamos"];
            }

        private void cboCliente_SelectedIndexChanged (object sender , EventArgs e) {
            rfc = cboCliente.Text;
            }

        private void FrmConsPréstamos_Load (object sender , EventArgs e) {

            }
        }
    }
