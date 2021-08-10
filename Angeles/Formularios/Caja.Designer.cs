namespace Angeles.Formularios
{
    partial class Caja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDia = new System.Windows.Forms.Button();
            this.btnMes = new System.Windows.Forms.Button();
            this.btnAnio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGanancia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCredito = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boletaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grdSeleccion = new System.Windows.Forms.DataGridView();
            this.detalleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDetalleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantUnidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdBoleta1 = new System.Windows.Forms.DataGridView();
            this.boletaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.idBoletaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeleccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBoleta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDia
            // 
            this.btnDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnDia.FlatAppearance.BorderSize = 0;
            this.btnDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDia.Location = new System.Drawing.Point(609, 48);
            this.btnDia.Margin = new System.Windows.Forms.Padding(4);
            this.btnDia.Name = "btnDia";
            this.btnDia.Size = new System.Drawing.Size(240, 48);
            this.btnDia.TabIndex = 0;
            this.btnDia.Text = "Dia";
            this.btnDia.UseVisualStyleBackColor = false;
            this.btnDia.Click += new System.EventHandler(this.BtnDia_Click);
            // 
            // btnMes
            // 
            this.btnMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnMes.FlatAppearance.BorderSize = 0;
            this.btnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMes.Location = new System.Drawing.Point(361, 48);
            this.btnMes.Margin = new System.Windows.Forms.Padding(4);
            this.btnMes.Name = "btnMes";
            this.btnMes.Size = new System.Drawing.Size(240, 48);
            this.btnMes.TabIndex = 1;
            this.btnMes.Text = "Mes";
            this.btnMes.UseVisualStyleBackColor = false;
            this.btnMes.Click += new System.EventHandler(this.BtnMes_Click);
            // 
            // btnAnio
            // 
            this.btnAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnAnio.FlatAppearance.BorderSize = 0;
            this.btnAnio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnio.Location = new System.Drawing.Point(113, 48);
            this.btnAnio.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnio.Name = "btnAnio";
            this.btnAnio.Size = new System.Drawing.Size(240, 48);
            this.btnAnio.TabIndex = 2;
            this.btnAnio.Text = "Año";
            this.btnAnio.UseVisualStyleBackColor = false;
            this.btnAnio.Click += new System.EventHandler(this.BtnAnio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(477, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ganancia";
            // 
            // lblGanancia
            // 
            this.lblGanancia.AutoSize = true;
            this.lblGanancia.Location = new System.Drawing.Point(641, 28);
            this.lblGanancia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGanancia.Name = "lblGanancia";
            this.lblGanancia.Size = new System.Drawing.Size(0, 17);
            this.lblGanancia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Credito";
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(276, 28);
            this.lblCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(0, 17);
            this.lblCredito.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grdBoleta1);
            this.panel1.Controls.Add(this.grdSeleccion);
            this.panel1.Location = new System.Drawing.Point(113, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 511);
            this.panel1.TabIndex = 7;
            // 
            // detalleBindingSource
            // 
            this.detalleBindingSource.DataSource = typeof(BibliotecaAngeles.Modelo.Detalle);
            // 
            // boletaBindingSource1
            // 
            this.boletaBindingSource1.DataSource = typeof(BibliotecaAngeles.Modelo.Boleta);
            // 
            // boletaBindingSource
            // 
            this.boletaBindingSource.DataSource = typeof(BibliotecaAngeles.Modelo.Boleta);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAnio);
            this.panel2.Controls.Add(this.btnDia);
            this.panel2.Controls.Add(this.btnMes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 100);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(113, 602);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(873, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 602);
            this.panel4.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblCredito);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lblGanancia);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(113, 620);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(760, 82);
            this.panel5.TabIndex = 11;
            // 
            // grdSeleccion
            // 
            this.grdSeleccion.AutoGenerateColumns = false;
            this.grdSeleccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSeleccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDetalleDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn,
            this.cantUnidadesDataGridViewTextBoxColumn,
            this.productoDataGridViewTextBoxColumn,
            this.boletaDataGridViewTextBoxColumn});
            this.grdSeleccion.DataSource = this.detalleBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdSeleccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdSeleccion.Location = new System.Drawing.Point(153, 292);
            this.grdSeleccion.Name = "grdSeleccion";
            this.grdSeleccion.Size = new System.Drawing.Size(444, 171);
            this.grdSeleccion.TabIndex = 1;
            this.grdSeleccion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdSeleccion_CellClick);
            this.grdSeleccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdSeleccion_CellContentClick);
            // 
            // detalleBindingSource1
            // 
            this.detalleBindingSource1.DataSource = typeof(BibliotecaAngeles.Modelo.Detalle);
            // 
            // idDetalleDataGridViewTextBoxColumn
            // 
            this.idDetalleDataGridViewTextBoxColumn.DataPropertyName = "idDetalle";
            this.idDetalleDataGridViewTextBoxColumn.HeaderText = "idDetalle";
            this.idDetalleDataGridViewTextBoxColumn.Name = "idDetalleDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // cantUnidadesDataGridViewTextBoxColumn
            // 
            this.cantUnidadesDataGridViewTextBoxColumn.DataPropertyName = "cantUnidades";
            this.cantUnidadesDataGridViewTextBoxColumn.HeaderText = "cantUnidades";
            this.cantUnidadesDataGridViewTextBoxColumn.Name = "cantUnidadesDataGridViewTextBoxColumn";
            // 
            // productoDataGridViewTextBoxColumn
            // 
            this.productoDataGridViewTextBoxColumn.DataPropertyName = "producto";
            this.productoDataGridViewTextBoxColumn.HeaderText = "producto";
            this.productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            // 
            // boletaDataGridViewTextBoxColumn
            // 
            this.boletaDataGridViewTextBoxColumn.DataPropertyName = "boleta";
            this.boletaDataGridViewTextBoxColumn.HeaderText = "boleta";
            this.boletaDataGridViewTextBoxColumn.Name = "boletaDataGridViewTextBoxColumn";
            // 
            // grdBoleta1
            // 
            this.grdBoleta1.AutoGenerateColumns = false;
            this.grdBoleta1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBoleta1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idBoletaDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.clienteDataGridViewTextBoxColumn});
            this.grdBoleta1.DataSource = this.boletaBindingSource2;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.InfoText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBoleta1.DefaultCellStyle = dataGridViewCellStyle4;
            this.grdBoleta1.Location = new System.Drawing.Point(153, 39);
            this.grdBoleta1.Name = "grdBoleta1";
            this.grdBoleta1.Size = new System.Drawing.Size(444, 203);
            this.grdBoleta1.TabIndex = 2;
            this.grdBoleta1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdBoleta1_CellClick);
            // 
            // boletaBindingSource2
            // 
            this.boletaBindingSource2.DataSource = typeof(BibliotecaAngeles.Modelo.Boleta);
            // 
            // idBoletaDataGridViewTextBoxColumn
            // 
            this.idBoletaDataGridViewTextBoxColumn.DataPropertyName = "idBoleta";
            this.idBoletaDataGridViewTextBoxColumn.HeaderText = "idBoleta";
            this.idBoletaDataGridViewTextBoxColumn.Name = "idBoletaDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            // 
            // clienteDataGridViewTextBoxColumn
            // 
            this.clienteDataGridViewTextBoxColumn.DataPropertyName = "Cliente";
            this.clienteDataGridViewTextBoxColumn.HeaderText = "Cliente";
            this.clienteDataGridViewTextBoxColumn.Name = "clienteDataGridViewTextBoxColumn";
            // 
            // Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1070, 702);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Caja";
            this.Text = "Caja";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdSeleccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdBoleta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boletaBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDia;
        private System.Windows.Forms.Button btnMes;
        private System.Windows.Forms.Button btnAnio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGanancia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCredito;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.BindingSource detalleBindingSource;
        private System.Windows.Forms.BindingSource boletaBindingSource;
        private System.Windows.Forms.BindingSource boletaBindingSource1;
        private System.Windows.Forms.DataGridView grdSeleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetalleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantUnidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource detalleBindingSource1;
        private System.Windows.Forms.DataGridView grdBoleta1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBoletaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource boletaBindingSource2;
    }
}