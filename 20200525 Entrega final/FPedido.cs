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
    public partial class FPedido : Form
    {
        public string nombre, domicilio, zona, descripcion, telefono, fecha, horario, desde, hasta;
        public int /* telefono, */ codigo, cantidad, stock;
        // public DateTime fecha, horario;
        public double precio;
        public bool estado, NombreSec;

        #region Estructura
        public struct TipoCliente
        {
            public string telefono;
            public string nombre;
            public string domicilio;
            public string zona;
        }

        public struct TipoProducto
        {
            public int codigo;
            public string descripcion;
            public int cantidad;
            public double precio;
        }
        #endregion

        #region Variables
        const int tope = 10;
        TipoCliente[] arrClientes;
        TipoProducto[] arrProductos;
        int ult = -1;
        #endregion

        public FPedido()
        {
            InitializeComponent();
        }

        private void FPedido_Load(object sender, EventArgs e)
        {
            int tope = 10;
            int ult = -1;
            int i = 0;
            TipoCliente[] arrClientes;
            TipoProducto[] arrProductos;
            arrClientes = new TipoCliente[tope];
            arrProductos = new TipoProducto[tope];
            mtbTelCliente.Text = Convert.ToString(arrClientes[i].telefono);
            cbNombreCli.Text = arrClientes[i].nombre;
            mtbCodigoProd.Text = Convert.ToString(arrProductos[i].codigo);
            cbDescripcionProd.Text = arrProductos[i].descripcion;

            if (NombreSec)
            {
                Text = "Agregar";
                mtbFecha.Text = "";
            }
            else
            {
                Text = "Modificar";
                mtbFecha.Text = mtbFecha.Text;
            }
            mtbFecha.Focus();
        }
        
        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (mtbFecha.Text == "")
            {
                MessageBox.Show("Debe ingresar una fecha", "Error");
                mtbFecha.Focus();
            }
            else if (mtbTelCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un teléfono", "Error");
                mtbTelCliente.Focus();
            }
            else if (cbNombreCli.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Error");
                cbNombreCli.Focus();
            }
            else if (cbNombreCli.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Error");
                cbNombreCli.Focus();
            }
            else if (mtbCodigoProd.Text == "")
            {
                MessageBox.Show("Debe ingresar un código", "Error");
                mtbCodigoProd.Focus();
            }
            else if (cbDescripcionProd.Text == "")
            {
                MessageBox.Show("Debe ingresar una descripción", "Error");
                cbDescripcionProd.Focus();
            }
            else if (nudPedido.Text == "")
            {
                MessageBox.Show("Debe ingresar una cantidad", "Error");
                nudPedido.Focus();
            }
            else
            {
                fecha = mtbFecha.Text;
                telefono = mtbTelCliente.Text;
                nombre = cbNombreCli.Text;
                codigo = Convert.ToInt32(mtbCodigoProd.Text);
                descripcion = cbDescripcionProd.Text;
                cantidad = Convert.ToInt32(nudPedido.Value);

                if (checkEntregado.Checked)
                    estado = true;
                else
                    estado = false;

                if (rb11a13.Checked)
                    horario = "11 a 13";
                else if (rb13a15.Checked)
                    horario = "13 a 15";
                else
                    horario = "15 a 17";

                DialogResult = DialogResult.OK;
            }
        }

        private void cbNombreCli_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNombreCli.Items.Clear();

            for (int i = 0; i <= ult; i++)
            {
                if (arrClientes[i].nombre == nombre)
                {
                    cbNombreCli.Items.Add(arrClientes[i].nombre);
                    mtbTelCliente.Text = arrClientes[i].telefono;
                }
            }
        }

        private void cbDescripcionProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDescripcionProd.Items.Clear();

            for (int i = 0; i <= ult; i++)
            {
                if (arrProductos[i].descripcion == descripcion)
                {
                    cbDescripcionProd.Items.Add(arrProductos[i].descripcion);
                    mtbCodigoProd.Text = Convert.ToString(arrProductos[i].codigo);
                }
            }
        }

        private void mtbFecha_Validating(object sender, CancelEventArgs e)
        {
            epFecha.Clear();
            if (mtbFecha.Text == "")
                epFecha.SetError(mtbFecha, "Completar");
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }        
    }
}
