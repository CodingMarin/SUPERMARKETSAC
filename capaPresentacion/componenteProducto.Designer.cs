namespace capaPresentacion
{
    partial class componenteProducto
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
            btnAñadirProducto = new Button();
            panel1 = new Panel();
            lblNombreProducto = new Label();
            lblPrecioProducto = new Label();
            lblCategoriaProducto = new Label();
            lblStockProducto = new Label();
            btnComprarProducto = new Button();
            txtCantidadProducto = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnAñadirProducto
            // 
            btnAñadirProducto.Location = new Point(14, 280);
            btnAñadirProducto.Name = "btnAñadirProducto";
            btnAñadirProducto.Size = new Size(200, 23);
            btnAñadirProducto.TabIndex = 0;
            btnAñadirProducto.Text = "Añadir al carrito";
            btnAñadirProducto.UseVisualStyleBackColor = true;
            btnAñadirProducto.Click += btnAñadirProducto_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(14, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 1;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(14, 122);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(103, 15);
            lblNombreProducto.TabIndex = 3;
            lblNombreProducto.Text = "Nombre Producto";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Location = new Point(14, 188);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(39, 15);
            lblPrecioProducto.TabIndex = 4;
            lblPrecioProducto.Text = "S/. 0.0";
            // 
            // lblCategoriaProducto
            // 
            lblCategoriaProducto.AutoSize = true;
            lblCategoriaProducto.Location = new Point(14, 164);
            lblCategoriaProducto.Name = "lblCategoriaProducto";
            lblCategoriaProducto.Size = new Size(58, 15);
            lblCategoriaProducto.TabIndex = 5;
            lblCategoriaProducto.Text = "Categoria";
            lblCategoriaProducto.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStockProducto
            // 
            lblStockProducto.AutoSize = true;
            lblStockProducto.Location = new Point(160, 188);
            lblStockProducto.Name = "lblStockProducto";
            lblStockProducto.Size = new Size(54, 15);
            lblStockProducto.TabIndex = 6;
            lblStockProducto.Text = "STOCK: 0";
            // 
            // btnComprarProducto
            // 
            btnComprarProducto.Location = new Point(14, 251);
            btnComprarProducto.Name = "btnComprarProducto";
            btnComprarProducto.Size = new Size(200, 23);
            btnComprarProducto.TabIndex = 7;
            btnComprarProducto.Text = "Comprar ahora";
            btnComprarProducto.UseVisualStyleBackColor = true;
            // 
            // txtCantidadProducto
            // 
            txtCantidadProducto.Location = new Point(160, 222);
            txtCantidadProducto.Name = "txtCantidadProducto";
            txtCantidadProducto.Size = new Size(54, 23);
            txtCantidadProducto.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 225);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 9;
            label1.Text = "Cantidad";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // componenteProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(txtCantidadProducto);
            Controls.Add(btnComprarProducto);
            Controls.Add(lblStockProducto);
            Controls.Add(lblCategoriaProducto);
            Controls.Add(lblPrecioProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(panel1);
            Controls.Add(btnAñadirProducto);
            Name = "componenteProducto";
            Size = new Size(229, 313);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAñadirProducto;
        private Panel panel1;
        private Label lblNombreProducto;
        private Label lblPrecioProducto;
        private Label lblCategoriaProducto;
        private Label lblStockProducto;
        private Button btnComprarProducto;
        private TextBox txtCantidadProducto;
        private Label label1;
    }
}
