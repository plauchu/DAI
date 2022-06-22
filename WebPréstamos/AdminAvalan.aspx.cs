using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebPréstamos {
  public partial class AdminAvalan : System.Web.UI.Page {
    //Atributos de la clase.
    private DataSet DSPréstamos = new DataSet();
    private DataSet DSAvales = new DataSet(), DSAvalan = new DataSet();
    private DataRow fila;
    private GestorBD.GestorBD GestorBD;       //Para manejar la BD.
    private Comunes objComún = new Comunes();     //Para manejar las rutinas de uso común.
    private String cadSql, Rfc;
    private int folio, idAval;
    private const int OK = 1;


    //Acciones iniciales.
    protected void Page_Load(object sender, EventArgs e) {

      cargaGrid();
      Response.Write("Prueba");     //De esta manera se pueden escribir mensajes en la página.
    }

    //Carga el grid con el contenido actual de la tabla Avalan.
    public void cargaGrid() {
      GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
      cadSql = "select * from Avalan";
      GestorBD.consBD(cadSql, DSAvalan, "Avalan");
      GrdAvalan.DataSource = DSAvalan.Tables["Avalan"];
      GrdAvalan.DataBind();
    }

    //Activa los controles que corresponda.
    public void activaControles() {
      BtnAlta.Enabled = false; BtnBaja.Enabled = false;
      DdlPréstamos.Visible = true; DdlAvales.Visible = true;
      TxtMonto.Visible = true; BtnEjecutar.Visible = true;
      Label2.Visible = true; Label3.Visible = true; Label4.Visible = true;
    }

    //Desactiva los controles que corresponda.
    public void desactivaControles() {
      BtnAlta.Enabled = true; BtnBaja.Enabled = true;
      GrdAvalan.Enabled = false; DdlPréstamos.Visible = false;
      DdlAvales.Visible = false; DdlAvales.Enabled = false;
      TxtMonto.Visible = false; TxtMonto.Enabled = false;
      BtnEjecutar.Visible = false;
      Label2.Visible = false; Label3.Visible = false; Label4.Visible = false;
    }

    //========================================================================
    //Parte 1a: acciones relacionadas con el alta de avales-préstamos.

    protected void BtnAlta_Click(object sender, EventArgs e) {

      //Recupera objetos de Session.
      GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
      Rfc = Session["Rfc"].ToString();

      //Muestra/deshabilita los controles asociados al alta.
      activaControles();

      //Carga el folio de los préstamos del cliente.
      cadSql = "select * from Préstamos where rfc='" + Rfc + "'";
      GestorBD.consBD(cadSql, DSPréstamos, "Folios");
      objComún.cargaDDL(DdlPréstamos, DSPréstamos, "Folios", "Folio");

      //Carga el nombre de todos los avales.
      cadSql = "select * from Avales";
      GestorBD.consBD(cadSql, DSAvales, "Avales");
      objComún.cargaDDL(DdlAvales, DSAvales, "Avales", "Nombre");  //Muestra resultados.

      //Indica la operación actual.
      LblMensaje.Text = "Operación: Alta";
      Session["Operación"] = "Alta";
    }

    //Habilita al ddl de avales.
    protected void DdlPréstamos_SelectedIndexChanged(object sender, EventArgs e) {

      DdlAvales.Enabled = true;
    }

    //Habilita a la caja del monto y al botón de ejecutar.
    protected void DdlAvales_SelectedIndexChanged(object sender, EventArgs e) {

      TxtMonto.Enabled = true; BtnEjecutar.Enabled = true;
    }

    //Parte 1.b: Termina de hacer el alta en la tabla: Avalan.
    public void alta() {
      //Recupera objetos de Session.
      GestorBD = (GestorBD.GestorBD)Session["GestorBD"];
      cadSql = "select * from Avales where Nombre = '" + DdlAvales.Text + "'";
      GestorBD.consBD(cadSql, DSAvales, "Avales");
      fila = DSAvales.Tables["Avales"].Rows[0];
      idAval = (int)fila["IdAval"];

      //Si el monto es mayor a $50,000, hace el alta.
      if (Convert.ToDecimal(TxtMonto.Text) >= 50000) {
        //Construye la inserción
        cadSql = "insert into Avalan values (" + DdlPréstamos.Text + "," + idAval + "," + Convert.ToDecimal(TxtMonto.Text) + ")";
        if(GestorBD.altaBD(cadSql) == OK) {
          LblMensaje.Text = "Inserción correcta";
          cargaGrid();  //Actualiza el grid
          desactivaControles();
        } else {
          LblMensaje.Text = "Error en la inserción";
        }
      } else {
        LblMensaje.Text = "El monto debe ser > $50,000";
        TxtMonto.Focus();
      }
    
    }

    //Parte 2: elimina un vínculo Préstamo-Aval.
    protected void BtnBaja_Click(object sender, EventArgs e) {

      //Habilita/deshabilita los controles asociados a la operación.
      GrdAvalan.Enabled = true; BtnBaja.Enabled = false;
      BtnAlta.Enabled = false;

      //Indica la operación actual.
      LblMensaje.Text = "Operación: Baja";
    }

    //Elimina la tupla elegida de Avalan cuando se da clic en el botón de la fila en el grid.
    protected void GrdAvalan_RowDeleting(object sender, GridViewDeleteEventArgs e) {
      int índiceFila;
      int índiceFolio = 1, índiceIdAval = 2;    //NOTA: Estos valores deben ajustarse
                                                //si se agregan más columnas a GrdAvalan.
      GridViewRow g;

      índiceFila = e.RowIndex; //índice de la fila a que se dió click.
      g = GrdAvalan.Rows[índiceFila]; //Obtiene el contenido de la fila a borrar.

      //Construye y ejecuta la cadena de borrado.
      cadSql = "delete from Avalan where Folio =" + g.Cells [índiceFolio].Text + " and IdAval =" + g.Cells [índiceIdAval].Text;
      if (GestorBD.bajaBD(cadSql) == OK) {
        //Acciones adicionales a la baja
        cargaGrid();  //Actualiza el grid
        desactivaControles();
        GrdAvalan.Enabled = false;
        LblMensaje.Text = "Operación: en espera";
        } else {
        LblMensaje.Text = "Error: no se pudo eliminar en Avalan";
        }
      
      }

    //Parte 4: Ejecuta la operación.
    protected void BtnEjecuta_Click(object sender, EventArgs e) {
      string oper;

      oper = Session["Operación"].ToString();
      switch (oper) {
        case "Alta":
          alta();
          break;
        case "Cambio":
          //cambio();
          break;
      }
    }

  }
}
