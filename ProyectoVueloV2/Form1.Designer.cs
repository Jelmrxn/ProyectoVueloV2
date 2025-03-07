namespace ProyectoVueloV2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoVuel = new System.Windows.Forms.Label();
            this.txtOrige = new System.Windows.Forms.Label();
            this.txtDestin = new System.Windows.Forms.Label();
            this.txtAsientosDisponible = new System.Windows.Forms.Label();
            this.btnAgregarVuelo = new System.Windows.Forms.Button();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.VuelosDisponibles = new System.Windows.Forms.ListBox();
            this.txtCodigoVuelo = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtAsientosDisponibles = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoReserv = new System.Windows.Forms.Label();
            this.txtCodigoReserva = new System.Windows.Forms.TextBox();
            this.txtCantidadReserva = new System.Windows.Forms.Label();
            this.txtCantidadReservas = new System.Windows.Forms.TextBox();
            this.btnReservarVuelo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(439, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 2;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCodigoVuel
            // 
            this.txtCodigoVuel.AutoSize = true;
            this.txtCodigoVuel.Location = new System.Drawing.Point(116, 143);
            this.txtCodigoVuel.Name = "txtCodigoVuel";
            this.txtCodigoVuel.Size = new System.Drawing.Size(104, 20);
            this.txtCodigoVuel.TabIndex = 3;
            this.txtCodigoVuel.Text = "Codigo Vuelo";
            // 
            // txtOrige
            // 
            this.txtOrige.AutoSize = true;
            this.txtOrige.Location = new System.Drawing.Point(116, 221);
            this.txtOrige.Name = "txtOrige";
            this.txtOrige.Size = new System.Drawing.Size(56, 20);
            this.txtOrige.TabIndex = 4;
            this.txtOrige.Text = "Origen";
            // 
            // txtDestin
            // 
            this.txtDestin.AutoSize = true;
            this.txtDestin.Location = new System.Drawing.Point(116, 287);
            this.txtDestin.Name = "txtDestin";
            this.txtDestin.Size = new System.Drawing.Size(64, 20);
            this.txtDestin.TabIndex = 5;
            this.txtDestin.Text = "Destino";
            // 
            // txtAsientosDisponible
            // 
            this.txtAsientosDisponible.AutoSize = true;
            this.txtAsientosDisponible.Location = new System.Drawing.Point(116, 342);
            this.txtAsientosDisponible.Name = "txtAsientosDisponible";
            this.txtAsientosDisponible.Size = new System.Drawing.Size(157, 20);
            this.txtAsientosDisponible.TabIndex = 6;
            this.txtAsientosDisponible.Text = "Asientos Disponibles";
            // 
            // btnAgregarVuelo
            // 
            this.btnAgregarVuelo.Location = new System.Drawing.Point(481, 221);
            this.btnAgregarVuelo.Name = "btnAgregarVuelo";
            this.btnAgregarVuelo.Size = new System.Drawing.Size(160, 66);
            this.btnAgregarVuelo.TabIndex = 7;
            this.btnAgregarVuelo.Text = "Agregar Vuelo";
            this.btnAgregarVuelo.UseVisualStyleBackColor = true;
            this.btnAgregarVuelo.Click += new System.EventHandler(this.btnAgregarVuelo_Click);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(481, 143);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(214, 26);
            this.dtpFechaSalida.TabIndex = 8;
            // 
            // VuelosDisponibles
            // 
            this.VuelosDisponibles.FormattingEnabled = true;
            this.VuelosDisponibles.ItemHeight = 20;
            this.VuelosDisponibles.Location = new System.Drawing.Point(700, 209);
            this.VuelosDisponibles.Name = "VuelosDisponibles";
            this.VuelosDisponibles.Size = new System.Drawing.Size(352, 164);
            this.VuelosDisponibles.TabIndex = 9;
            this.VuelosDisponibles.SelectedIndexChanged += new System.EventHandler(this.VuelosDisponibles_SelectedIndexChanged);
            // 
            // txtCodigoVuelo
            // 
            this.txtCodigoVuelo.Location = new System.Drawing.Point(234, 140);
            this.txtCodigoVuelo.Name = "txtCodigoVuelo";
            this.txtCodigoVuelo.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoVuelo.TabIndex = 10;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(234, 221);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(100, 26);
            this.txtOrigen.TabIndex = 11;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(234, 287);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(100, 26);
            this.txtDestino.TabIndex = 12;
            // 
            // txtAsientosDisponibles
            // 
            this.txtAsientosDisponibles.Location = new System.Drawing.Point(312, 342);
            this.txtAsientosDisponibles.Name = "txtAsientosDisponibles";
            this.txtAsientosDisponibles.Size = new System.Drawing.Size(100, 26);
            this.txtAsientosDisponibles.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(328, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "REGISTRO DE VUELOS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "RESERVA DEVUELOS";
            // 
            // txtCodigoReserv
            // 
            this.txtCodigoReserv.AutoSize = true;
            this.txtCodigoReserv.Location = new System.Drawing.Point(131, 534);
            this.txtCodigoReserv.Name = "txtCodigoReserv";
            this.txtCodigoReserv.Size = new System.Drawing.Size(122, 20);
            this.txtCodigoReserv.TabIndex = 16;
            this.txtCodigoReserv.Text = "Codigo Reserva";
            // 
            // txtCodigoReserva
            // 
            this.txtCodigoReserva.Location = new System.Drawing.Point(309, 534);
            this.txtCodigoReserva.Name = "txtCodigoReserva";
            this.txtCodigoReserva.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoReserva.TabIndex = 17;
            // 
            // txtCantidadReserva
            // 
            this.txtCantidadReserva.AutoSize = true;
            this.txtCantidadReserva.Location = new System.Drawing.Point(131, 607);
            this.txtCantidadReserva.Name = "txtCantidadReserva";
            this.txtCantidadReserva.Size = new System.Drawing.Size(166, 20);
            this.txtCantidadReserva.TabIndex = 18;
            this.txtCantidadReserva.Text = "Cantidad de Reservas";
            // 
            // txtCantidadReservas
            // 
            this.txtCantidadReservas.Location = new System.Drawing.Point(339, 604);
            this.txtCantidadReservas.Name = "txtCantidadReservas";
            this.txtCantidadReservas.Size = new System.Drawing.Size(100, 26);
            this.txtCantidadReservas.TabIndex = 19;
            // 
            // btnReservarVuelo
            // 
            this.btnReservarVuelo.Location = new System.Drawing.Point(535, 514);
            this.btnReservarVuelo.Name = "btnReservarVuelo";
            this.btnReservarVuelo.Size = new System.Drawing.Size(160, 66);
            this.btnReservarVuelo.TabIndex = 20;
            this.btnReservarVuelo.Text = "Reserva de Vuelo";
            this.btnReservarVuelo.UseVisualStyleBackColor = true;
            this.btnReservarVuelo.Click += new System.EventHandler(this.btnReservarVuelo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 982);
            this.Controls.Add(this.btnReservarVuelo);
            this.Controls.Add(this.txtCantidadReservas);
            this.Controls.Add(this.txtCantidadReserva);
            this.Controls.Add(this.txtCodigoReserva);
            this.Controls.Add(this.txtCodigoReserv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAsientosDisponibles);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtCodigoVuelo);
            this.Controls.Add(this.VuelosDisponibles);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.btnAgregarVuelo);
            this.Controls.Add(this.txtAsientosDisponible);
            this.Controls.Add(this.txtDestin);
            this.Controls.Add(this.txtOrige);
            this.Controls.Add(this.txtCodigoVuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtCodigoVuel;
        private System.Windows.Forms.Label txtOrige;
        private System.Windows.Forms.Label txtDestin;
        private System.Windows.Forms.Label txtAsientosDisponible;
        private System.Windows.Forms.Button btnAgregarVuelo;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.ListBox VuelosDisponibles;
        private System.Windows.Forms.TextBox txtCodigoVuelo;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtAsientosDisponibles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtCodigoReserv;
        private System.Windows.Forms.TextBox txtCodigoReserva;
        private System.Windows.Forms.Label txtCantidadReserva;
        private System.Windows.Forms.TextBox txtCantidadReservas;
        private System.Windows.Forms.Button btnReservarVuelo;
    }
}

