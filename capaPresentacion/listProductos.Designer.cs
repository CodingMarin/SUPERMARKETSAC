namespace capaPresentacion
{
    partial class listProductos
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombreProducto = new Label();
            lblCategoriaProducto = new Label();
            lblPrecioProducto = new Label();
            lblCantidadProducto = new Label();
            label1 = new Label();
            btnEliminarCarrito = new Button();
            SuspendLayout();
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreProducto.Location = new Point(0, 9);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(164, 27);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "Nombre producto";
            // 
            // lblCategoriaProducto
            // 
            lblCategoriaProducto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoriaProducto.ForeColor = SystemColors.ControlDarkDark;
            lblCategoriaProducto.Location = new Point(0, 36);
            lblCategoriaProducto.Name = "lblCategoriaProducto";
            lblCategoriaProducto.Size = new Size(164, 23);
            lblCategoriaProducto.TabIndex = 1;
            lblCategoriaProducto.Text = "Categoria";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPrecioProducto.Location = new Point(190, 9);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(75, 25);
            lblPrecioProducto.TabIndex = 2;
            lblPrecioProducto.Text = "S/.0.0";
            lblPrecioProducto.TextAlign = ContentAlignment.TopRight;
            // 
            // lblCantidadProducto
            // 
            lblCantidadProducto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblCantidadProducto.Location = new Point(190, 34);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(75, 25);
            lblCantidadProducto.TabIndex = 3;
            lblCantidadProducto.Text = "P/U: 0";
            lblCantidadProducto.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-2, 93);
            label1.Name = "label1";
            label1.Size = new Size(272, 15);
            label1.TabIndex = 4;
            label1.Text = "_____________________________________________________";
            // 
            // btnEliminarCarrito
            // 
            btnEliminarCarrito.Location = new Point(3, 76);
            btnEliminarCarrito.Name = "btnEliminarCarrito";
            btnEliminarCarrito.Size = new Size(259, 23);
            btnEliminarCarrito.TabIndex = 5;
            btnEliminarCarrito.Text = "Eliminar del carrito";
            btnEliminarCarrito.UseVisualStyleBackColor = true;
            btnEliminarCarrito.Click += btnEliminarCarrito_Click;
            // 
            // listProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            Controls.Add(btnEliminarCarrito);
            Controls.Add(label1);
            Controls.Add(lblCantidadProducto);
            Controls.Add(lblPrecioProducto);
            Controls.Add(lblCategoriaProducto);
            Controls.Add(lblNombreProducto);
            Name = "listProductos";
            Size = new Size(265, 107);
            Load += listProductos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreProducto;
        private Label lblCategoriaProducto;
        private Label lblPrecioProducto;
        private Label lblCantidadProducto;
        private Label label1;
        private Button btnEliminarCarrito;
    }
}
