using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebPréstamos {
  public partial class Default : System.Web.UI.Page {
    //Variables de clase.
    GestorBD.GestorBD GestorBD;
    DataSet DsGeneral = new DataSet();
    string cadSql;

    //Acciones iniciales.
    protected void Page_Load(object sender, EventArgs e) {

      //Nota:IsPostBack es una propiedad de cada página. Tiene valor False 
      //La 1a. vez que se carga la página. Tiene valor True las demás veces.
      if (!IsPostBack) {
        GestorBD = new GestorBD.GestorBD("SQLNCLI11", "CC202-01\\SA", "sa", "adminadmin", "Préstamos");
        Session["GestorBD"] = GestorBD;

      }
    }

    //Verifica que usuario y contraseña coincidan
    protected void Login1_Authenticate(object sender, AuthenticateEventArgs e) {
      string cadSql;

      cadSql = "select * from Clientes where rfc= '" + Login1.UserName + "' and contraseña = '" + Login1.Password + "'";
      GestorBD = (GestorBD.GestorBD) Session["GestorBD"];
      GestorBD.consBD(cadSql, DsGeneral, "Temporal");

      //Valida que usuario y contraseña coincidan.
      if (DsGeneral.Tables["Temporal"].Rows.Count != 0) {
        //Transfiere el control a la siguiente página.
        Session["rfc"] = Login1.UserName;
        Server.Transfer("AdminAvalan.aspx");
      }
    }
  }
}