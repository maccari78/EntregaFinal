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
    public partial class FEntregas : Form
    {
        public string nombre, domicilio, zona, descripcion, telefono, stock, estado;
        public int /* telefono, */ codigo, cantidad, /* stock, */ clienteTel;
        public DateTime fecha, horario;
        public double precio;
        public bool norte, sur, centro, entregado, sinEntregar, sinStock, entre1y10, entre11y100, mas100;

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
            public string cantidadProd;
            public double precio;
        }

        public struct TipoPedido
        {
            public string fecha;
            public string clienteTel;
            public string clienteNom;
            public int productoCod;
            public string productoDesc;
            public int cantidadPed;
            public bool estado;
            public string horario;
        }
        #endregion

        #region Variables
        const int tope = 10;
        public TipoCliente[] arrClientes;
        public TipoProducto[] arrProductos;
        private TipoPedido[] arrPedidos;
        int ult = -1;
        #endregion

        public FEntregas()
        {
            InitializeComponent();
        }

        private void FEntregas_Load(object sender, EventArgs e)
        {
            cbSector.SelectedIndex = 0;
            cbStock.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
            rbTodos.Checked = true;
            arrClientes = new TipoCliente[tope];
            arrProductos = new TipoProducto[tope];
            arrPedidos = new TipoPedido[tope];
            lCantClientes.Text = "Cantidad de clientes: " + Convert.ToString(lbClientes.Items.Count);
            lCantProductos.Text = "Cantidad de productos: " + Convert.ToString(lbProductos.Items.Count);
            lCantPedidos.Text = "Cantidad de pedidos: " + Convert.ToString(lbPedidos.Items.Count);
            lCantPedEntregados.Text = "Cantidad de pedidos entregados: " + Convert.ToString(lbPedidos.Items.Count);
        }

        private void bAgregarCli_Click(object sender, EventArgs e)
        {
            FCliente FAgregarCli = new FCliente();
            FAgregarCli.NombreSec = true; // Al ser verdadero el título del formulario es Agregar
            FAgregarCli.ShowDialog();
            int i = 0;
            TipoCliente contador;

            if (FAgregarCli.DialogResult == DialogResult.OK)
            {
                while ((FAgregarCli.telefono != (Convert.ToString(arrClientes[i].telefono)) && (i <= ult)))
                {
                    i = i + 1;
                }
                if (i <= ult)
                {
                    MessageBox.Show("La cliente con ese teléfono ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    contador.telefono = FAgregarCli.telefono;
                    contador.nombre = FAgregarCli.nombre;
                    contador.domicilio = FAgregarCli.domicilio;
                    contador.zona = FAgregarCli.zona;
                    ult = ult + 1;
                    arrClientes[ult] = contador;
                    lbClientes.Items.Add(FAgregarCli.telefono + " - " + FAgregarCli.nombre + " - " + FAgregarCli.domicilio + " - " + FAgregarCli.zona);
                }
            }
            else
            {
                MessageBox.Show("Cancelo la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ActualizarListaCli(norte, sur, centro, zona);
            lCantClientes.Text = "Cantidad de clientes: " + Convert.ToString(lbClientes.Items.Count);
        }

        private void bModificarCli_Click(object sender, EventArgs e)
        {
            FCliente FModifCli = new FCliente();
            int Lugar;

            if (lbClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un elemento para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbClientes.Focus();
            }
            else
            {
                FModifCli.NombreSec = false; // Al ser falso, cambia el título del formulario a "Modificar"
                //bModificarCli.Enabled = true; // Si lo ponía en el load como disable y acá como enable no andaba
                Lugar = lbClientes.SelectedIndex;
                FModifCli.telefono = arrClientes[Lugar].telefono;
                FModifCli.nombre = arrClientes[Lugar].nombre;
                FModifCli.domicilio = arrClientes[Lugar].domicilio;
                FModifCli.zona = arrClientes[Lugar].zona;
                FModifCli.ShowDialog();
                if (FModifCli.DialogResult == DialogResult.OK)
                {
                    lbClientes.Items.Remove(lbClientes.SelectedItem);
                    arrClientes[Lugar].telefono = FModifCli.telefono;
                    arrClientes[Lugar].nombre = FModifCli.nombre;
                    arrClientes[Lugar].domicilio = FModifCli.domicilio;
                    arrClientes[Lugar].zona = FModifCli.zona;
                    lbClientes.Items.Insert(Lugar, FModifCli.telefono + " - " + FModifCli.nombre + " - " + FModifCli.domicilio + " - " + FModifCli.zona);
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            ActualizarListaCli(norte, sur, centro, zona);
        }
        
        private void bEliminarCli_Click(object sender, EventArgs e)
        {
            int Lugar = lbClientes.SelectedIndex;
            if (Lugar < 0)
            {
                MessageBox.Show("Seleccione un cliente para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbClientes.Items.RemoveAt(Lugar); // Elimina el nombre seleccionado
                for (int j = 0; j < ult; j++)
                {
                    arrClientes[j] = arrClientes[j + 1];
                }
                ult = ult - 1;
            }
            ActualizarListaCli(norte, sur, centro, zona);
            lCantClientes.Text = "Cantidad de clientes: " + Convert.ToString(lbClientes.Items.Count);
        }

        private void cbSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSector.Text == "Norte")
                norte = true;
            else if (cbSector.Text == "Sur")
                sur = true;
            else
                centro = true;

            string sector = cbSector.Text;
            ActualizarListaCli(norte, sur, centro, zona);
            lCantClientes.Text = "Cantidad de clientes: " + Convert.ToString(lbClientes.Items.Count);
        }
        
        private void bAgregarProd_Click(object sender, EventArgs e)
        {
            FProducto FAgregarProd = new FProducto();
            FAgregarProd.NombreSec = true; // Al ser verdadero el título del formulario es Agregar
            FAgregarProd.ShowDialog();
            int i = 0;
            TipoProducto contador;

            if (FAgregarProd.DialogResult == DialogResult.OK)
            {
                while ((FAgregarProd.codigo != Convert.ToInt32(arrProductos[i].codigo)) && (i <= ult))
                {
                    i = i + 1;
                }
                if (i <= ult)
                {
                    MessageBox.Show("La cliente con ese teléfono ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    contador.codigo = Convert.ToInt32(FAgregarProd.codigo);
                    contador.descripcion = FAgregarProd.descripcion;
                    contador.cantidadProd = Convert.ToString(FAgregarProd.cantidad);
                    contador.precio = FAgregarProd.precio;
                    ult = ult + 1;
                    arrProductos[ult] = contador;
                    lbProductos.Items.Add(FAgregarProd.codigo + " - " + FAgregarProd.descripcion + " - " + FAgregarProd.cantidad + " - " + FAgregarProd.precio);
                }
            }
            else
            {
                MessageBox.Show("Cancelo la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lCantProductos.Text = "Cantidad de productos: " + Convert.ToString(lbProductos.Items.Count);
        }
        
        private void bModificarProd_Click(object sender, EventArgs e)
        {
            FProducto FModifProd = new FProducto();
            int Lugar;

            if (lbProductos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbProductos.Focus();
            }
            else
            {
                FModifProd.NombreSec = false; // Al ser falso, cambia el título del formulario a "Modificar"
                Lugar = lbProductos.SelectedIndex;
                FModifProd.codigo = Convert.ToInt32(arrProductos[Lugar].codigo); 
                FModifProd.descripcion = arrProductos[Lugar].descripcion;
                FModifProd.cantidad = Convert.ToInt32(arrProductos[Lugar].cantidadProd);
                FModifProd.precio = arrProductos[Lugar].precio;
                FModifProd.ShowDialog();
                if (FModifProd.DialogResult == DialogResult.OK)
                {
                    lbProductos.Items.Remove(lbProductos.SelectedItem);
                    arrClientes[Lugar].telefono = Convert.ToString(FModifProd.codigo);
                    arrClientes[Lugar].nombre = FModifProd.descripcion;
                    arrClientes[Lugar].domicilio = Convert.ToString(FModifProd.cantidad);
                    arrClientes[Lugar].zona = Convert.ToString(FModifProd.precio);
                    lbProductos.Items.Insert(Lugar, FModifProd.codigo + " - " + FModifProd.descripcion + " - " + FModifProd.cantidad + " - " + Convert.ToString(FModifProd.precio));
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void bEliminarProd_Click(object sender, EventArgs e)
        {
            int Lugar = lbProductos.SelectedIndex;
            if (Lugar < 0)
            {
                MessageBox.Show("Seleccione un producto para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbProductos.Items.RemoveAt(Lugar); // Elimina el nombre seleccionado
                for (int j = 0; j < ult; j++)
                {
                    arrClientes[j] = arrClientes[j + 1];
                }
                ult -= 1;
            }
            lCantProductos.Text = "Cantidad de clientes: " + Convert.ToString(lbProductos.Items.Count);
        }

        private void cbStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStock.Text == "Sin stock")
                sinStock = true;
            else if (cbStock.Text == "Entre 1 y 10")
                entre1y10 = true;
            else if (cbStock.Text == "Entre 11 y 100")
                entre11y100 = true;
            else
                mas100 = true;

            string stock = cbStock.Text;
            ActualizarListaProd(sinStock, entre1y10, entre11y100, mas100, stock);
            lCantProductos.Text = "Cantidad de productos: " + Convert.ToString(lbProductos.Items.Count);
        }

        private void bAgregarPed_Click(object sender, EventArgs e)
        {
            FPedido FAgregarPed = new FPedido();
            FAgregarPed.NombreSec = true; // Al ser verdadero el título del formulario es Agregar
            FAgregarPed.ShowDialog();
            int i = 0;
            TipoPedido contador;

            if (FAgregarPed.DialogResult == DialogResult.OK)
            {
                while ((FAgregarPed.telefono != Convert.ToString(arrPedidos[i].clienteTel)) && (i <= ult))
                {
                    i = i + 1;
                }
                if (i <= ult)
                {
                    MessageBox.Show("La cliente con ese teléfono ya está registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    contador.fecha = FAgregarPed.fecha;
                    contador.clienteTel = FAgregarPed.telefono;
                    contador.clienteNom = FAgregarPed.nombre;
                    contador.productoCod = Convert.ToInt32(FAgregarPed.codigo);
                    contador.productoDesc = FAgregarPed.descripcion;
                    contador.cantidadPed = Convert.ToInt32(FAgregarPed.cantidad);
                    contador.estado = FAgregarPed.estado;
                    contador.horario = FAgregarPed.horario;
                    ult = ult + 1;
                    arrPedidos[ult] = contador;
                    lbPedidos.Items.Add(FAgregarPed.fecha + " - " + FAgregarPed.telefono + " - " + FAgregarPed.nombre + " - " + FAgregarPed.codigo + " - " + FAgregarPed.descripcion + " - " + FAgregarPed.cantidad + " - " + FAgregarPed.estado + " - " + FAgregarPed.horario);
                }
            }
            else
            {
                MessageBox.Show("Cancelo la operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            lCantPedidos.Text = "Cantidad de productos: " + Convert.ToString(lbPedidos.Items.Count);
        }

        private void bModificarPed_Click(object sender, EventArgs e)
        {
            FPedido FModifPed = new FPedido();
            int Lugar;

            if (lbPedidos.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un pedido para modificar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbPedidos.Focus();
            }
            else
            {
                FModifPed.NombreSec = false; // Al ser falso, cambia el título del formulario a "Modificar"
                Lugar = lbPedidos.SelectedIndex;
                FModifPed.fecha = Convert.ToString(arrPedidos[Lugar].fecha); 
                FModifPed.telefono = Convert.ToString(arrPedidos[Lugar].clienteTel);
                FModifPed.nombre = arrPedidos[Lugar].clienteNom;
                FModifPed.codigo = Convert.ToInt32(arrPedidos[Lugar].productoCod);
                FModifPed.descripcion = arrPedidos[Lugar].productoDesc;
                FModifPed.cantidad = Convert.ToInt32(arrPedidos[Lugar].cantidadPed);
                FModifPed.estado = arrPedidos[Lugar].estado;
                FModifPed.horario = Convert.ToString(arrPedidos[Lugar].horario);
                FModifPed.ShowDialog();
                if (FModifPed.DialogResult == DialogResult.OK)
                {
                    lbProductos.Items.Remove(lbProductos.SelectedItem);
                    arrPedidos[Lugar].fecha = FModifPed.fecha;
                    arrPedidos[Lugar].clienteTel = FModifPed.telefono;
                    arrPedidos[Lugar].clienteNom = FModifPed.nombre;
                    arrPedidos[Lugar].productoCod = Convert.ToInt32(FModifPed.codigo);
                    arrPedidos[Lugar].productoDesc = FModifPed.descripcion;
                    arrPedidos[Lugar].cantidadPed = Convert.ToInt32(FModifPed.cantidad);
                    arrPedidos[Lugar].estado = Convert.ToBoolean(FModifPed.estado);
                    arrPedidos[Lugar].horario = FModifPed.horario;
                    lbPedidos.Items.Insert(Lugar, FModifPed.fecha + " - " + FModifPed.telefono + " - " + FModifPed.nombre + " - " + Convert.ToString(FModifPed.codigo) + " - " + FModifPed.descripcion + " - " + Convert.ToString(FModifPed.cantidad) + " - " + Convert.ToString(FModifPed.estado) + " - " + Convert.ToString(FModifPed.horario));
                }
                else
                {
                    DialogResult = DialogResult.Cancel;
                }
            }
            ActualizarListaPed(entregado, sinEntregar, estado);
            lCantPedidos.Text = "Cantidad de pedidos: " + Convert.ToString(lbPedidos.Items.Count);
        }

        private void bEliminarPed_Click(object sender, EventArgs e)
        {
            int Lugar = lbPedidos.SelectedIndex;
            if (Lugar < 0)
            {
                MessageBox.Show("Seleccione un pedido para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbPedidos.Items.RemoveAt(Lugar); // Elimina el nombre seleccionado
                for (int j = 0; j < ult; j++)
                {
                    arrClientes[j] = arrClientes[j + 1];
                }
                ult -= 1;
            }
            ActualizarListaPed(entregado,sinEntregar, estado);
            lbPedidos.Text = "Cantidad de pedidos: " + Convert.ToString(lbPedidos.Items.Count);
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstado.Text == "Entregado")
                entregado = true;
            else
                sinEntregar = true;

            string estado = cbEstado.Text;
            ActualizarListaPed(entregado, sinEntregar, estado);
            lCantPedidos.Text = "Cantidad de productos: " + Convert.ToString(lbPedidos.Items.Count);
        }

        private void gbHorario_Enter(object sender, EventArgs e)
        {
            bool todos = false;
            bool entre11y13 = false;
            bool entre13y15 = false;
            bool entre15y17 = false;

            if (rbTodos.Checked)
            {
                todos = true;
            }
            if (rb11a13.Checked)
            {
                entre11y13 = true;
            }
            if (rb13a15.Checked)
            {
                entre13y15 = true;
            }
            if (rb15a17.Checked)
            {
                entre15y17 = true;
            }
            string horario = gbHorario.Text;
            ActualizarListaPed(entregado, sinEntregar, estado);
        }

        private void bMarcarEntr_Click(object sender, EventArgs e)
        {
            int Lugar = lbPedidos.SelectedIndex;
            if (Lugar < 0)
            {
                MessageBox.Show("Seleccione un pedido para entregar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("El producto " + lbPedidos.SelectedItem + " a sido entregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            lCantPedEntregados.Text = "Cantidad de pedidos entregados: " + Convert.ToString(lbPedidos.Items.Count);
        }

        private void miAcercaDe_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Entrega final 25-05-2020" + "\nAlumno: Danilo Maccari", "Acerca de... ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
                
        #region Métodos auxiliares
        private void ActualizarListaCli(bool norte, bool sur, bool centro, string zona)
        {
            int i = 0;
            lbClientes.Items.Clear();
            TipoCliente[] arrFiltro;
            TipoCliente[] arrFiltroAux;
            int topeFiltro = tope;
            int ultPosFiltro = ult;
            int topeFiltroAux = tope;
            int ultPosFiltroAux = -1;
            arrFiltro = new TipoCliente[topeFiltro];
            arrFiltroAux = new TipoCliente[topeFiltroAux];
            arrFiltro = arrClientes;

            if (cbSector.Text != "Todos")
            {
                for (i = 0; i <= ultPosFiltro; i++)
                {
                    if (arrFiltro[i].zona == cbSector.Text)
                    {
                        arrFiltroAux[++ultPosFiltroAux] = arrFiltro[i];
                    }
                }
                arrFiltro = arrFiltroAux;
                ultPosFiltro = ultPosFiltroAux;
                ultPosFiltroAux = -1;
            }

            for (i = 0; i <= ultPosFiltro; i++)
            {
                string renglon = Convert.ToString(arrFiltro[i].telefono) + " - " + arrFiltro[i].nombre + " - " + arrFiltro[i].domicilio + " - " + arrFiltro[i].zona;
                lbClientes.Items.Add(renglon);
            }
        }

        private void ActualizarListaProd(bool sinStock, bool entre1y10, bool entre11y100, bool mas100, string stock)
        {
            int i = 0;
            lbProductos.Items.Clear();
            TipoProducto[] arrFiltroProd;
            TipoProducto[] arrFiltroAuxProd;
            int topeFiltroProd = tope;
            int ultPosFiltroProd = ult;
            int topeFiltroAuxProd = tope;
            int ultPosFiltroAuxProd = -1;
            arrFiltroProd = new TipoProducto[topeFiltroProd];
            arrFiltroAuxProd = new TipoProducto[topeFiltroAuxProd];
            arrFiltroProd = arrProductos;

            if (cbStock.Text != "Todos")
            {
                for (i = 0; i <= ultPosFiltroProd; i++)
                {
                    if (arrFiltroProd[i].cantidadProd == Convert.ToString(cbStock.Text))
                    {
                        arrFiltroAuxProd[++ultPosFiltroAuxProd] = arrFiltroProd[i];
                    }
                }
                arrFiltroProd = arrFiltroAuxProd;
                ultPosFiltroProd = ultPosFiltroAuxProd;
                ultPosFiltroAuxProd = -1;
            }

            for (i = 0; i <= ultPosFiltroProd; i++)
            {
                string renglon = Convert.ToString(arrFiltroProd[i].codigo) + " - " + arrFiltroProd[i].descripcion + " - " + arrFiltroProd[i].cantidadProd + " - " + arrFiltroProd[i].precio;
                lbProductos.Items.Add(renglon);
            }
        }

        private void ActualizarListaPed(bool entregado, bool sinEntregar, string estado)
        {
            lbPedidos.Items.Clear();
            TipoPedido[] arrFiltroPed;
            TipoPedido[] arrFiltroAuxPed;
            int topeFiltroPed = tope;
            int ultPosFiltroPed = ult;
            int topeFiltroAuxPed = tope;
            int ultPosFiltroAuxPed = -1;
            arrFiltroPed = new TipoPedido[topeFiltroPed];
            arrFiltroAuxPed = new TipoPedido[topeFiltroAuxPed];
            arrFiltroPed = arrPedidos;

            if (cbEstado.Text != "Todos")
            {
                for (int i = 0; i <= ultPosFiltroPed; i++)
                {
                    if (arrFiltroPed[i].cantidadPed == Convert.ToInt32(cbEstado.Text))
                    {
                        arrFiltroAuxPed[++ultPosFiltroAuxPed] = arrFiltroPed[i];
                    }
                }
                arrFiltroPed = arrFiltroAuxPed;
                ultPosFiltroPed = ultPosFiltroAuxPed;
                ultPosFiltroAuxPed = -1;
            }

            for (int i = 0; i <= ultPosFiltroPed; i++)
            {
                string renglon = Convert.ToString(arrFiltroPed[i].fecha) + " - " + arrFiltroPed[i].clienteTel + " - " + arrFiltroPed[i].clienteNom + " - " + arrFiltroPed[i].productoCod + " - " + arrFiltroPed[i].productoDesc + " - " + arrFiltroPed[i].cantidadPed + " - " + arrFiltroPed[i].estado + " - " + arrFiltroPed[i].horario;
                lbPedidos.Items.Add(renglon);
            }
        }
        #endregion
    }
}
