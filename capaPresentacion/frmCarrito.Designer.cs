namespace capaPresentacion
{
    partial class frmCarrito
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
            flPanelCarrito = new FlowLayoutPanel();
            btnProcesarCompra = new Button();
            lblContinuarComprando = new LinkLabel();
            lblSub = new Label();
            lblSubtotal = new Label();
            SuspendLayout();
            // 
            // flPanelCarrito
            // 
            flPanelCarrito.AutoScroll = true;
            flPanelCarrito.Dock = DockStyle.Top;
            flPanelCarrito.Location = new Point(0, 0);
            flPanelCarrito.Name = "flPanelCarrito";
            flPanelCarrito.Size = new Size(281, 504);
            flPanelCarrito.TabIndex = 0;
            // 
            // btnProcesarCompra
            // 
            btnProcesarCompra.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnProcesarCompra.Location = new Point(12, 587);
            btnProcesarCompra.Name = "btnProcesarCompra";
            btnProcesarCompra.Size = new Size(246, 35);
            btnProcesarCompra.TabIndex = 1;
            btnProcesarCompra.Text = "Procesar compra";
            btnProcesarCompra.UseVisualStyleBackColor = true;
            // 
            // lblContinuarComprando
            // 
            lblContinuarComprando.AutoSize = true;
            lblContinuarComprando.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblContinuarComprando.LinkColor = Color.SteelBlue;
            lblContinuarComprando.Location = new Point(70, 637);
            lblContinuarComprando.Name = "lblContinuarComprando";
            lblContinuarComprando.Size = new Size(142, 17);
            lblContinuarComprando.TabIndex = 2;
            lblContinuarComprando.TabStop = true;
            lblContinuarComprando.Text = "Continuar comprando";
            lblContinuarComprando.LinkClicked += lblContinuarComprando_LinkClicked;
            // 
            // lblSub
            // 
            lblSub.AutoSize = true;
            lblSub.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSub.Location = new Point(12, 551);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(66, 17);
            lblSub.TabIndex = 3;
            lblSub.Text = "Subtotal: ";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubtotal.Location = new Point(192, 551);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(66, 17);
            lblSubtotal.TabIndex = 4;
            lblSubtotal.Text = "S/. 0.0";
            lblSubtotal.TextAlign = ContentAlignment.TopRight;
            // 
            // frmCarrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(281, 661);
            Controls.Add(lblSubtotal);
            Controls.Add(lblSub);
            Controls.Add(lblContinuarComprando);
            Controls.Add(btnProcesarCompra);
            Controls.Add(flPanelCarrito);
            Name = "frmCarrito";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarrito";
            Load += frmCarrito_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flPanelCarrito;
        private Button btnProcesarCompra;
        private LinkLabel lblContinuarComprando;
        private Label lblSub;
        private Label lblSubtotal;
    }
}