using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos {
  public partial class pantalla3 : Form {
    GestorBD.GestorBD GestorBD;   //"Para manejar la BD.
    DataSet DsClave = new DataSet(), DsGrid = new DataSet(); //Para gaurdar el resultado de consultas.
    String cadSql;
    Comunes mc = new Comunes();
    int clave;
    private const int OK = 1;
    public pantalla3 (GestorBD.GestorBD GestorBD) {
      InitializeComponent();
      this.GestorBD = GestorBD;
      }

    private void BtnReg_Click (object sender , EventArgs e) {
      pantalla1 pg1 = new pantalla1();
      pg1.Show();
      }

    private void BtnCons_Click (object sender , EventArgs e) {
      cadSql = "select nombre, fecha, comentarios from evento e, alumnoEvento ae, alumno a where " + clave + " = ae.claveUnica and ae.idEvento = e.idEvento and fecha between '" + txtF1 + "' and '" + txtF2 + "'";
      GestorBD.consBD(cadSql , DsGrid , "Grid");
      grdEv.DataSource = DsGrid.Tables ["Grid"];
      }

    private void CboAl_SelectedIndexChanged (object sender , EventArgs e) {
      clave = Convert.ToInt32(cboAl.Text);
      }

    private void Pantalla3_Load (object sender , EventArgs e) {
      cadSql = "select ClaveUnica from alumno";
      GestorBD.consBD(cadSql , DsClave , "Clave");
      mc.cargaCombo(cboAl , DsClave , "Clave" , "ClaveUnica");
      }
    }
  }
