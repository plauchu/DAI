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
  public partial class FrmMenúGeneral : Form {
    //Atributos de la clase.
    GestorBD.GestorBD GestorBD;
    string rfc; //RFC del usuario.
    public FrmMenúGeneral(GestorBD.GestorBD GestorBD, string rfc) {
      InitializeComponent();
      this.GestorBD = GestorBD;
      this.rfc = rfc;

      //Habilita los sub-menús para alta de clientes.
      if(rfc == "ger") {
        MnuAltaClientes.Enabled = true;
        MnuAltaPag.Enabled = true;
        MnuAltaPres.Enabled = true;
      } else {
        MnuAltaClientes.Enabled = false;
        MnuAltaPag.Enabled = false;
        MnuAltaPres.Enabled = false;
      }
    }

    private void FrmMenúGeneral_Load(object sender, EventArgs e) {

    }

    //Termina la aplicación
    private void SalirToolStripMenuItem_Click(object sender, EventArgs e) {

      Application.Exit();
    }

    private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

    }

    //Abre la forma de alta de clientes.
    private void MnuAltaClientes_Click(object sender, EventArgs e) {

      FrmAltaClientes fa = new FrmAltaClientes(GestorBD);
      fa.ShowDialog();
    }

    //Abre la forma de consulta de clientes.
    private void MnuConsClientes_Click(object sender, EventArgs e) {

      FrmConsClientes fcc = new FrmConsClientes(GestorBD, rfc);
      fcc.ShowDialog();
    }

    private void MnuAltaPag_Click(object sender, EventArgs e) {
            FrmAltaPagos fapa = new FrmAltaPagos(GestorBD , rfc);
            fapa.ShowDialog();
    }

    private void MnuAltaPres_Click(object sender, EventArgs e) {

      FrmAltaPréstamos fap = new FrmAltaPréstamos(GestorBD, rfc);
      fap.ShowDialog();
    }

        private void MnuConsPres_Click (object sender , EventArgs e) {
            FrmConsPréstamos fcp = new FrmConsPréstamos(GestorBD , rfc);
            fcp.ShowDialog();
            }

        private void MnuConsPag_Click (object sender , EventArgs e) {
            FrmConsPagos fcp = new FrmConsPagos(GestorBD, rfc);
            fcp.ShowDialog();
            }
        }
}
