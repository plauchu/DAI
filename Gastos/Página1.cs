using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gastos {
  public partial class Página1 : Form {
    GestorBD.GestorBD GestorBD;   //"Para manejar la BD.
    DataSet DsClaves = new DataSet(), DsID = new DataSet(); //Para gaurdar el resultado de consultas.
    String cadSql;
    Comunes mc = new Comunes();
    private const int OK = 1;
    int id;
    double monto;
    int mes;
    public Página1 () {
      InitializeComponent();
      }

    private void Form1_Load (object sender , EventArgs e) {
      GestorBD = new GestorBD.GestorBD("SQLNCLI11" , "DESKTOP-77NC78G\\SQLEXPRESS" , "sa" , "adminadmin" , "Gastos");

      cadSql = "select idPersona from Persona";
      GestorBD.consBD(cadSql , DsClaves , "Claves");
      mc.cargaCombo(cbClaves , DsClaves , "Claves" , "idPersona");
      }

    private void btnAlta_Click (object sender , EventArgs e) {
      int IdEntrada;
      DataRow fila;

      //Genera el nuevo folio.
      cadSql = "select top 1 idEntrada from entradas order by idEntrada desc";    //Verifica si hay préstamos registrados.
      GestorBD.consBD(cadSql , DsID , "Id");
      if (DsID.Tables ["Id"].Rows.Count != 0) {
        fila = DsID.Tables ["Id"].Rows [0];   //Si sí, recupera el máximo folio.
        IdEntrada = (int)fila ["IdEntrada"] + 1;              //Genera el nuevo folio.
        } else
        IdEntrada = 1;       //Si no, crea el primer folio.

      //Aquí se deben obtener los diversos valores del préstamo, para construir la cadena de inserción.
      //Los valores del préstamo se recuperan usando las propiedades definidas en FrmCalculaPagos.
      //La siguiente cadena de inserción sólo es un ejemplo rápido.
      if (Convert.ToDouble(txtBoxMonto.Text) > 0) {

        cadSql = "insert into entradas values (" + IdEntrada + "," + monto + "," + mes + "," + id + ")";
        MessageBox.Show(cadSql);
        } else {
        txtBoxMonto.Focus();
        }

          if (GestorBD.altaBD(cadSql) == OK)    //Envía a ejecución la cadena.
            MessageBox.Show("Alta de monto exitosa");
          else
            MessageBox.Show("Alta de monto incorrecta");
          }

        private void cbClaves_SelectedIndexChanged (object sender , EventArgs e) {
          id = Convert.ToInt32(cbClaves.Text);
          }

        private void txtBoxMonto_TextChanged (object sender , EventArgs e) {
          monto = Convert.ToDouble(txtBoxMonto.Text);
          }

    private void btn2_Click (object sender , EventArgs e) {
      Página2 pg2 = new Página2(GestorBD , id , mes);
      pg2.Show();
      }

    private void btn3_Click (object sender , EventArgs e) {
      Página3 pg3 = new Página3(GestorBD);
      pg3.Show();
      }

    private void cbMes_SelectedIndexChanged (object sender , EventArgs e) {
          mes = Convert.ToInt32(cbMes.Text);
          }
        }

      }
