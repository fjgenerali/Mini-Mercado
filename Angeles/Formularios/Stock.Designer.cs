namespace Angeles.Formularios
{
    partial class Stock
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
            this.grdTodos = new System.Windows.Forms.DataGridView();
            this.codigoDeBarrasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grdAlerta = new System.Windows.Forms.DataGridView();
            this.codigoDeBarrasDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockActualDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlerta)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTodos
            // 
            this.grdTodos.AutoGenerateColumns = false;
            this.grdTodos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdTodos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.grdTodos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdTodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTodos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDeBarrasDataGridViewTextBoxColumn,
            this.nombre,
            this.stockActualDataGridViewTextBoxColumn,
            this.stockMinimoDataGridViewTextBoxColumn});
            this.grdTodos.DataSource = this.productoBindingSource;
            this.grdTodos.Location = new System.Drawing.Point(48, 172);
            this.grdTodos.Name = "grdTodos";
            this.grdTodos.ReadOnly = true;
            this.grdTodos.RowHeadersVisible = false;
            this.grdTodos.Size = new System.Drawing.Size(400, 266);
            this.grdTodos.TabIndex = 0;
            // 
            // codigoDeBarrasDataGridViewTextBoxColumn
            // 
            this.codigoDeBarrasDataGridViewTextBoxColumn.DataPropertyName = "codigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn.HeaderText = "codigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn.Name = "codigoDeBarrasDataGridViewTextBoxColumn";
            this.codigoDeBarrasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // stockActualDataGridViewTextBoxColumn
            // 
            this.stockActualDataGridViewTextBoxColumn.DataPropertyName = "stockActual";
            this.stockActualDataGridViewTextBoxColumn.HeaderText = "stockActual";
            this.stockActualDataGridViewTextBoxColumn.Name = "stockActualDataGridViewTextBoxColumn";
            this.stockActualDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockMinimoDataGridViewTextBoxColumn
            // 
            this.stockMinimoDataGridViewTextBoxColumn.DataPropertyName = "stockMinimo";
            this.stockMinimoDataGridViewTextBoxColumn.HeaderText = "stockMinimo";
            this.stockMinimoDataGridViewTextBoxColumn.Name = "stockMinimoDataGridViewTextBoxColumn";
            this.stockMinimoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(BibliotecaAngeles.Modelo.Producto);
            // 
            // grdAlerta
            // 
            this.grdAlerta.AutoGenerateColumns = false;
            this.grdAlerta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdAlerta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grdAlerta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.grdAlerta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlerta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoDeBarrasDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn,
            this.stockActualDataGridViewTextBoxColumn1,
            this.stockMinimo});
            this.grdAlerta.DataSource = this.productoBindingSource;
            this.grdAlerta.Location = new System.Drawing.Point(563, 172);
            this.grdAlerta.Name = "grdAlerta";
            this.grdAlerta.RowHeadersVisible = false;
            this.grdAlerta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grdAlerta.Size = new System.Drawing.Size(401, 266);
            this.grdAlerta.TabIndex = 1;
            // 
            // codigoDeBarrasDataGridViewTextBoxColumn1
            // 
            this.codigoDeBarrasDataGridViewTextBoxColumn1.DataPropertyName = "codigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn1.HeaderText = "codigoDeBarras";
            this.codigoDeBarrasDataGridViewTextBoxColumn1.Name = "codigoDeBarrasDataGridViewTextBoxColumn1";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // stockActualDataGridViewTextBoxColumn1
            // 
            this.stockActualDataGridViewTextBoxColumn1.DataPropertyName = "stockActual";
            this.stockActualDataGridViewTextBoxColumn1.HeaderText = "stockActual";
            this.stockActualDataGridViewTextBoxColumn1.Name = "stockActualDataGridViewTextBoxColumn1";
            // 
            // stockMinimo
            // 
            this.stockMinimo.DataPropertyName = "stockMinimo";
            this.stockMinimo.HeaderText = "stockMinimo";
            this.stockMinimo.Name = "stockMinimo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(45, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Todos los Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(570, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Productos en Alerta";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(107)))), ((int)(((byte)(153)))));
            this.ClientSize = new System.Drawing.Size(1074, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdAlerta);
            this.Controls.Add(this.grdTodos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlerta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdTodos;
        private System.Windows.Forms.DataGridView grdAlerta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeBarrasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDeBarrasDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockActualDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMinimo;
    }
}