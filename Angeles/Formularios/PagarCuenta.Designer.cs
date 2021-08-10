namespace Angeles.Formularios
{
    partial class PagarCuenta
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
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblEntrea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.dropClientes = new System.Windows.Forms.ComboBox();
            this.txtEntrega = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(BibliotecaAngeles.Modelo.Cliente);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(272, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(272, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(272, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Saldo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblNombre.Location = new System.Drawing.Point(547, 137);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 20);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lblDeuda.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblDeuda.Location = new System.Drawing.Point(566, 207);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(49, 20);
            this.lblDeuda.TabIndex = 5;
            this.lblDeuda.Text = "Saldo";
            // 
            // lblEntrea
            // 
            this.lblEntrea.AutoSize = true;
            this.lblEntrea.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.lblEntrea.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEntrea.Location = new System.Drawing.Point(272, 271);
            this.lblEntrea.Name = "lblEntrea";
            this.lblEntrea.Size = new System.Drawing.Size(56, 20);
            this.lblEntrea.TabIndex = 6;
            this.lblEntrea.Text = "Entrea";
            this.lblEntrea.Click += new System.EventHandler(this.LblEntrea_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label4.Location = new System.Drawing.Point(554, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 7;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Location = new System.Drawing.Point(341, 502);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(240, 48);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lblMensaje.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(427, 234);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 20);
            this.lblMensaje.TabIndex = 9;
            // 
            // dropClientes
            // 
            this.dropClientes.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "idCliente", true));
            this.dropClientes.DataSource = this.clienteBindingSource;
            this.dropClientes.DisplayMember = "nombre";
            this.dropClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.dropClientes.FormattingEnabled = true;
            this.dropClientes.Location = new System.Drawing.Point(415, 41);
            this.dropClientes.Name = "dropClientes";
            this.dropClientes.Size = new System.Drawing.Size(200, 28);
            this.dropClientes.TabIndex = 10;
            this.dropClientes.ValueMember = "idCliente";
            this.dropClientes.SelectedIndexChanged += new System.EventHandler(this.DropClientes_SelectedIndexChanged);
            // 
            // txtEntrega
            // 
            this.txtEntrega.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.txtEntrega.Location = new System.Drawing.Point(515, 271);
            this.txtEntrega.Name = "txtEntrega";
            this.txtEntrega.Size = new System.Drawing.Size(100, 26);
            this.txtEntrega.TabIndex = 11;
            this.txtEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEntrega_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtEntrega);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dropClientes);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblMensaje);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Controls.Add(this.lblDeuda);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblEntrea);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(81, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 364);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 100);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 504);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1054, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(98, 504);
            this.panel4.TabIndex = 15;
            // 
            // PagarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1152, 604);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PagarCuenta";
            this.Text = "PagarCuenta";
            this.Load += new System.EventHandler(this.PagarCuenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblEntrea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.ComboBox dropClientes;
        private System.Windows.Forms.TextBox txtEntrega;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}