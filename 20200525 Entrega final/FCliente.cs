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
    public partial class FCliente : Form
    {
        public string nombre, domicilio, zona, telefono;
        // public int telefono;
        public bool NombreSec;

        public FCliente()
        {
            InitializeComponent();
        }

        private void FCliente_Load(object sender, EventArgs e)
        {
            mtbTelefono.Text = telefono;
            tbNombre.Text = nombre;
            tbDomicilio.Text = domicilio;
            cbZona.SelectedIndex = 0;

            if (NombreSec)
            {
                Text = "Agregar";
                mtbTelefono.Text = "";
            }
            else
            {
                Text = "Modificar";
                mtbTelefono.Text = mtbTelefono.Text;
            }
            mtbTelefono.Focus();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (!mtbTelefono.MaskFull)
            {
                MessageBox.Show("Debe ingresar un teléfono", "Error");
                mtbTelefono.Focus();
            }
            else if (tbNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre", "Error");
                tbNombre.Focus();
            }
            else if (tbDomicilio.Text == "")
            {
                MessageBox.Show("Debe ingresar un domicilio", "Error");
                tbDomicilio.Focus();
            }
            else if (cbZona.SelectedIndex == 0)
            {
                MessageBox.Show("Debe ingresar una zona", "Error");
                cbZona.Focus();
            }
            else
            {
                telefono = mtbTelefono.Text;
                nombre = tbNombre.Text;
                domicilio = tbDomicilio.Text;
                zona = cbZona.SelectedItem.ToString();
                DialogResult = DialogResult.OK;
            }
        }

        private void mtbTelefono_Validating(object sender, CancelEventArgs e)
        {
            epTel.Clear();
            if (mtbTelefono.Text == "")
                epTel.SetError(mtbTelefono, "Completar");
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

    }
}
