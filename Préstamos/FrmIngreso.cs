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
  public partial class FrmIngreso : Form {
    //Atributos de la clase.
    GestorBD.GestorBD GestorBD;   //"Para manejar la BD.
    DataSet DsGeneral = new DataSet(); //Para gaurdar el resultado de consultas.

    public FrmIngreso() {
      InitializeComponent();
    }


    //Hace la conexión a la BD.
    private void FrmIngreso_Load(object sender, EventArgs e) {
      GestorBD = new GestorBD.GestorBD("SQLNCLI11", "DESKTOP-77NC78G\\SQLEXPRESS", "sa", "adminadmin", "Préstamos"); 
    }
    
    //Verificar que el usuario exista
    private void BtnIngresar_Click(object sender, EventArgs e) {
      string cadSql;

      cadSql = "select * from Clientes where rfc= '" + txtUsuario.Text + "' and contraseña = '" + txtContra.Text + "'";
      GestorBD.consBD(cadSql, DsGeneral, "Temporal");

      //Valida que usuario y contraseña coincidan.
      if(DsGeneral.Tables["Temporal"].Rows.Count != 0) {
        //Abre el menú general. HAY QUE PROPAGAR LA CONEXIÓN a la BD y el rfc.
        FrmMenúGeneral fm = new FrmMenúGeneral(GestorBD, txtUsuario.Text);
        fm.Show();
      } else {
        MessageBox.Show("Usuario incorrecto");
        txtUsuario.Clear();
        txtContra.Clear();
        txtUsuario.Focus();
      }
    }
  }
}
