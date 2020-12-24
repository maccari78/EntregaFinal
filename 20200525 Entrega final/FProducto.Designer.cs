namespace _20200525_Entrega_final
{
    partial class FProducto
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
            this.bCancelar = new System.Windows.Forms.Button();
            this.bAceptar = new System.Windows.Forms.Button();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.mtbPrecio = new System.Windows.Forms.MaskedTextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.mtbCodigo = new System.Windows.Forms.MaskedTextBox();
            this.lCantidad = new System.Windows.Forms.Label();
            this.lDescripcion = new System.Windows.Forms.Label();
            this.lCodigo = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.epCodigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigo)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(94, 141);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 6;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(12, 141);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 5;
            this.bAceptar.Text = "&Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.nudCantidad);
            this.gbProducto.Controls.Add(this.mtbPrecio);
            this.gbProducto.Controls.Add(this.lPrecio);
            this.gbProducto.Controls.Add(this.mtbCodigo);
            this.gbProducto.Controls.Add(this.lCantidad);
            this.gbProducto.Controls.Add(this.lDescripcion);
            this.gbProducto.Controls.Add(this.lCodigo);
            this.gbProducto.Controls.Add(this.tbDescripcion);
            this.gbProducto.Location = new System.Drawing.Point(12, 12);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(157, 122);
            this.gbProducto.TabIndex = 14;
            this.gbProducto.TabStop = false;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(78, 66);
            this.nudCantidad.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(73, 20);
            this.nudCantidad.TabIndex = 3;
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbPrecio
            // 
            this.mtbPrecio.Location = new System.Drawing.Point(78, 91);
            this.mtbPrecio.Mask = "9999,99";
            this.mtbPrecio.Name = "mtbPrecio";
            this.mtbPrecio.Size = new System.Drawing.Size(73, 20);
            this.mtbPrecio.TabIndex = 4;
            this.mtbPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbPrecio.ValidatingType = typeof(int);
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Location = new System.Drawing.Point(6, 94);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(40, 13);
            this.lPrecio.TabIndex = 7;
            this.lPrecio.Text = "Precio:";
            // 
            // mtbCodigo
            // 
            this.mtbCodigo.Location = new System.Drawing.Point(78, 13);
            this.mtbCodigo.Mask = "999";
            this.mtbCodigo.Name = "mtbCodigo";
            this.mtbCodigo.Size = new System.Drawing.Size(73, 20);
            this.mtbCodigo.TabIndex = 1;
            this.mtbCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mtbCodigo.ValidatingType = typeof(int);
            this.mtbCodigo.Validating += new System.ComponentModel.CancelEventHandler(this.mtbCodigo_Validating);
            // 
            // lCantidad
            // 
            this.lCantidad.AutoSize = true;
            this.lCantidad.Location = new System.Drawing.Point(6, 68);
            this.lCantidad.Name = "lCantidad";
            this.lCantidad.Size = new System.Drawing.Size(52, 13);
            this.lCantidad.TabIndex = 6;
            this.lCantidad.Text = "Cantidad:";
            // 
            // lDescripcion
            // 
            this.lDescripcion.AutoSize = true;
            this.lDescripcion.Location = new System.Drawing.Point(6, 42);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lDescripcion.TabIndex = 5;
            this.lDescripcion.Text = "Descripción:";
            // 
            // lCodigo
            // 
            this.lCodigo.AutoSize = true;
            this.lCodigo.Location = new System.Drawing.Point(6, 16);
            this.lCodigo.Name = "lCodigo";
            this.lCodigo.Size = new System.Drawing.Size(43, 13);
            this.lCodigo.TabIndex = 4;
            this.lCodigo.Text = "Código:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(78, 39);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(73, 20);
            this.tbDescripcion.TabIndex = 2;
            // 
            // epCodigo
            // 
            this.epCodigo.ContainerControl = this;
            // 
            // FProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(179, 174);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.gbProducto);
            this.Name = "FProducto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.FProducto_Load);
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCodigo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.MaskedTextBox mtbPrecio;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.MaskedTextBox mtbCodigo;
        private System.Windows.Forms.Label lCantidad;
        private System.Windows.Forms.Label lDescripcion;
        private System.Windows.Forms.Label lCodigo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.ErrorProvider epCodigo;
    }
}