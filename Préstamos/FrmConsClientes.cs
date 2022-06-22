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
  public partial class FrmConsClientes : Form {
    //Atributos de la clase.
    GestorBD.GestorBD GestorBD;
    DataSet DsGeneral = new DataSet();
    Comunes mc = new Comunes();
    string rfc, cadSql;
    public FrmConsClientes(GestorBD.GestorBD GestorBD, string rfc) {
      InitializeComponent();
      this.GestorBD = GestorBD;
      this.rfc = rfc;

            //Si es gerente, carga el combo box con el rfc de los clientes.
            //Y hace visibles el combo y la etiqueta.
            if (rfc == "ger") {
                cboCliente.Visible = true;
                label1.Visible = true;
                cadSql = "select Rfc from Clientes";
                GestorBD.consBD(cadSql , DsGeneral , "Cliente");
                if(DsGeneral.Tables ["Cliente"].Rows.Count != 0) {
                    mc.cargaCombo(cboCliente , DsGeneral , "Cliente" , "Rfc");
                    }
                } else {
                cboCliente.Visible = false;
                label1.Visible = false;
                }

    }


    //Hace la consulta para mostrar los datos del cliente.
    private void BtnMostar_Click(object sender, EventArgs e) {
      cadSql = "select * from Clientes where Rfc = '" + rfc + "'";
      GestorBD.consBD(cadSql, DsGeneral, "Cliente");

      //Muestra los datos del cliente.
      dataGridView1.DataSource = DsGeneral.Tables["Cliente"];
    }

    private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

    }

    //El gerente elige al cliente del combo box.
    private void CboCliente_SelectedIndexChanged(object sender, EventArgs e) {
            rfc = cboCliente.Text;
    }

    private void FrmConsClientes_Load(object sender, EventArgs e) {

    }
  }
}
