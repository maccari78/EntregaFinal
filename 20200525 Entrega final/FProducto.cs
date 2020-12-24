using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20200525_Entrega_final
{
    public partial class FProducto : Form
    {
        public string descripcion;
        public int codigo, cantidad;
        public double precio;
        public bool NombreSec;

        public FProducto()
        {
            InitializeComponent();
        }

        private void FProducto_Load(object sender, EventArgs e)
        {
            mtbCodigo.Text = Convert.ToString(codigo);
            tbDescripcion.Text = descripcion;
            nudCantidad.Value = cantidad;
            mtbPrecio.Text = Convert.ToString(precio);

            if (NombreSec)
            {
                Text = "Agregar";
                mtbCodigo.Text = "";
            }
            else
            {
                Text = "Modificar";
                mtbCodigo.Text = mtbCodigo.Text;
            }
            mtbCodigo.Focus();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (mtbCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar un código", "Error");
                mtbCodigo.Focus();
            }
            else if (tbDescripcion.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción", "Error");
                tbDescripcion.Focus();
            }
            else if (nudCantidad.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad", "Error");
                nudCantidad.Focus();
            }
            else if (mtbPrecio.Text == "")
            {
                MessageBox.Show("Debe ingresar un precio", "Error");
                mtbPrecio.Focus();
            }
            else
            {
                codigo = Convert.ToInt32(mtbCodigo.Text);
                descripcion = tbDescripcion.Text;
                cantidad = Convert.ToInt32(nudCantidad.Value);
                String pre = String.Format("{0:c2}", mtbPrecio.Text);
                precio = Convert.ToDouble(pre);
                DialogResult = DialogResult.OK;
            }
        }

        private void mtbCodigo_Validating(object sender, CancelEventArgs e)
        {
            epCodigo.Clear();
            if (mtbCodigo.Text == "")
                epCodigo.SetError(mtbCodigo, "Completar");
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
