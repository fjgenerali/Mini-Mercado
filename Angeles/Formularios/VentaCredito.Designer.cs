namespace Angeles.Formularios
{
    partial class VentaCredito
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
            this.grdVentaCredito = new System.Windows.Forms.DataGridView();
            this.carritoVirtualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblT = new System.Windows.Forms.Label();
            this.dropCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grdVentaCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carritoVirtualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdVentaCredito
            // 
            this.grdVentaCredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVentaCredito.Location = new System.Drawing.Point(59, 19);
            this.grdVentaCredito.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdVentaCredito.Name = "grdVentaCredito";
            this.grdVentaCredito.Size = new System.Drawing.Size(240, 190);
            this.grdVentaCredito.TabIndex = 0;
            this.grdVentaCredito.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdVentaCredito_CellContentClick);
            // 
            // carritoVirtualBindingSource
            // 
            this.carritoVirtualBindingSource.DataSource = typeof(BibliotecaAngeles.Modelo.CarritoVirtual);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblT.Location = new System.Drawing.Point(55, 254);
            this.lblT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(42, 20);
            this.lblT.TabIndex = 1;
            this.lblT.Text = "Total";
            // 
            // dropCliente
            // 
            this.dropCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clienteBindingSource, "idCliente", true));
            this.dropCliente.DataSource = this.clienteBindingSource;
            this.dropCliente.DisplayMember = "nombre";
            this.dropCliente.FormattingEnabled = true;
            this.dropCliente.Location = new System.Drawing.Point(119, 324);
            this.dropCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dropCliente.Name = "dropCliente";
            this.dropCliente.Size = new System.Drawing.Size(180, 28);
            this.dropCliente.TabIndex = 2;
            this.dropCliente.ValueMember = "idCliente";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(BibliotecaAngeles.Modelo.Cliente);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(55, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(59, 389);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(240, 48);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 64);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(70, 564);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(653, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(78, 564);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.grdVentaCredito);
            this.panel4.Controls.Add(this.lblT);
            this.panel4.Controls.Add(this.dropCliente);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btnCerrar);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(151, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(359, 455);
            this.panel4.TabIndex = 9;
            // 
            // VentaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(731, 628);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VentaCredito";
            this.Text = "VentaCredito";
            this.Load += new System.EventHandler(this.VentaCredito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVentaCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carritoVirtualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVentaCredito;
        private System.Windows.Forms.BindingSource carritoVirtualBindingSource;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.ComboBox dropCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}