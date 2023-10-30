namespace capaPresentacion
{
    partial class supermarketMDI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            toolAuth = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            tlsLogin = new ToolStripMenuItem();
            carritoDeComprasToolStripMenuItem = new ToolStripMenuItem();
            soporteAlClienteToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lblUsername = new Label();
            lblBienvenido = new Label();
            imageList1 = new ImageList(components);
            flowLayoutPanel1 = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolAuth, carritoDeComprasToolStripMenuItem, soporteAlClienteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(1194, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolAuth
            // 
            toolAuth.DropDownItems.AddRange(new ToolStripItem[] { registroToolStripMenuItem, tlsLogin });
            toolAuth.Name = "toolAuth";
            toolAuth.Size = new Size(93, 20);
            toolAuth.Text = "Autenticación";
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(155, 22);
            registroToolStripMenuItem.Text = "Registro";
            // 
            // tlsLogin
            // 
            tlsLogin.Name = "tlsLogin";
            tlsLogin.Size = new Size(155, 22);
            tlsLogin.Text = "Inicio de sesión";
            tlsLogin.Click += toolLogin_Click;
            // 
            // carritoDeComprasToolStripMenuItem
            // 
            carritoDeComprasToolStripMenuItem.Name = "carritoDeComprasToolStripMenuItem";
            carritoDeComprasToolStripMenuItem.Size = new Size(120, 20);
            carritoDeComprasToolStripMenuItem.Text = "Carrito de compras";
            carritoDeComprasToolStripMenuItem.Click += carritoDeComprasToolStripMenuItem_Click;
            // 
            // soporteAlClienteToolStripMenuItem
            // 
            soporteAlClienteToolStripMenuItem.Name = "soporteAlClienteToolStripMenuItem";
            soporteAlClienteToolStripMenuItem.Size = new Size(110, 20);
            soporteAlClienteToolStripMenuItem.Text = "Soporte al cliente";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(lblBienvenido);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(1194, 57);
            panel1.TabIndex = 5;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblUsername.Location = new Point(87, 19);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(59, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "username";
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Location = new Point(12, 19);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(69, 15);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 81);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1194, 580);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // supermarketMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 661);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "supermarketMDI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SUPERMARKET";
            Load += supermarketMDI_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolAuth;
        private ToolStripMenuItem carritoDeComprasToolStripMenuItem;
        private ToolStripMenuItem registroToolStripMenuItem;
        private ToolStripMenuItem tlsLogin;
        private ToolStripMenuItem soporteAlClienteToolStripMenuItem;
        private Panel panel1;
        private Label lblBienvenido;
        public Label lblUsername;
        private ImageList imageList1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}