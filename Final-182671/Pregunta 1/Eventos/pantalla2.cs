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
  public partial class pantalla2 : Form {
    GestorBD.GestorBD GestorBD;   //"Para manejar la BD.
    DataSet DsClave = new DataSet(), DsID = new DataSet(); //Para gaurdar el resultado de consultas.
    String cadSql;
    Comunes mc = new Comunes();
    int clave;
    int id;
    private const int OK = 1;
    public pantalla2 (GestorBD.GestorBD GestorBD) {
      InitializeComponent();
      this.GestorBD = GestorBD;
      }

    private void BtnReg_Click (object sender , EventArgs e) {
      pantalla1 pg1 = new pantalla1();
      pg1.Show();
      }

    private void BtnAlta_Click (object sender , EventArgs e) {
      //La siguiente cadena de inserción sólo es un ejemplo rápido.
      cadSql = "insert into alumnoEvento values (" + clave + "," + id + ")";
      MessageBox.Show(cadSql);

      if (GestorBD.altaBD(cadSql) == OK)    //Envía a ejecución la cadena.
        MessageBox.Show("Alta de Alumnoevento exitosa");
      else
        MessageBox.Show("Alta de Alumnoevento incorrecta");
      }

    private void CboAl_SelectedIndexChanged (object sender , EventArgs e) {
      clave = Convert.ToInt32(cboAl.Text);
      }

    private void CboEv_SelectedIndexChanged (object sender , EventArgs e) {
      id = Convert.ToInt32(cboEv.Text);
      }

    private void Pantalla2_Load (object sender , EventArgs e) {
      cadSql = "select ClaveUnica from alumno";
      GestorBD.consBD(cadSql , DsClave , "Clave");
      mc.cargaCombo(cboAl , DsClave , "Clave" , "ClaveUnica");

      cadSql = "select idEvento from evento";
      GestorBD.consBD(cadSql , DsID , "ID");
      mc.cargaCombo(cboEv , DsID , "ID" , "idEvento");

      }
    }
  }
