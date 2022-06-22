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
  public partial class Página3 : Form {
    GestorBD.GestorBD GestorBD;   //"Para manejar la BD.
    DataSet DsClaves = new DataSet(), DsGas = new DataSet(); //Para gaurdar el resultado de consultas.
    String cadSql;
    Comunes mc = new Comunes();
    private const int OK = 1;
    int id;
    double monto;
    int mes;
    double tot;
    public Página3 (GestorBD.GestorBD GestorBD) {
      InitializeComponent();
      this.GestorBD = GestorBD;

      }

    private void btnRe_Click (object sender , EventArgs e) {
      Página1 pg1 = new Página1();
      pg1.Show();
      }

    private void btnCons_Click (object sender , EventArgs e) {
      DataRow fila;
      cadSql = "select sum(gasto) Total from salidas s where s.mes =" + mes + " and s.idpersona = " + id;
      GestorBD.consBD(cadSql , DsGas , "Gas");
      if (DsGas.Tables ["Gas"].Rows.Count != 0) {
        fila = DsGas.Tables ["Gas"].Rows [0];
        tot = Convert.ToDouble(fila ["Total"]);
        txtTotal.Text = tot.ToString();
        } else {
        txtTotal.Text = "0";
        }
      }

    private void cbClaves_SelectedIndexChanged (object sender , EventArgs e) {
      id = Convert.ToInt32(cbClaves.Text);
      }

    private void cbMes_SelectedIndexChanged (object sender , EventArgs e) {
      mes = Convert.ToInt32(cbMes.Text);
      }

    private void txtTotal_TextChanged (object sender , EventArgs e) {

      }

    private void Página3_Load (object sender , EventArgs e) {

      cadSql = "select idPersona from Persona";
      GestorBD.consBD(cadSql , DsClaves , "Claves");
      mc.cargaCombo(cbClaves , DsClaves , "Claves" , "idPersona");
      }
    }
  }
