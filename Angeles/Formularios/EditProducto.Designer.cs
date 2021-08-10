namespace Angeles.Formularios
{
    partial class EditProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProducto));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grdProductos = new System.Windows.Forms.DataGridView();
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
            this.pnlEditar = new System.Windows.Forms.Panel();
            this.lblMenaje = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtPorsGanancia = new System.Windows.Forms.TextBox();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.pnlEditar.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1096, 51);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(92, 737);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1004, 51);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 737);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(92, 772);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(912, 16);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAgregar);
            this.panel5.Controls.Add(this.grdProductos);
            this.panel5.Location = new System.Drawing.Point(111, 57);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(772, 317);
            this.panel5.TabIndex = 4;
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
            this.btnAgregar.Location = new System.Drawing.Point(324, 235);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(240, 48);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Seleccionar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // grdProductos
            // 
            this.grdProductos.AutoGenerateColumns = false;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.codigoDeBarrasDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.pCostoDataGridViewTextBoxColumn,
            this.pVentaDataGridViewTextBoxColumn,
            this.porsGananciaDataGridViewTextBoxColumn,
            this.stockActualDataGridViewTextBoxColumn,
            this.ivaDataGridViewTextBoxColumn,
            this.stockMinimoDataGridViewTextBoxColumn});
            this.grdProductos.DataSource = this.productoBindingSource;
            this.grdProductos.Location = new System.Drawing.Point(-1, 30);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductos.Size = new System.Drawing.Size(774, 169);
            this.grdProductos.TabIndex = 17;
            this.grdProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdProductos_CellClick);
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
            // pnlEditar
            // 
            this.pnlEditar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEditar.Controls.Add(this.lblMenaje);
            this.pnlEditar.Controls.Add(this.panel6);
            this.pnlEditar.Controls.Add(this.label1);
            this.pnlEditar.Controls.Add(this.label2);
            this.pnlEditar.Controls.Add(this.label3);
            this.pnlEditar.Controls.Add(this.btnGuardar);
            this.pnlEditar.Controls.Add(this.label4);
            this.pnlEditar.Controls.Add(this.label5);
            this.pnlEditar.Controls.Add(this.label7);
            this.pnlEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.pnlEditar.ForeColor = System.Drawing.SystemColors.Window;
            this.pnlEditar.Location = new System.Drawing.Point(111, 380);
            this.pnlEditar.Name = "pnlEditar";
            this.pnlEditar.Padding = new System.Windows.Forms.Padding(10);
            this.pnlEditar.Size = new System.Drawing.Size(887, 327);
            this.pnlEditar.TabIndex = 20;
            // 
            // lblMenaje
            // 
            this.lblMenaje.AutoSize = true;
            this.lblMenaje.Location = new System.Drawing.Point(574, 257);
            this.lblMenaje.Name = "lblMenaje";
            this.lblMenaje.Size = new System.Drawing.Size(53, 20);
            this.lblMenaje.TabIndex = 20;
            this.lblMenaje.Text = "label6";
            this.lblMenaje.Click += new System.EventHandler(this.LblMenaje_Click);
            // 
            // panel6
            // 
            this.panel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel6.Controls.Add(this.txtCodigoBarra);
            this.panel6.Controls.Add(this.txtStock);
            this.panel6.Controls.Add(this.txtNombre);
            this.panel6.Controls.Add(this.txtPrecioCosto);
            this.panel6.Controls.Add(this.txtPorsGanancia);
            this.panel6.Controls.Add(this.txtStockMin);
            this.panel6.Location = new System.Drawing.Point(305, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(545, 220);
            this.panel6.TabIndex = 19;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.txtCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoBarra.ForeColor = System.Drawing.SystemColors.Window;
            this.txtCodigoBarra.Location = new System.Drawing.Point(0, 43);
            this.txtCodigoBarra.Margin = new System.Windows.Forms.Padding(10);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(545, 29);
            this.txtCodigoBarra.TabIndex = 9;
            this.txtCodigoBarra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoBarra_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStock.Location = new System.Drawing.Point(0, 139);
            this.txtStock.Margin = new System.Windows.Forms.Padding(10);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(545, 29);
            this.txtStock.TabIndex = 10;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStock.TextChanged += new System.EventHandler(this.TxtStock_TextChanged);
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStock_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.SystemColors.Window;
            this.txtNombre.Location = new System.Drawing.Point(0, 10);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(10);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(545, 29);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.txtPrecioCosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioCosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCosto.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPrecioCosto.Location = new System.Drawing.Point(0, 75);
            this.txtPrecioCosto.Margin = new System.Windows.Forms.Padding(10);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(545, 29);
            this.txtPrecioCosto.TabIndex = 11;
            this.txtPrecioCosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPrecioCosto.TextChanged += new System.EventHandler(this.TxtPrecioCosto_TextChanged);
            this.txtPrecioCosto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrecioCosto_KeyPress);
            // 
            // txtPorsGanancia
            // 
            this.txtPorsGanancia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPorsGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.txtPorsGanancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorsGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorsGanancia.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPorsGanancia.Location = new System.Drawing.Point(0, 107);
            this.txtPorsGanancia.Margin = new System.Windows.Forms.Padding(10);
            this.txtPorsGanancia.Name = "txtPorsGanancia";
            this.txtPorsGanancia.Size = new System.Drawing.Size(545, 29);
            this.txtPorsGanancia.TabIndex = 12;
            this.txtPorsGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPorsGanancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPorsGanancia_KeyPress);
            // 
            // txtStockMin
            // 
            this.txtStockMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStockMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.txtStockMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStockMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockMin.ForeColor = System.Drawing.SystemColors.Window;
            this.txtStockMin.Location = new System.Drawing.Point(0, 171);
            this.txtStockMin.Margin = new System.Windows.Forms.Padding(10);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(545, 29);
            this.txtStockMin.TabIndex = 14;
            this.txtStockMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtStockMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtStockMin_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo de Barras";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Stock";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(222, 243);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(240, 48);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio Costo";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "% de Ganacia";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Stock Minimo";
            // 
            // EditProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1096, 788);
            this.Controls.Add(this.pnlEditar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditProducto";
            this.Text = "EditProducto";
            this.Load += new System.EventHandler(this.EditProducto_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.pnlEditar.ResumeLayout(false);
            this.pnlEditar.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel pnlEditar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.TextBox txtPorsGanancia;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.Label lblMenaje;
    }
}