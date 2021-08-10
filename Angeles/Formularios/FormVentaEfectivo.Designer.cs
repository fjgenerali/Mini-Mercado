namespace Angeles.Formularios
{
    partial class FormVentaEfectivo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentaEfectivo));
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panelLaterIq = new System.Windows.Forms.Panel();
            this.panelLateralDer = new System.Windows.Forms.Panel();
            this.panelGrid = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtPagaCon = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelBajo = new System.Windows.Forms.Panel();
            this.btnVender = new System.Windows.Forms.Button();
            this.paneGridProd = new System.Windows.Forms.Panel();
            this.gridProd = new System.Windows.Forms.DataGridView();
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
            this.panelGridVent = new System.Windows.Forms.Panel();
            this.gridVenta = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pVentaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoVirtualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelTop.SuspendLayout();
            this.panelGrid.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBajo.SuspendLayout();
            this.paneGridProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.panelGridVent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoVirtualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnBuscar);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.txtCodigo);
            this.panelTop.Controls.Add(this.txtNombre);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1386, 151);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelTop_Paint);
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
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(545, 80);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(150, 26);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(234, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 26);
            this.txtNombre.TabIndex = 0;
            // 
            // panelLaterIq
            // 
            this.panelLaterIq.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLaterIq.Location = new System.Drawing.Point(0, 151);
            this.panelLaterIq.Name = "panelLaterIq";
            this.panelLaterIq.Size = new System.Drawing.Size(33, 562);
            this.panelLaterIq.TabIndex = 2;
            // 
            // panelLateralDer
            // 
            this.panelLateralDer.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLateralDer.Location = new System.Drawing.Point(1352, 151);
            this.panelLateralDer.Name = "panelLateralDer";
            this.panelLateralDer.Size = new System.Drawing.Size(34, 562);
            this.panelLateralDer.TabIndex = 3;
            // 
            // panelGrid
            // 
            this.panelGrid.Controls.Add(this.button1);
            this.panelGrid.Controls.Add(this.btnAgregar);
            this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Location = new System.Drawing.Point(447, 151);
            this.panelGrid.Name = "panelGrid";
            this.panelGrid.Size = new System.Drawing.Size(905, 332);
            this.panelGrid.TabIndex = 5;
            this.panelGrid.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGrid_Paint);
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
            this.button1.Location = new System.Drawing.Point(8, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "Quitar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
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
            this.btnAgregar.Location = new System.Drawing.Point(8, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(143, 44);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.txtPagaCon);
            this.panel1.Controls.Add(this.lblCambio);
            this.panel1.Location = new System.Drawing.Point(411, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(78, 115);
            this.panel1.TabIndex = 19;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTotal.Location = new System.Drawing.Point(17, 13);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(17, 19);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.Text = "0";
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Location = new System.Drawing.Point(14, 48);
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Size = new System.Drawing.Size(42, 20);
            this.txtPagaCon.TabIndex = 18;
            this.txtPagaCon.TextChanged += new System.EventHandler(this.TxtPagaCon_TextChanged);
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.lblCambio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCambio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambio.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCambio.Location = new System.Drawing.Point(17, 87);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(17, 19);
            this.lblCambio.TabIndex = 17;
            this.lblCambio.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(314, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cambio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(314, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(314, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Paga con";
            // 
            // panelBajo
            // 
            this.panelBajo.Controls.Add(this.btnVender);
            this.panelBajo.Controls.Add(this.label3);
            this.panelBajo.Controls.Add(this.panel1);
            this.panelBajo.Controls.Add(this.label4);
            this.panelBajo.Controls.Add(this.label5);
            this.panelBajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBajo.Location = new System.Drawing.Point(33, 483);
            this.panelBajo.Name = "panelBajo";
            this.panelBajo.Size = new System.Drawing.Size(1319, 230);
            this.panelBajo.TabIndex = 4;
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
            this.btnVender.Location = new System.Drawing.Point(612, 64);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(240, 48);
            this.btnVender.TabIndex = 11;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.BtnVender_Click);
            // 
            // paneGridProd
            // 
            this.paneGridProd.Controls.Add(this.gridProd);
            this.paneGridProd.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneGridProd.Location = new System.Drawing.Point(33, 151);
            this.paneGridProd.Name = "paneGridProd";
            this.paneGridProd.Size = new System.Drawing.Size(414, 332);
            this.paneGridProd.TabIndex = 5;
            // 
            // gridProd
            // 
            this.gridProd.AutoGenerateColumns = false;
            this.gridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.codigoDeBarrasDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.pCostoDataGridViewTextBoxColumn,
            this.pVentaDataGridViewTextBoxColumn,
            this.porsGananciaDataGridViewTextBoxColumn,
            this.stockActualDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.stockMinimoDataGridViewTextBoxColumn});
            this.gridProd.DataSource = this.productoBindingSource;
            this.gridProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridProd.Location = new System.Drawing.Point(0, 0);
            this.gridProd.Name = "gridProd";
            this.gridProd.Size = new System.Drawing.Size(414, 280);
            this.gridProd.TabIndex = 0;
            this.gridProd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProd_CellClick);
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
            // panelGridVent
            // 
            this.panelGridVent.Controls.Add(this.gridVenta);
            this.panelGridVent.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelGridVent.Location = new System.Drawing.Point(880, 151);
            this.panelGridVent.Name = "panelGridVent";
            this.panelGridVent.Size = new System.Drawing.Size(472, 332);
            this.panelGridVent.TabIndex = 6;
            // 
            // gridVenta
            // 
            this.gridVenta.AutoGenerateColumns = false;
            this.gridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn1,
            this.pVentaDataGridViewTextBoxColumn1,
            this.cantidadDataGridViewTextBoxColumn});
            this.gridVenta.DataSource = this.productoVirtualBindingSource;
            this.gridVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridVenta.Location = new System.Drawing.Point(0, 0);
            this.gridVenta.Name = "gridVenta";
            this.gridVenta.Size = new System.Drawing.Size(472, 280);
            this.gridVenta.TabIndex = 0;
            this.gridVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridVenta_CellClick);
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
            // FormVentaEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1386, 713);
            this.Controls.Add(this.panelGridVent);
            this.Controls.Add(this.panelGrid);
            this.Controls.Add(this.paneGridProd);
            this.Controls.Add(this.panelBajo);
            this.Controls.Add(this.panelLateralDer);
            this.Controls.Add(this.panelLaterIq);
            this.Controls.Add(this.panelTop);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentaEfectivo";
            this.Text = "FormVentaEfectivo";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelGrid.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBajo.ResumeLayout(false);
            this.panelBajo.PerformLayout();
            this.paneGridProd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.panelGridVent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoVirtualBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panelLaterIq;
        private System.Windows.Forms.Panel panelLateralDer;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.Panel panelBajo;
        private System.Windows.Forms.Panel paneGridProd;
        private System.Windows.Forms.Panel panelGridVent;
        private System.Windows.Forms.DataGridView gridProd;
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
        private System.Windows.Forms.DataGridView gridVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pVentaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productoVirtualBindingSource;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPagaCon;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}