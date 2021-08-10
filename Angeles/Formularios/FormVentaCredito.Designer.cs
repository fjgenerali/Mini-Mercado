namespace Angeles.Formularios
{
    partial class FormVentaCredito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentaCredito));
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelisquierda = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelProd = new System.Windows.Forms.Panel();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.panelLaterIq = new System.Windows.Forms.Panel();
            this.panelDereca = new System.Windows.Forms.Panel();
            this.panelProdVenta = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdVenta = new System.Windows.Forms.DataGridView();
            this.panelLateralDer = new System.Windows.Forms.Panel();
            this.btnVender = new System.Windows.Forms.Button();
            this.panelBajo = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.idProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoVirtualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDeBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pCostoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porsGananciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelisquierda.SuspendLayout();
            this.panelProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.panelDereca.SuspendLayout();
            this.panelProdVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdVenta)).BeginInit();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoVirtualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtCodigo);
            this.panelTop.Controls.Add(this.btnBuscar);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.txtNombre);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1296, 151);
            this.panelTop.TabIndex = 0;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(545, 83);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(150, 26);
            this.txtCodigo.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(713, 67);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(240, 48);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(401, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo de barras";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(160, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(234, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // panelisquierda
            // 
            this.panelisquierda.Controls.Add(this.panelProd);
            this.panelisquierda.Controls.Add(this.panelLaterIq);
            this.panelisquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelisquierda.Location = new System.Drawing.Point(0, 151);
            this.panelisquierda.Name = "panelisquierda";
            this.panelisquierda.Size = new System.Drawing.Size(426, 628);
            this.panelisquierda.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(21, 69);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 48);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // panelProd
            // 
            this.panelProd.Controls.Add(this.gridProductos);
            this.panelProd.Location = new System.Drawing.Point(33, 0);
            this.panelProd.Name = "panelProd";
            this.panelProd.Size = new System.Drawing.Size(388, 433);
            this.panelProd.TabIndex = 2;
            // 
            // gridProductos
            // 
            this.gridProductos.AutoGenerateColumns = false;
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.codigoDeBarrasDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.pCostoDataGridViewTextBoxColumn,
            this.pVentaDataGridViewTextBoxColumn,
            this.porsGananciaDataGridViewTextBoxColumn,
            this.stockActualDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.stockMinimoDataGridViewTextBoxColumn});
            this.gridProductos.DataSource = this.productoBindingSource;
            this.gridProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridProductos.Location = new System.Drawing.Point(0, 0);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(388, 298);
            this.gridProductos.TabIndex = 0;
            this.gridProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProductos_CellClick);
            // 
            // panelLaterIq
            // 
            this.panelLaterIq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLaterIq.Location = new System.Drawing.Point(0, 0);
            this.panelLaterIq.Name = "panelLaterIq";
            this.panelLaterIq.Size = new System.Drawing.Size(33, 628);
            this.panelLaterIq.TabIndex = 1;
            // 
            // panelDereca
            // 
            this.panelDereca.Controls.Add(this.panelProdVenta);
            this.panelDereca.Controls.Add(this.panelLateralDer);
            this.panelDereca.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDereca.Location = new System.Drawing.Point(699, 151);
            this.panelDereca.Name = "panelDereca";
            this.panelDereca.Size = new System.Drawing.Size(597, 628);
            this.panelDereca.TabIndex = 2;
            // 
            // panelProdVenta
            // 
            this.panelProdVenta.Controls.Add(this.grdVenta);
            this.panelProdVenta.Location = new System.Drawing.Point(101, 6);
            this.panelProdVenta.Name = "panelProdVenta";
            this.panelProdVenta.Size = new System.Drawing.Size(442, 420);
            this.panelProdVenta.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotal.Location = new System.Drawing.Point(585, 537);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 19);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(467, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total";
            // 
            // grdVenta
            // 
            this.grdVenta.AutoGenerateColumns = false;
            this.grdVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn1,
            this.pVentaDataGridViewTextBoxColumn1,
            this.cantidadDataGridViewTextBoxColumn});
            this.grdVenta.DataSource = this.productoVirtualBindingSource;
            this.grdVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.grdVenta.Location = new System.Drawing.Point(0, 0);
            this.grdVenta.Name = "grdVenta";
            this.grdVenta.Size = new System.Drawing.Size(442, 304);
            this.grdVenta.TabIndex = 0;
            this.grdVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdVenta_CellClick);
            // 
            // panelLateralDer
            // 
            this.panelLateralDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLateralDer.Location = new System.Drawing.Point(563, 0);
            this.panelLateralDer.Name = "panelLateralDer";
            this.panelLateralDer.Size = new System.Drawing.Size(34, 628);
            this.panelLateralDer.TabIndex = 1;
            // 
            // btnVender
            // 
            this.btnVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnVender.FlatAppearance.BorderSize = 0;
            this.btnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVender.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.btnVender.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVender.Image = ((System.Drawing.Image)(resources.GetObject("btnVender.Image")));
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVender.Location = new System.Drawing.Point(426, 615);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(240, 48);
            this.btnVender.TabIndex = 11;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // panelBajo
            // 
            this.panelBajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBajo.Location = new System.Drawing.Point(426, 669);
            this.panelBajo.Name = "panelBajo";
            this.panelBajo.Size = new System.Drawing.Size(273, 110);
            this.panelBajo.TabIndex = 3;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.button1);
            this.panelGrid.Controls.Add(this.btnAgregar);
            this.panelGrid.Location = new System.Drawing.Point(438, 163);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(177, 298);
            this.panelGrid.TabIndex = 4;
            // 
            // idProductoDataGridViewTextBoxColumn1
            // 
            this.idProductoDataGridViewTextBoxColumn1.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn1.HeaderText = "idProducto";
            this.idProductoDataGridViewTextBoxColumn1.Name = "idProductoDataGridViewTextBoxColumn1";
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // pVentaDataGridViewTextBoxColumn1
            // 
            this.pVentaDataGridViewTextBoxColumn1.DataPropertyName = "pVenta";
            this.pVentaDataGridViewTextBoxColumn1.HeaderText = "pVenta";
            this.pVentaDataGridViewTextBoxColumn1.Name = "pVentaDataGridViewTextBoxColumn1";
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            // 
            // productoVirtualBindingSource
            // 
            this.productoVirtualBindingSource.DataSource = typeof(BibliotecaAngeles.Modelo.ProductoVirtual);
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            // 
            // codigoDeBarrasDataGridViewTextBoxColumn
            // 
            this.codigoDeBarrasDataGridViewTextBoxColumn.DataPropertyName = "codigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn.HeaderText = "codigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn.Name = "codigoDeBarrasDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // pCostoDataGridViewTextBoxColumn
            // 
            this.pCostoDataGridViewTextBoxColumn.DataPropertyName = "pCosto";
            this.pCostoDataGridViewTextBoxColumn.HeaderText = "pCosto";
            this.pCostoDataGridViewTextBoxColumn.Name = "pCostoDataGridViewTextBoxColumn";
            // 
            // pVentaDataGridViewTextBoxColumn
            // 
            this.pVentaDataGridViewTextBoxColumn.DataPropertyName = "pVenta";
            this.pVentaDataGridViewTextBoxColumn.HeaderText = "pVenta";
            this.pVentaDataGridViewTextBoxColumn.Name = "pVentaDataGridViewTextBoxColumn";
            // 
            // porsGananciaDataGridViewTextBoxColumn
            // 
            this.porsGananciaDataGridViewTextBoxColumn.DataPropertyName = "porsGanancia";
            this.porsGananciaDataGridViewTextBoxColumn.HeaderText = "porsGanancia";
            this.porsGananciaDataGridViewTextBoxColumn.Name = "porsGananciaDataGridViewTextBoxColumn";
            // 
            // stockActualDataGridViewTextBoxColumn
            // 
            this.stockActualDataGridViewTextBoxColumn.DataPropertyName = "stockActual";
            this.stockActualDataGridViewTextBoxColumn.HeaderText = "stockActual";
            this.stockActualDataGridViewTextBoxColumn.Name = "stockActualDataGridViewTextBoxColumn";
            // 
            // ivaDataGridViewTextBoxColumn
            // 
            this.ivaDataGridViewTextBoxColumn.DataPropertyName = "iva";
            this.ivaDataGridViewTextBoxColumn.HeaderText = "iva";
            this.ivaDataGridViewTextBoxColumn.Name = "ivaDataGridViewTextBoxColumn";
            // 
            // stockMinimoDataGridViewTextBoxColumn
            // 
            this.stockMinimoDataGridViewTextBoxColumn.DataPropertyName = "stockMinimo";
            this.stockMinimoDataGridViewTextBoxColumn.HeaderText = "stockMinimo";
            this.stockMinimoDataGridViewTextBoxColumn.Name = "stockMinimoDataGridViewTextBoxColumn";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(BibliotecaAngeles.Modelo.Producto);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(21, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 44);
            this.button1.TabIndex = 21;
            this.button1.Text = "Quitar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FormVentaCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1296, 779);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelBajo);
            this.Controls.Add(this.panelDereca);
            this.Controls.Add(this.panelisquierda);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentaCredito";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormVentaCredito_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelisquierda.ResumeLayout(false);
            this.panelProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.panelDereca.ResumeLayout(false);
            this.panelProdVenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdVenta)).EndInit();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productoVirtualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panelisquierda;
        private System.Windows.Forms.Panel panelDereca;
        private System.Windows.Forms.Panel panelBajo;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelProd;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCostoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porsGananciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.Panel panelLaterIq;
        private System.Windows.Forms.Panel panelProdVenta;
        private System.Windows.Forms.DataGridView grdVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pVentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productoVirtualBindingSource;
        private System.Windows.Forms.Panel panelLateralDer;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button button1;
    }
}