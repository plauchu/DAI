using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebPréstamos {
  public partial class ListaPréstamos : System.Web.UI.Page {
    //Variables de clase.
    GestorBD.GestorBD GestorBD;
    DataSet DsClientes = new DataSet(), DsPréstamos = new DataSet(), DsAvales = new DataSet(), DsPagos = new DataSet();
    Comunes común = new Comunes();
    DataRow fila;
    string rfc, cadSql;

    
    //Acciones iniciales.
    protected void Page_Load(object sender, EventArgs e) {

      if (!IsPostBack) {
        //Recupera objetos de sesión.
        GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
        rfc = Session["rfc"].ToString();

        //Lee y muestra los datos del cliente ingresado.
        cadSql = "select * from Clientes where rfc ='" + rfc + "'";
        GestorBD.consBD(cadSql, DsClientes, "Clientes");
        fila = DsClientes.Tables["Clientes"].Rows[0];
        TblCliente.Rows[1].Cells[0].Text = fila["Rfc"].ToString();
        TblCliente.Rows[1].Cells[1].Text = fila["Nombre"].ToString();
        TblCliente.Rows[1].Cells[2].Text = fila["Domicilio"].ToString();

        //Carga en el ddl el fólio de sus préstamos.
        cadSql = "select * from Préstamos where rfc ='" + rfc + "'";
        GestorBD.consBD(cadSql, DsPréstamos, "Préstamos");
        común.cargaDDL(DdlPréstamos, DsPréstamos, "Préstamos", "Folio");
      }
    }
    //Muestra los datos del préstamo elegido.
    protected void DdlPréstamos_SelectedIndexChanged(object sender, EventArgs e) {
      GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
      rfc = Session["rfc"].ToString();

     if(DdlPréstamos.Text != " ") {
        //Consulta de nuevo a la BD.
        cadSql = "select * from Préstamos where Folio=" + DdlPréstamos.Text;
        GestorBD.consBD(cadSql, DsPréstamos, "Préstamo");
        fila = DsPréstamos.Tables["Préstamo"].Rows[0];

        //Llena la tabla con los datos del préstamo.
        TblPréstamo.Rows[1].Cells[0].Text = fila["Folio"].ToString();
        TblPréstamo.Rows[1].Cells[1].Text = fila["Fecha"].ToString();
        TblPréstamo.Rows[1].Cells[2].Text = fila["Monto"].ToString();
        TblPréstamo.Rows[1].Cells[3].Text = fila["PagoTotal"].ToString();
        TblPréstamo.Rows[1].Cells[4].Text = fila["Saldo"].ToString();

        //Muestra los avales del cliente.
        cadSql = "select Nombre, Domicilio, MontoAvalado from Avalan a, Avales av where a.Folio = " + DdlPréstamos.Text + " and a.IdAval = av.IdAval";
        GestorBD.consBD(cadSql, DsAvales, "Avales");
        GrdAvales.DataSource = DsAvales.Tables["Avales"];  //Muestra resultados.
        GrdAvales.DataBind();

        //Muestra los pagos realizados para el préstamo seleccionado.
        cadSql = "select * from Pagos where Folio=" + DdlPréstamos.Text;
        GestorBD.consBD(cadSql, DsPagos, "Pagos");
        GrdPagos.DataSource = DsPagos.Tables["Pagos"];  //Muestra resultados.
        GrdPagos.DataBind();
      }
    }

  }
}