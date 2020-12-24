namespace _20200525_Entrega_final
{
    partial class FPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lFecha = new System.Windows.Forms.Label();
            this.lCliente = new System.Windows.Forms.Label();
            this.lProducto = new System.Windows.Forms.Label();
            this.lCantStock = new System.Windows.Forms.Label();
            this.lCantidad = new System.Windows.Forms.Label();
            this.mtbFecha = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelCliente = new System.Windows.Forms.MaskedTextBox();
            this.mtbCodigoProd = new System.Windows.Forms.MaskedTextBox();
            this.cbNombreCli = new System.Windows.Forms.ComboBox();
            this.cbDescripcionProd = new System.Windows.Forms.ComboBox();
            this.nudPedido = new System.Windows.Forms.NumericUpDown();
            this.checkEntregado = new System.Windows.Forms.CheckBox();
            this.rb11a13 = new System.Windows.Forms.RadioButton();
            this.rb13a15 = new System.Windows.Forms.RadioButton();
            this.rb15a17 = new System.Windows.Forms.RadioButton();
            this.gbHorario = new System.Windows.Forms.GroupBox();
            this.gbPedido = new System.Windows.Forms.GroupBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.epFecha = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudPedido)).BeginInit();
            this.gbHorario.SuspendLayout();
            this.gbPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // lFecha
            // 
            this.lFecha.AutoSize = true;
            this.lFecha.Location = new System.Drawing.Point(6, 16);
            this.lFecha.Name = "lFecha";
            this.lFecha.Size = new System.Drawing.Size(40, 13);
            this.lFecha.TabIndex = 0;
            this.lFecha.Text = "Fecha:";
            // 
            // lCliente
            // 
            this.lCliente.AutoSize = true;
            this.lCliente.Location = new System.Drawing.Point(6, 42);
            this.lCliente.Name = "lCliente";
            this.lCliente.Size = new System.Drawing.Size(42, 13);
            this.lCliente.TabIndex = 1;
            this.lCliente.Text = "Cliente:";
            // 
            // lProducto
            // 
            this.lProducto.AutoSize = true;
            this.lProducto.Location = new System.Drawing.Point(6, 96);
            this.lProducto.Name = "lProducto";
            this.lProducto.Size = new System.Drawing.Size(53, 13);
            this.lProducto.TabIndex = 2;
            this.lProducto.Text = "Producto:";
            // 
            // lCantStock
            // 
            this.lCantStock.AutoSize = true;
            this.lCantStock.Location = new System.Drawing.Point(69, 116);
            this.lCantStock.Name = "lCantStock";
            this.lCantStock.Size = new System.Drawing.Size(96, 13);
            this.lCantStock.TabIndex = 3;
            this.lCantStock.Text = "Cantidad en stock:";
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(6, 134);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(52, 13);
            this.lCantidad.TabIndex = 4;
            this.lCantidad.Text = "Cantidad:";
            // 
            // mtbFecha
            // 
            this.mtbFecha.Location = new System.Drawing.Point(72, 13);
            this.mtbFecha.Mask = "00/00/0000";
            this.mtbFecha.Name = "mtbFecha";
            this.mtbFecha.Size = new System.Drawing.Size(129, 20);
            this.mtbFecha.TabIndex = 7;
            this.mtbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtbFecha.ValidatingType = typeof(System.DateTime);
            this.mtbFecha.Validating += new System.ComponentModel.CancelEventHandler(this.mtbFecha_Validating);
            // 
            // mtbTelCliente
            // 
            this.mtbTelCliente.Location = new System.Drawing.Point(72, 39);
            this.mtbTelCliente.Mask = "(999)000-0000";
            this.mtbTelCliente.Name = "mtbTelCliente";
            this.mtbTelCliente.Size = new System.Drawing.Size(129, 20);
            this.mtbTelCliente.TabIndex = 8;
            this.mtbTelCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtbCodigoProd
            // 
            this.mtbCodigoProd.Location = new System.Drawing.Point(72, 93);
            this.mtbCodigoProd.Mask = "999";
            this.mtbCodigoProd.Name = "mtbCodigoProd";
            this.mtbCodigoProd.Size = new System.Drawing.Size(29, 20);
            this.mtbCodigoProd.TabIndex = 9;
            this.mtbCodigoProd.ValidatingType = typeof(int);
            // 
            // cbNombreCli
            // 
            this.cbNombreCli.FormattingEnabled = true;
            this.cbNombreCli.Location = new System.Drawing.Point(72, 65);
            this.cbNombreCli.Name = "cbNombreCli";
            this.cbNombreCli.Size = new System.Drawing.Size(129, 21);
            this.cbNombreCli.TabIndex = 10;
            this.cbNombreCli.SelectedIndexChanged += new System.EventHandler(this.cbNombreCli_SelectedIndexChanged);
            // 
            // cbDescripcionProd
            // 
            this.cbDescripcionProd.FormattingEnabled = true;
            this.cbDescripcionProd.Location = new System.Drawing.Point(107, 92);
            this.cbDescripcionProd.Name = "cbDescripcionProd";
            this.cbDescripcionProd.Size = new System.Drawing.Size(94, 21);
            this.cbDescripcionProd.TabIndex = 11;
            this.cbDescripcionProd.SelectedIndexChanged += new System.EventHandler(this.cbDescripcionProd_SelectedIndexChanged);
            // 
            // nudPedido
            // 
            this.nudPedido.Location = new System.Drawing.Point(72, 132);
            this.nudPedido.Name = "nudPedido";
            this.nudPedido.Size = new System.Drawing.Size(45, 20);
            this.nudPedido.TabIndex = 12;
            // 
            // checkEntregado
            // 
            this.checkEntregado.AutoSize = true;
            this.checkEntregado.Location = new System.Drawing.Point(126, 133);
            this.checkEntregado.Name = "checkEntregado";
            this.checkEntregado.Size = new System.Drawing.Size(75, 17);
            this.checkEntregado.TabIndex = 13;
            this.checkEntregado.Text = "Entregado";
            this.checkEntregado.UseVisualStyleBackColor = true;
            // 
            // rb11a13
            // 
            this.rb11a13.AutoSize = true;
            this.rb11a13.Location = new System.Drawing.Point(17, 19);
            this.rb11a13.Name = "rb11a13";
            this.rb11a13.Size = new System.Drawing.Size(75, 17);
            this.rb11a13.TabIndex = 14;
            this.rb11a13.TabStop = true;
            this.rb11a13.Text = "11 a 13 hs";
            this.rb11a13.UseVisualStyleBackColor = true;
            // 
            // rb13a15
            // 
            this.rb13a15.AutoSize = true;
            this.rb13a15.Location = new System.Drawing.Point(98, 19);
            this.rb13a15.Name = "rb13a15";
            this.rb13a15.Size = new System.Drawing.Size(75, 17);
            this.rb13a15.TabIndex = 15;
            this.rb13a15.TabStop = true;
            this.rb13a15.Text = "13 a 15 hs";
            this.rb13a15.UseVisualStyleBackColor = true;
            // 
            // rb15a17
            // 
            this.rb15a17.AutoSize = true;
            this.rb15a17.Location = new System.Drawing.Point(17, 42);
            this.rb15a17.Name = "rb15a17";
            this.rb15a17.Size = new System.Drawing.Size(75, 17);
            this.rb15a17.TabIndex = 16;
            this.rb15a17.TabStop = true;
            this.rb15a17.Text = "15 a 17 hs";
            this.rb15a17.UseVisualStyleBackColor = true;
            // 
            // gbHorario
            // 
            this.gbHorario.Controls.Add(this.rb11a13);
            this.gbHorario.Controls.Add(this.rb15a17);
            this.gbHorario.Controls.Add(this.rb13a15);
            this.gbHorario.Location = new System.Drawing.Point(9, 158);
            this.gbHorario.Name = "gbHorario";
            this.gbHorario.Size = new System.Drawing.Size(192, 67);
            this.gbHorario.TabIndex = 17;
            this.gbHorario.TabStop = false;
            this.gbHorario.Text = "Horario";
            // 
            // gbPedido
            // 
            this.gbPedido.Controls.Add(this.gbHorario);
            this.gbPedido.Controls.Add(this.lFecha);
            this.gbPedido.Controls.Add(this.checkEntregado);
            this.gbPedido.Controls.Add(this.lCliente);
            this.gbPedido.Controls.Add(this.nudPedido);
            this.gbPedido.Controls.Add(this.lProducto);
            this.gbPedido.Controls.Add(this.cbDescripcionProd);
            this.gbPedido.Controls.Add(this.lCantStock);
            this.gbPedido.Controls.Add(this.cbNombreCli);
            this.gbPedido.Controls.Add(this.lCantidad);
            this.gbPedido.Controls.Add(this.mtbCodigoProd);
            this.gbPedido.Controls.Add(this.mtbFecha);
            this.gbPedido.Controls.Add(this.mtbTelCliente);
            this.gbPedido.Location = new System.Drawing.Point(12, 12);
            this.gbPedido.Name = "gbPedido";
            this.gbPedido.Size = new System.Drawing.Size(210, 235);
            this.gbPedido.TabIndex = 18;
            this.gbPedido.TabStop = false;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(57, 253);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 19;
            this.bAceptar.Text = "&Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(138, 253);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 20;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // epFecha
            // 
            this.epFecha.ContainerControl = this;
            // 
            // FPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 287);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.gbPedido);
            this.Name = "FPedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.FPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPedido)).EndInit();
            this.gbHorario.ResumeLayout(false);
            this.gbHorario.PerformLayout();
            this.gbPedido.ResumeLayout(false);
            this.gbPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epFecha)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lFecha;
        private System.Windows.Forms.Label lCliente;
        private System.Windows.Forms.Label lProducto;
        private System.Windows.Forms.Label lCantStock;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.MaskedTextBox mtbFecha;
        private System.Windows.Forms.MaskedTextBox mtbTelCliente;
        private System.Windows.Forms.MaskedTextBox mtbCodigoProd;
        private System.Windows.Forms.ComboBox cbNombreCli;
        private System.Windows.Forms.ComboBox cbDescripcionProd;
        private System.Windows.Forms.NumericUpDown nudPedido;
        private System.Windows.Forms.CheckBox checkEntregado;
        private System.Windows.Forms.RadioButton rb11a13;
        private System.Windows.Forms.RadioButton rb13a15;
        private System.Windows.Forms.RadioButton rb15a17;
        private System.Windows.Forms.GroupBox gbHorario;
        private System.Windows.Forms.GroupBox gbPedido;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ErrorProvider epFecha;
    }
}