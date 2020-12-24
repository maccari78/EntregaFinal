namespace _20200525_Entrega_final
{
    partial class FEntregas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.msEntregas = new System.Windows.Forms.MenuStrip();
            this.miClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.miClientesN = new System.Windows.Forms.ToolStripMenuItem();
            this.miClientesM = new System.Windows.Forms.ToolStripMenuItem();
            this.miClientesE = new System.Windows.Forms.ToolStripMenuItem();
            this.miProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.miProductosN = new System.Windows.Forms.ToolStripMenuItem();
            this.miProductosM = new System.Windows.Forms.ToolStripMenuItem();
            this.miProductosE = new System.Windows.Forms.ToolStripMenuItem();
            this.miPedidos = new System.Windows.Forms.ToolStripMenuItem();
            this.miPedidosN = new System.Windows.Forms.ToolStripMenuItem();
            this.miPedidosM = new System.Windows.Forms.ToolStripMenuItem();
            this.miPedidosE = new System.Windows.Forms.ToolStripMenuItem();
            this.miAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.miSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lClientes = new System.Windows.Forms.Label();
            this.lPedidos = new System.Windows.Forms.Label();
            this.lProductos = new System.Windows.Forms.Label();
            this.lSector = new System.Windows.Forms.Label();
            this.lStock = new System.Windows.Forms.Label();
            this.cbSector = new System.Windows.Forms.ComboBox();
            this.cbStock = new System.Windows.Forms.ComboBox();
            this.lEstado = new System.Windows.Forms.Label();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.lbClientes = new System.Windows.Forms.ListBox();
            this.lbProductos = new System.Windows.Forms.ListBox();
            this.lCantClientes = new System.Windows.Forms.Label();
            this.lCantPedidos = new System.Windows.Forms.Label();
            this.lCantProductos = new System.Windows.Forms.Label();
            this.bAgregarCli = new System.Windows.Forms.Button();
            this.bModificarCli = new System.Windows.Forms.Button();
            this.bEliminarCli = new System.Windows.Forms.Button();
            this.bEliminarProd = new System.Windows.Forms.Button();
            this.bModificarProd = new System.Windows.Forms.Button();
            this.bAgregarProd = new System.Windows.Forms.Button();
            this.gbProductos = new System.Windows.Forms.GroupBox();
            this.bEliminarPed = new System.Windows.Forms.Button();
            this.bModificarPed = new System.Windows.Forms.Button();
            this.bAgregarPed = new System.Windows.Forms.Button();
            this.gbPedidos = new System.Windows.Forms.GroupBox();
            this.lbPedidos = new System.Windows.Forms.ListBox();
            this.gbHorario = new System.Windows.Forms.GroupBox();
            this.rb15a17 = new System.Windows.Forms.RadioButton();
            this.rb13a15 = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rb11a13 = new System.Windows.Forms.RadioButton();
            this.mtbHastaF = new System.Windows.Forms.MaskedTextBox();
            this.mtbDesdeF = new System.Windows.Forms.MaskedTextBox();
            this.lHastaF = new System.Windows.Forms.Label();
            this.lDesdeF = new System.Windows.Forms.Label();
            this.bMarcarEntr = new System.Windows.Forms.Button();
            this.lCantPedEntregados = new System.Windows.Forms.Label();
            this.bCerrar = new System.Windows.Forms.Button();
            this.gbClientes = new System.Windows.Forms.GroupBox();
            this.msEntregas.SuspendLayout();
            this.gbProductos.SuspendLayout();
            this.gbPedidos.SuspendLayout();
            this.gbHorario.SuspendLayout();
            this.SuspendLayout();
            // 
            // msEntregas
            // 
            this.msEntregas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miClientes,
            this.miProductos,
            this.miPedidos,
            this.miAcercaDe,
            this.miSalir});
            this.msEntregas.Location = new System.Drawing.Point(0, 0);
            this.msEntregas.Name = "msEntregas";
            this.msEntregas.Size = new System.Drawing.Size(540, 24);
            this.msEntregas.TabIndex = 0;
            this.msEntregas.Text = "menuStrip1";
            // 
            // miClientes
            // 
            this.miClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miClientesN,
            this.miClientesM,
            this.miClientesE});
            this.miClientes.Name = "miClientes";
            this.miClientes.Size = new System.Drawing.Size(61, 20);
            this.miClientes.Text = "Clientes";
            // 
            // miClientesN
            // 
            this.miClientesN.Name = "miClientesN";
            this.miClientesN.Size = new System.Drawing.Size(125, 22);
            this.miClientesN.Text = "Agregar";
            this.miClientesN.Click += new System.EventHandler(this.bAgregarCli_Click);
            // 
            // miClientesM
            // 
            this.miClientesM.Name = "miClientesM";
            this.miClientesM.Size = new System.Drawing.Size(125, 22);
            this.miClientesM.Text = "Modificar";
            this.miClientesM.Click += new System.EventHandler(this.bModificarCli_Click);
            // 
            // miClientesE
            // 
            this.miClientesE.Name = "miClientesE";
            this.miClientesE.Size = new System.Drawing.Size(125, 22);
            this.miClientesE.Text = "Eliminar";
            this.miClientesE.Click += new System.EventHandler(this.bEliminarCli_Click);
            // 
            // miProductos
            // 
            this.miProductos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miProductosN,
            this.miProductosM,
            this.miProductosE});
            this.miProductos.Name = "miProductos";
            this.miProductos.Size = new System.Drawing.Size(73, 20);
            this.miProductos.Text = "Productos";
            // 
            // miProductosN
            // 
            this.miProductosN.Name = "miProductosN";
            this.miProductosN.Size = new System.Drawing.Size(125, 22);
            this.miProductosN.Text = "Agregar";
            this.miProductosN.Click += new System.EventHandler(this.bAgregarProd_Click);
            // 
            // miProductosM
            // 
            this.miProductosM.Name = "miProductosM";
            this.miProductosM.Size = new System.Drawing.Size(125, 22);
            this.miProductosM.Text = "Modificar";
            this.miProductosM.Click += new System.EventHandler(this.bModificarProd_Click);
            // 
            // miProductosE
            // 
            this.miProductosE.Name = "miProductosE";
            this.miProductosE.Size = new System.Drawing.Size(125, 22);
            this.miProductosE.Text = "Eliminar";
            this.miProductosE.Click += new System.EventHandler(this.bEliminarProd_Click);
            // 
            // miPedidos
            // 
            this.miPedidos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPedidosN,
            this.miPedidosM,
            this.miPedidosE});
            this.miPedidos.Name = "miPedidos";
            this.miPedidos.Size = new System.Drawing.Size(61, 20);
            this.miPedidos.Text = "Pedidos";
            // 
            // miPedidosN
            // 
            this.miPedidosN.Name = "miPedidosN";
            this.miPedidosN.Size = new System.Drawing.Size(125, 22);
            this.miPedidosN.Text = "Agregar";
            this.miPedidosN.Click += new System.EventHandler(this.bAgregarPed_Click);
            // 
            // miPedidosM
            // 
            this.miPedidosM.Name = "miPedidosM";
            this.miPedidosM.Size = new System.Drawing.Size(125, 22);
            this.miPedidosM.Text = "Modificar";
            this.miPedidosM.Click += new System.EventHandler(this.bModificarPed_Click);
            // 
            // miPedidosE
            // 
            this.miPedidosE.Name = "miPedidosE";
            this.miPedidosE.Size = new System.Drawing.Size(125, 22);
            this.miPedidosE.Text = "Eliminar";
            this.miPedidosE.Click += new System.EventHandler(this.bEliminarPed_Click);
            // 
            // miAcercaDe
            // 
            this.miAcercaDe.Name = "miAcercaDe";
            this.miAcercaDe.Size = new System.Drawing.Size(71, 20);
            this.miAcercaDe.Text = "Acerca de";
            this.miAcercaDe.Click += new System.EventHandler(this.miAcercaDe_Click_1);
            // 
            // miSalir
            // 
            this.miSalir.Name = "miSalir";
            this.miSalir.Size = new System.Drawing.Size(41, 20);
            this.miSalir.Text = "Salir";
            this.miSalir.Click += new System.EventHandler(this.bCerrar_Click_1);
            // 
            // lClientes
            // 
            this.lClientes.AutoSize = true;
            this.lClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClientes.Location = new System.Drawing.Point(20, 42);
            this.lClientes.Name = "lClientes";
            this.lClientes.Size = new System.Drawing.Size(52, 13);
            this.lClientes.TabIndex = 1;
            this.lClientes.Text = "Clientes";
            // 
            // lPedidos
            // 
            this.lPedidos.AutoSize = true;
            this.lPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPedidos.Location = new System.Drawing.Point(3, 15);
            this.lPedidos.Name = "lPedidos";
            this.lPedidos.Size = new System.Drawing.Size(52, 13);
            this.lPedidos.TabIndex = 2;
            this.lPedidos.Text = "Pedidos";
            // 
            // lProductos
            // 
            this.lProductos.AutoSize = true;
            this.lProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductos.Location = new System.Drawing.Point(8, 16);
            this.lProductos.Name = "lProductos";
            this.lProductos.Size = new System.Drawing.Size(64, 13);
            this.lProductos.TabIndex = 3;
            this.lProductos.Text = "Productos";
            // 
            // lSector
            // 
            this.lSector.AutoSize = true;
            this.lSector.Location = new System.Drawing.Point(20, 64);
            this.lSector.Name = "lSector";
            this.lSector.Size = new System.Drawing.Size(38, 13);
            this.lSector.TabIndex = 4;
            this.lSector.Text = "Sector";
            // 
            // lStock
            // 
            this.lStock.AutoSize = true;
            this.lStock.Location = new System.Drawing.Point(8, 37);
            this.lStock.Name = "lStock";
            this.lStock.Size = new System.Drawing.Size(35, 13);
            this.lStock.TabIndex = 5;
            this.lStock.Text = "Stock";
            // 
            // cbSector
            // 
            this.cbSector.FormattingEnabled = true;
            this.cbSector.Items.AddRange(new object[] {
            "Todos",
            "Norte",
            "Sur",
            "Centro"});
            this.cbSector.Location = new System.Drawing.Point(64, 61);
            this.cbSector.Name = "cbSector";
            this.cbSector.Size = new System.Drawing.Size(196, 21);
            this.cbSector.TabIndex = 6;
            this.cbSector.SelectedIndexChanged += new System.EventHandler(this.cbSector_SelectedIndexChanged);
            // 
            // cbStock
            // 
            this.cbStock.FormattingEnabled = true;
            this.cbStock.Items.AddRange(new object[] {
            "Todos",
            "Sin stock",
            "Entre 1 y 10",
            "Entre 11 y 100",
            "Más de 100"});
            this.cbStock.Location = new System.Drawing.Point(49, 34);
            this.cbStock.Name = "cbStock";
            this.cbStock.Size = new System.Drawing.Size(199, 21);
            this.cbStock.TabIndex = 7;
            this.cbStock.SelectedIndexChanged += new System.EventHandler(this.cbStock_SelectedIndexChanged);
            // 
            // lEstado
            // 
            this.lEstado.AutoSize = true;
            this.lEstado.Location = new System.Drawing.Point(3, 240);
            this.lEstado.Name = "lEstado";
            this.lEstado.Size = new System.Drawing.Size(40, 13);
            this.lEstado.TabIndex = 8;
            this.lEstado.Text = "Estado";
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Todos",
            "Entregados",
            "Sin entregar"});
            this.cbEstado.Location = new System.Drawing.Point(49, 235);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(194, 21);
            this.cbEstado.TabIndex = 9;
            this.cbEstado.SelectedIndexChanged += new System.EventHandler(this.cbEstado_SelectedIndexChanged);
            // 
            // lbClientes
            // 
            this.lbClientes.FormattingEnabled = true;
            this.lbClientes.HorizontalScrollbar = true;
            this.lbClientes.Location = new System.Drawing.Point(23, 90);
            this.lbClientes.Name = "lbClientes";
            this.lbClientes.Size = new System.Drawing.Size(237, 95);
            this.lbClientes.TabIndex = 10;
            // 
            // lbProductos
            // 
            this.lbProductos.FormattingEnabled = true;
            this.lbProductos.HorizontalScrollbar = true;
            this.lbProductos.Location = new System.Drawing.Point(11, 68);
            this.lbProductos.Name = "lbProductos";
            this.lbProductos.Size = new System.Drawing.Size(237, 95);
            this.lbProductos.TabIndex = 12;
            // 
            // lCantClientes
            // 
            this.lCantClientes.AutoSize = true;
            this.lCantClientes.Location = new System.Drawing.Point(20, 192);
            this.lCantClientes.Name = "lCantClientes";
            this.lCantClientes.Size = new System.Drawing.Size(106, 13);
            this.lCantClientes.TabIndex = 13;
            this.lCantClientes.Text = "Cantidad de clientes:";
            // 
            // lCantPedidos
            // 
            this.lCantPedidos.AutoSize = true;
            this.lCantPedidos.Location = new System.Drawing.Point(6, 363);
            this.lCantPedidos.Name = "lCantPedidos";
            this.lCantPedidos.Size = new System.Drawing.Size(107, 13);
            this.lCantPedidos.TabIndex = 14;
            this.lCantPedidos.Text = "Cantidad de pedidos:";
            // 
            // lCantProductos
            // 
            this.lCantProductos.AutoSize = true;
            this.lCantProductos.Location = new System.Drawing.Point(8, 166);
            this.lCantProductos.Name = "lCantProductos";
            this.lCantProductos.Size = new System.Drawing.Size(117, 13);
            this.lCantProductos.TabIndex = 15;
            this.lCantProductos.Text = "Cantidad de productos:";
            // 
            // bAgregarCli
            // 
            this.bAgregarCli.Location = new System.Drawing.Point(23, 209);
            this.bAgregarCli.Name = "bAgregarCli";
            this.bAgregarCli.Size = new System.Drawing.Size(75, 23);
            this.bAgregarCli.TabIndex = 16;
            this.bAgregarCli.Text = "&Agregar";
            this.bAgregarCli.UseVisualStyleBackColor = true;
            this.bAgregarCli.Click += new System.EventHandler(this.bAgregarCli_Click);
            // 
            // bModificarCli
            // 
            this.bModificarCli.Location = new System.Drawing.Point(104, 209);
            this.bModificarCli.Name = "bModificarCli";
            this.bModificarCli.Size = new System.Drawing.Size(75, 23);
            this.bModificarCli.TabIndex = 17;
            this.bModificarCli.Text = "&Modificar";
            this.bModificarCli.UseVisualStyleBackColor = true;
            this.bModificarCli.Click += new System.EventHandler(this.bModificarCli_Click);
            // 
            // bEliminarCli
            // 
            this.bEliminarCli.Location = new System.Drawing.Point(185, 209);
            this.bEliminarCli.Name = "bEliminarCli";
            this.bEliminarCli.Size = new System.Drawing.Size(75, 23);
            this.bEliminarCli.TabIndex = 18;
            this.bEliminarCli.Text = "&Eliminar";
            this.bEliminarCli.UseVisualStyleBackColor = true;
            this.bEliminarCli.Click += new System.EventHandler(this.bEliminarCli_Click);
            // 
            // bEliminarProd
            // 
            this.bEliminarProd.Location = new System.Drawing.Point(173, 186);
            this.bEliminarProd.Name = "bEliminarProd";
            this.bEliminarProd.Size = new System.Drawing.Size(75, 23);
            this.bEliminarProd.TabIndex = 22;
            this.bEliminarProd.Text = "&Eliminar";
            this.bEliminarProd.UseVisualStyleBackColor = true;
            this.bEliminarProd.Click += new System.EventHandler(this.bEliminarProd_Click);
            // 
            // bModificarProd
            // 
            this.bModificarProd.Location = new System.Drawing.Point(92, 186);
            this.bModificarProd.Name = "bModificarProd";
            this.bModificarProd.Size = new System.Drawing.Size(75, 23);
            this.bModificarProd.TabIndex = 21;
            this.bModificarProd.Text = "&Modificar";
            this.bModificarProd.UseVisualStyleBackColor = true;
            this.bModificarProd.Click += new System.EventHandler(this.bModificarProd_Click);
            // 
            // bAgregarProd
            // 
            this.bAgregarProd.Location = new System.Drawing.Point(11, 186);
            this.bAgregarProd.Name = "bAgregarProd";
            this.bAgregarProd.Size = new System.Drawing.Size(75, 23);
            this.bAgregarProd.TabIndex = 20;
            this.bAgregarProd.Text = "&Agregar";
            this.bAgregarProd.UseVisualStyleBackColor = true;
            this.bAgregarProd.Click += new System.EventHandler(this.bAgregarProd_Click);
            // 
            // gbProductos
            // 
            this.gbProductos.Controls.Add(this.lProductos);
            this.gbProductos.Controls.Add(this.bEliminarProd);
            this.gbProductos.Controls.Add(this.bModificarProd);
            this.gbProductos.Controls.Add(this.bAgregarProd);
            this.gbProductos.Controls.Add(this.lStock);
            this.gbProductos.Controls.Add(this.lCantProductos);
            this.gbProductos.Controls.Add(this.cbStock);
            this.gbProductos.Controls.Add(this.lbProductos);
            this.gbProductos.Location = new System.Drawing.Point(12, 249);
            this.gbProductos.Name = "gbProductos";
            this.gbProductos.Size = new System.Drawing.Size(260, 219);
            this.gbProductos.TabIndex = 23;
            this.gbProductos.TabStop = false;
            // 
            // bEliminarPed
            // 
            this.bEliminarPed.Location = new System.Drawing.Point(168, 408);
            this.bEliminarPed.Name = "bEliminarPed";
            this.bEliminarPed.Size = new System.Drawing.Size(75, 23);
            this.bEliminarPed.TabIndex = 25;
            this.bEliminarPed.Text = "&Eliminar";
            this.bEliminarPed.UseVisualStyleBackColor = true;
            this.bEliminarPed.Click += new System.EventHandler(this.bEliminarPed_Click);
            // 
            // bModificarPed
            // 
            this.bModificarPed.Location = new System.Drawing.Point(87, 408);
            this.bModificarPed.Name = "bModificarPed";
            this.bModificarPed.Size = new System.Drawing.Size(75, 23);
            this.bModificarPed.TabIndex = 24;
            this.bModificarPed.Text = "&Modificar";
            this.bModificarPed.UseVisualStyleBackColor = true;
            this.bModificarPed.Click += new System.EventHandler(this.bModificarPed_Click);
            // 
            // bAgregarPed
            // 
            this.bAgregarPed.Location = new System.Drawing.Point(6, 408);
            this.bAgregarPed.Name = "bAgregarPed";
            this.bAgregarPed.Size = new System.Drawing.Size(75, 23);
            this.bAgregarPed.TabIndex = 23;
            this.bAgregarPed.Text = "&Agregar";
            this.bAgregarPed.UseVisualStyleBackColor = true;
            this.bAgregarPed.Click += new System.EventHandler(this.bAgregarPed_Click);
            // 
            // gbPedidos
            // 
            this.gbPedidos.Controls.Add(this.lbPedidos);
            this.gbPedidos.Controls.Add(this.gbHorario);
            this.gbPedidos.Controls.Add(this.mtbHastaF);
            this.gbPedidos.Controls.Add(this.mtbDesdeF);
            this.gbPedidos.Controls.Add(this.lHastaF);
            this.gbPedidos.Controls.Add(this.lDesdeF);
            this.gbPedidos.Controls.Add(this.bMarcarEntr);
            this.gbPedidos.Controls.Add(this.bEliminarPed);
            this.gbPedidos.Controls.Add(this.lEstado);
            this.gbPedidos.Controls.Add(this.lPedidos);
            this.gbPedidos.Controls.Add(this.cbEstado);
            this.gbPedidos.Controls.Add(this.bModificarPed);
            this.gbPedidos.Controls.Add(this.bAgregarPed);
            this.gbPedidos.Controls.Add(this.lCantPedidos);
            this.gbPedidos.Location = new System.Drawing.Point(278, 27);
            this.gbPedidos.Name = "gbPedidos";
            this.gbPedidos.Size = new System.Drawing.Size(249, 441);
            this.gbPedidos.TabIndex = 24;
            this.gbPedidos.TabStop = false;
            // 
            // lbPedidos
            // 
            this.lbPedidos.FormattingEnabled = true;
            this.lbPedidos.HorizontalScrollbar = true;
            this.lbPedidos.Location = new System.Drawing.Point(6, 265);
            this.lbPedidos.Name = "lbPedidos";
            this.lbPedidos.Size = new System.Drawing.Size(237, 95);
            this.lbPedidos.TabIndex = 31;
            // 
            // gbHorario
            // 
            this.gbHorario.Controls.Add(this.rb15a17);
            this.gbHorario.Controls.Add(this.rb13a15);
            this.gbHorario.Controls.Add(this.rbTodos);
            this.gbHorario.Controls.Add(this.rb11a13);
            this.gbHorario.Location = new System.Drawing.Point(37, 127);
            this.gbHorario.Name = "gbHorario";
            this.gbHorario.Size = new System.Drawing.Size(174, 69);
            this.gbHorario.TabIndex = 29;
            this.gbHorario.TabStop = false;
            this.gbHorario.Text = "Horario";
            this.gbHorario.Enter += new System.EventHandler(this.gbHorario_Enter);
            // 
            // rb15a17
            // 
            this.rb15a17.AutoSize = true;
            this.rb15a17.Location = new System.Drawing.Point(100, 42);
            this.rb15a17.Name = "rb15a17";
            this.rb15a17.Size = new System.Drawing.Size(75, 17);
            this.rb15a17.TabIndex = 33;
            this.rb15a17.TabStop = true;
            this.rb15a17.Text = "15 a 17 hs";
            this.rb15a17.UseVisualStyleBackColor = true;
            // 
            // rb13a15
            // 
            this.rb13a15.AutoSize = true;
            this.rb13a15.Location = new System.Drawing.Point(100, 19);
            this.rb13a15.Name = "rb13a15";
            this.rb13a15.Size = new System.Drawing.Size(75, 17);
            this.rb13a15.TabIndex = 32;
            this.rb13a15.TabStop = true;
            this.rb13a15.Text = "13 a 15 hs";
            this.rb13a15.UseVisualStyleBackColor = true;
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Location = new System.Drawing.Point(9, 19);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 30;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            // 
            // rb11a13
            // 
            this.rb11a13.AutoSize = true;
            this.rb11a13.Location = new System.Drawing.Point(9, 42);
            this.rb11a13.Name = "rb11a13";
            this.rb11a13.Size = new System.Drawing.Size(75, 17);
            this.rb11a13.TabIndex = 31;
            this.rb11a13.TabStop = true;
            this.rb11a13.Text = "11 a 13 hs";
            this.rb11a13.UseVisualStyleBackColor = true;
            // 
            // mtbHastaF
            // 
            this.mtbHastaF.Location = new System.Drawing.Point(111, 77);
            this.mtbHastaF.Mask = "00/00/0000";
            this.mtbHastaF.Name = "mtbHastaF";
            this.mtbHastaF.Size = new System.Drawing.Size(100, 20);
            this.mtbHastaF.TabIndex = 30;
            this.mtbHastaF.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDesdeF
            // 
            this.mtbDesdeF.Location = new System.Drawing.Point(111, 51);
            this.mtbDesdeF.Mask = "00/00/0000";
            this.mtbDesdeF.Name = "mtbDesdeF";
            this.mtbDesdeF.Size = new System.Drawing.Size(100, 20);
            this.mtbDesdeF.TabIndex = 29;
            this.mtbDesdeF.ValidatingType = typeof(System.DateTime);
            // 
            // lHastaF
            // 
            this.lHastaF.AutoSize = true;
            this.lHastaF.Location = new System.Drawing.Point(34, 80);
            this.lHastaF.Name = "lHastaF";
            this.lHastaF.Size = new System.Drawing.Size(68, 13);
            this.lHastaF.TabIndex = 28;
            this.lHastaF.Text = "Hasta fecha:";
            // 
            // lDesdeF
            // 
            this.lDesdeF.AutoSize = true;
            this.lDesdeF.Location = new System.Drawing.Point(34, 54);
            this.lDesdeF.Name = "lDesdeF";
            this.lDesdeF.Size = new System.Drawing.Size(71, 13);
            this.lDesdeF.TabIndex = 27;
            this.lDesdeF.Text = "Desde fecha:";
            // 
            // bMarcarEntr
            // 
            this.bMarcarEntr.Location = new System.Drawing.Point(6, 379);
            this.bMarcarEntr.Name = "bMarcarEntr";
            this.bMarcarEntr.Size = new System.Drawing.Size(237, 23);
            this.bMarcarEntr.TabIndex = 26;
            this.bMarcarEntr.Text = "&Marcar entregado";
            this.bMarcarEntr.UseVisualStyleBackColor = true;
            this.bMarcarEntr.Click += new System.EventHandler(this.bMarcarEntr_Click);
            // 
            // lCantPedEntregados
            // 
            this.lCantPedEntregados.AutoSize = true;
            this.lCantPedEntregados.Location = new System.Drawing.Point(20, 479);
            this.lCantPedEntregados.Name = "lCantPedEntregados";
            this.lCantPedEntregados.Size = new System.Drawing.Size(163, 13);
            this.lCantPedEntregados.TabIndex = 27;
            this.lCantPedEntregados.Text = "Cantidad de pedidos entregados:";
            // 
            // bCerrar
            // 
            this.bCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCerrar.Location = new System.Drawing.Point(446, 474);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 28;
            this.bCerrar.Text = "&Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click_1);
            // 
            // gbClientes
            // 
            this.gbClientes.Location = new System.Drawing.Point(12, 27);
            this.gbClientes.Name = "gbClientes";
            this.gbClientes.Size = new System.Drawing.Size(260, 216);
            this.gbClientes.TabIndex = 19;
            this.gbClientes.TabStop = false;
            // 
            // FEntregas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCerrar;
            this.ClientSize = new System.Drawing.Size(540, 506);
            this.Controls.Add(this.lCantPedEntregados);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.gbProductos);
            this.Controls.Add(this.bEliminarCli);
            this.Controls.Add(this.bModificarCli);
            this.Controls.Add(this.bAgregarCli);
            this.Controls.Add(this.lCantClientes);
            this.Controls.Add(this.lbClientes);
            this.Controls.Add(this.cbSector);
            this.Controls.Add(this.lSector);
            this.Controls.Add(this.lClientes);
            this.Controls.Add(this.msEntregas);
            this.Controls.Add(this.gbClientes);
            this.Controls.Add(this.gbPedidos);
            this.MainMenuStrip = this.msEntregas;
            this.Name = "FEntregas";
            this.Text = "Entregas";
            this.Load += new System.EventHandler(this.FEntregas_Load);
            this.msEntregas.ResumeLayout(false);
            this.msEntregas.PerformLayout();
            this.gbProductos.ResumeLayout(false);
            this.gbProductos.PerformLayout();
            this.gbPedidos.ResumeLayout(false);
            this.gbPedidos.PerformLayout();
            this.gbHorario.ResumeLayout(false);
            this.gbHorario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msEntregas;
        private System.Windows.Forms.ToolStripMenuItem miClientes;
        private System.Windows.Forms.ToolStripMenuItem miClientesN;
        private System.Windows.Forms.ToolStripMenuItem miClientesM;
        private System.Windows.Forms.ToolStripMenuItem miClientesE;
        private System.Windows.Forms.ToolStripMenuItem miProductos;
        private System.Windows.Forms.ToolStripMenuItem miProductosN;
        private System.Windows.Forms.ToolStripMenuItem miProductosM;
        private System.Windows.Forms.ToolStripMenuItem miProductosE;
        private System.Windows.Forms.ToolStripMenuItem miPedidos;
        private System.Windows.Forms.ToolStripMenuItem miPedidosN;
        private System.Windows.Forms.ToolStripMenuItem miPedidosM;
        private System.Windows.Forms.ToolStripMenuItem miPedidosE;
        private System.Windows.Forms.ToolStripMenuItem miAcercaDe;
        private System.Windows.Forms.ToolStripMenuItem miSalir;
        private System.Windows.Forms.Label lClientes;
        private System.Windows.Forms.Label lPedidos;
        private System.Windows.Forms.Label lProductos;
        private System.Windows.Forms.Label lSector;
        private System.Windows.Forms.Label lStock;
        private System.Windows.Forms.ComboBox cbSector;
        private System.Windows.Forms.ComboBox cbStock;
        private System.Windows.Forms.Label lEstado;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.ListBox lbClientes;
        private System.Windows.Forms.ListBox lbProductos;
        private System.Windows.Forms.Label lCantClientes;
        private System.Windows.Forms.Label lCantPedidos;
        private System.Windows.Forms.Label lCantProductos;
        private System.Windows.Forms.Button bAgregarCli;
        private System.Windows.Forms.Button bModificarCli;
        private System.Windows.Forms.Button bEliminarCli;
        private System.Windows.Forms.Button bEliminarProd;
        private System.Windows.Forms.Button bModificarProd;
        private System.Windows.Forms.Button bAgregarProd;
        private System.Windows.Forms.GroupBox gbProductos;
        private System.Windows.Forms.Button bEliminarPed;
        private System.Windows.Forms.Button bModificarPed;
        private System.Windows.Forms.Button bAgregarPed;
        private System.Windows.Forms.GroupBox gbPedidos;
        private System.Windows.Forms.Button bMarcarEntr;
        private System.Windows.Forms.Label lCantPedEntregados;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label lHastaF;
        private System.Windows.Forms.Label lDesdeF;
        private System.Windows.Forms.GroupBox gbHorario;
        private System.Windows.Forms.RadioButton rb15a17;
        private System.Windows.Forms.RadioButton rb13a15;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rb11a13;
        private System.Windows.Forms.MaskedTextBox mtbHastaF;
        private System.Windows.Forms.MaskedTextBox mtbDesdeF;
        private System.Windows.Forms.GroupBox gbClientes;
        private System.Windows.Forms.ListBox lbPedidos;
    }
}

