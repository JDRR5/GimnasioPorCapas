namespace CapaPresentacion
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            registrarClienteToolStripMenuItem = new ToolStripMenuItem();
            registrarClienteToolStripMenuItem1 = new ToolStripMenuItem();
            buscarClienteToolStripMenuItem = new ToolStripMenuItem();
            listadoDeClientesToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrarClienteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrarClienteToolStripMenuItem
            // 
            registrarClienteToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarClienteToolStripMenuItem1, buscarClienteToolStripMenuItem, listadoDeClientesToolStripMenuItem, salirToolStripMenuItem });
            registrarClienteToolStripMenuItem.Name = "registrarClienteToolStripMenuItem";
            registrarClienteToolStripMenuItem.Size = new Size(73, 24);
            registrarClienteToolStripMenuItem.Text = "&Archivo";
            // 
            // registrarClienteToolStripMenuItem1
            // 
            registrarClienteToolStripMenuItem1.Name = "registrarClienteToolStripMenuItem1";
            registrarClienteToolStripMenuItem1.Size = new Size(224, 26);
            registrarClienteToolStripMenuItem1.Text = "&Registrar cliente";
            registrarClienteToolStripMenuItem1.Click += registrarClienteToolStripMenuItem1_Click;
            // 
            // buscarClienteToolStripMenuItem
            // 
            buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            buscarClienteToolStripMenuItem.Size = new Size(224, 26);
            buscarClienteToolStripMenuItem.Text = "&Buscar cliente";
            buscarClienteToolStripMenuItem.Click += buscarClienteToolStripMenuItem_Click;
            // 
            // listadoDeClientesToolStripMenuItem
            // 
            listadoDeClientesToolStripMenuItem.Name = "listadoDeClientesToolStripMenuItem";
            listadoDeClientesToolStripMenuItem.Size = new Size(224, 26);
            listadoDeClientesToolStripMenuItem.Text = "&Listado de clientes";
            listadoDeClientesToolStripMenuItem.Click += listadoDeClientesToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(224, 26);
            salirToolStripMenuItem.Text = "&Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarClienteToolStripMenuItem;
        private ToolStripMenuItem buscarClienteToolStripMenuItem;
        private ToolStripMenuItem listadoDeClientesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem registrarClienteToolStripMenuItem1;
    }
}