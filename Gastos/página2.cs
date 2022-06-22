using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gastos {
  public partial class Página2 : Form {
    GestorBD.GestorBD GestorBD;   //"Para manejar la BD.
    DataSet DsClaves = new DataSet(), DsID = new DataSet(); //Para gaurdar el resultado de consultas.
    String cadSql;
    Comunes mc = new Comunes();
    private const int OK = 1;
    int id;
    double gasto;
    int mes;
    int cat;
    public Página2 (GestorBD.GestorBD GestorBD , int id, int mes) {
      InitializeComponent();
      this.GestorBD = GestorBD;
      this.id = id;
      this.mes = mes;
      }

    private void btnAlta_Click (object sender , EventArgs e) {
      int IdSalida;
      DataRow fila;

      //Genera el nuevo folio.
      cadSql = "select top 1 idSalida from salidas order by idSalida desc";    //Verifica si hay préstamos registrados.
      GestorBD.consBD(cadSql , DsID , "Id");
      if (DsID.Tables ["Id"].Rows.Count != 0) {
        fila = DsID.Tables ["Id"].Rows [0];   //Si sí, recupera el máximo folio.
        IdSalida = (int)fila ["idSalida"] + 1;              //Genera el nuevo folio.
        } else
        IdSalida = 1;       //Si no, crea el primer folio.

      //Aquí se deben obtener los diversos valores del préstamo, para construir la cadena de inserción.
      //Los valores del préstamo se recuperan usando las propiedades definidas en FrmCalculaPagos.
      //La siguiente cadena de inserción sólo es un ejemplo rápido.
      if (Convert.ToDouble(txtGasto.Text) > 0) {

        cadSql = "insert into salidas values (" + IdSalida + "," + gasto + "," + mes + "," + id + "," + cat + ")";
        MessageBox.Show(cadSql);
        } else {
        txtGasto.Focus();
        }

      if (GestorBD.altaBD(cadSql) == OK)    //Envía a ejecución la cadena.
        MessageBox.Show("Alta de gasto exitosa");
      else
        MessageBox.Show("Alta de gasto incorrecta");
      }

    private void txtGasto_TextChanged (object sender , EventArgs e) {
      gasto = Convert.ToDouble(txtGasto.Text);
      }

    private void cboCat_SelectedIndexChanged (object sender , EventArgs e) {
      cat = Convert.ToInt32(cboCat.Text);
      }

    private void btnRe_Click (object sender , EventArgs e) {
      Página1 pg1 = new Página1();
      pg1.Show();
      }

    private void Página2_Load (object sender , EventArgs e) {

      }
    }
  }
