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
  public partial class pantalla1 : Form {
    GestorBD.GestorBD GestorBD;   //"Para manejar la BD.
    DataSet DsLugar = new DataSet(), DsID = new DataSet(); //Para gaurdar el resultado de consultas.
    String cadSql;
    Comunes mc = new Comunes();
    int lugar;
    private const int OK = 1;
    public pantalla1 () {
      InitializeComponent();
      }

    private void CboLugar_SelectedIndexChanged (object sender , EventArgs e) {
      lugar = Convert.ToInt32(cboLugar.Text);
      }

    private void BtnAlta_Click (object sender , EventArgs e) {

      //La siguiente cadena de inserción sólo es un ejemplo rápido.
      cadSql = "insert into evento values ('"+ txtNom.Text + "','" + txtFecha.Text + "','" + txtCom.Text + "'," + lugar + ")";
      MessageBox.Show(cadSql); 

      if (GestorBD.altaBD(cadSql) == OK)    //Envía a ejecución la cadena.
        MessageBox.Show("Alta de evento exitosa");
      else
        MessageBox.Show("Alta de evento incorrecta");
      }

    private void BtnPan2_Click (object sender , EventArgs e) {
      pantalla2 pg2 = new pantalla2(GestorBD);
      pg2.Show();
      }

    private void BtnPan3_Click (object sender , EventArgs e) {
      pantalla3 pg2 = new pantalla3(GestorBD);
      pg2.Show();
      }

    private void Pantalla1_Load (object sender , EventArgs e) {
      GestorBD = new GestorBD.GestorBD("SQLNCLI11" , "CC202-01\\SA" , "sa" , "adminadmin" , "Eventos");

      cadSql = "select idLugar from lugar";
      GestorBD.consBD(cadSql , DsLugar , "Lugar");
      mc.cargaCombo(cboLugar , DsLugar , "Lugar" , "idLugar");


      }
    }
  }
