namespace _20200525_Entrega_final
{
    partial class FCliente
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
            this.cbZona = new System.Windows.Forms.ComboBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.tbDomicilio = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lDomicilio = new System.Windows.Forms.Label();
            this.lZona = new System.Windows.Forms.Label();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.epTel = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTel)).BeginInit();
            this.SuspendLayout();
            // 
            // cbZona
            // 
            this.cbZona.FormattingEnabled = true;
            this.cbZona.Items.AddRange(new object[] {
            "Seleccionar...",
            "Norte",
            "Sur",
            "Centro"});
            this.cbZona.Location = new System.Drawing.Point(64, 91);
            this.cbZona.Name = "cbZona";
            this.cbZona.Size = new System.Drawing.Size(87, 21);
            this.cbZona.TabIndex = 4;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(64, 13);
            this.mtbTelefono.Mask = "(999)000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(87, 20);
            this.mtbTelefono.TabIndex = 1;
            this.mtbTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.mtbTelefono_Validating);
            // 
            // tbDomicilio
            // 
            this.tbDomicilio.Location = new System.Drawing.Point(64, 65);
            this.tbDomicilio.Name = "tbDomicilio";
            this.tbDomicilio.Size = new System.Drawing.Size(87, 20);
            this.tbDomicilio.TabIndex = 3;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(64, 39);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(87, 20);
            this.tbNombre.TabIndex = 2;
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Location = new System.Drawing.Point(6, 16);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(52, 13);
            this.lTelefono.TabIndex = 4;
            this.lTelefono.Text = "Teléfono:";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Location = new System.Drawing.Point(6, 42);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(47, 13);
            this.lNombre.TabIndex = 5;
            this.lNombre.Text = "Nombre:";
            // 
            // lDomicilio
            // 
            this.lDomicilio.AutoSize = true;
            this.lDomicilio.Location = new System.Drawing.Point(6, 68);
            this.lDomicilio.Name = "lDomicilio";
            this.lDomicilio.Size = new System.Drawing.Size(52, 13);
            this.lDomicilio.TabIndex = 6;
            this.lDomicilio.Text = "Domicilio:";
            // 
            // lZona
            // 
            this.lZona.AutoSize = true;
            this.lZona.Location = new System.Drawing.Point(6, 94);
            this.lZona.Name = "lZona";
            this.lZona.Size = new System.Drawing.Size(35, 13);
            this.lZona.TabIndex = 7;
            this.lZona.Text = "Zona:";
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.lZona);
            this.gbCliente.Controls.Add(this.mtbTelefono);
            this.gbCliente.Controls.Add(this.lDomicilio);
            this.gbCliente.Controls.Add(this.cbZona);
            this.gbCliente.Controls.Add(this.lNombre);
            this.gbCliente.Controls.Add(this.tbDomicilio);
            this.gbCliente.Controls.Add(this.lTelefono);
            this.gbCliente.Controls.Add(this.tbNombre);
            this.gbCliente.Location = new System.Drawing.Point(12, 12);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(157, 122);
            this.gbCliente.TabIndex = 8;
            this.gbCliente.TabStop = false;
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
            // epTel
            // 
            this.epTel.ContainerControl = this;
            // 
            // FCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 173);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.gbCliente);
            this.Name = "FCliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FCliente_Load);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbZona;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.TextBox tbDomicilio;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lDomicilio;
        private System.Windows.Forms.Label lZona;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ErrorProvider epTel;
    }
}