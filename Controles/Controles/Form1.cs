using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles {
  public partial class Form1 : Form  {
    public Form1() {
      InitializeComponent();
    }

    DefineDatos datos = new DefineDatos();

    //Acciones iniciales.
    private void Form1_Load(object sender, EventArgs e) {
      llenaCombo("Construcción");
    }

    //Llena el combo con los artículos del tipo elegido.
    private void llenaCombo(string tipo) {
      int i;

      cboArtículos.Items.Clear();
      for (i = 1; i <= datos.totArts; i++)
        if (datos.arts[i].tipo == tipo)
          cboArtículos.Items.Add(datos.arts[i].nombre);
      cboArtículos.Text = "";
    }

    //Código de los botones de radio.
    private void RadioButton1_CheckedChanged(object sender, EventArgs e) {
      picGeneral.Image = pictureBox1.Image;
      llenaCombo("Construcción");
    }
    private void RadioButton2_CheckedChanged(object sender, EventArgs e) {
      picGeneral.Image = pictureBox2.Image;
      llenaCombo("Herramientas");
    }
    private void RadioButton3_CheckedChanged(object sender, EventArgs e) {
      picGeneral.Image = pictureBox3.Image;
      llenaCombo("Pinturas");
    }

    private void Label2_Click(object sender, EventArgs e) {

    }

    //Agrega a los listbox el artículo elegido.
    private void CboArtículos_SelectedIndexChanged(object sender, EventArgs e) {
      int i; 
      lstArtículos.Items.Add(cboArtículos.SelectedItem); //Copia el nombre.

      //Obtiene el precio.
      i = 1;
      while (datos.arts[i].nombre != cboArtículos.SelectedItem) 
        i++;
      lstPrecio.Items.Add(datos.arts[i].precio);
    }

    // Cálculo de los totales
    private void Button1_Click(object sender, EventArgs e) {
      // Código de totales.
      int i; decimal suma, desc, neto, iva, total;
      txtCant.Text = lstArtículos.Items.Count.ToString();

      //Calcula el monto total.
      suma = 0;
      for (i = 0; i <= lstArtículos.Items.Count - 1; i++)
        suma += (decimal)lstPrecio.Items[i];
      txtMonto.Text = suma.ToString("c");

      //Calcula el descuento.
      desc = 0;
      if (suma > 10000)
        desc = suma * (decimal)0.1;
      else
        if (suma > 5000)
        desc = suma * (decimal)0.05;
      neto = suma - desc;

      //Muestra resultados.
      txtNeto.Text = neto.ToString();
      iva = neto * (decimal)0.16;
      txtIva.Text = iva.ToString();
      total = neto + iva;
      txtTotal.Text = total.ToString();

    }

    private void TxtMonto_TextChanged(object sender, EventArgs e) {
   
    }

    private void Button2_Click(object sender, EventArgs e) {
      //Código de Borrar.
      cboArtículos.Text = "";
      lstArtículos.Items.Clear(); lstPrecio.Items.Clear();
      txtCant.Clear(); txtMonto.Clear(); txtNeto.Clear();
      txtIva.Clear(); txtTotal.Clear();
    }
  }
}
