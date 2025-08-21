namespace CapaPresentacion
{
    partial class FrmRegistro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtId = new TextBox();
            txtNom = new TextBox();
            txtApe = new TextBox();
            txtEdad = new TextBox();
            txtCorreo = new TextBox();
            label5 = new Label();
            label6 = new Label();
            btnRegistrar = new Button();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(238, 32);
            label1.TabIndex = 0;
            label1.Text = "Registro de clientes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 77);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "Identificación:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 116);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 156);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 3;
            label4.Text = "Edad:";
            // 
            // txtId
            // 
            txtId.Location = new Point(149, 80);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(184, 23);
            txtId.TabIndex = 4;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(149, 118);
            txtNom.Margin = new Padding(3, 2, 3, 2);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(246, 23);
            txtNom.TabIndex = 5;
            // 
            // txtApe
            // 
            txtApe.Location = new Point(495, 121);
            txtApe.Margin = new Padding(3, 2, 3, 2);
            txtApe.Name = "txtApe";
            txtApe.Size = new Size(184, 23);
            txtApe.TabIndex = 6;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(149, 157);
            txtEdad.Margin = new Padding(3, 2, 3, 2);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(81, 23);
            txtEdad.TabIndex = 7;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(338, 160);
            txtCorreo.Margin = new Padding(3, 2, 3, 2);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(342, 23);
            txtCorreo.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(266, 157);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 9;
            label5.Text = "Correo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(404, 120);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 10;
            label6.Text = "Apellidos:";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(576, 216);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(104, 30);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Location = new Point(266, 26);
            label7.Name = "label7";
            label7.Size = new Size(414, 23);
            label7.TabIndex = 12;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Location = new Point(22, 223);
            label8.Name = "label8";
            label8.Size = new Size(511, 23);
            label8.TabIndex = 13;
            // 
            // FrmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 269);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnRegistrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtCorreo);
            Controls.Add(txtEdad);
            Controls.Add(txtApe);
            Controls.Add(txtNom);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmRegistro";
            Text = "Registro de clientes";
            Load += FrmRegistro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtId;
        private TextBox txtNom;
        private TextBox txtApe;
        private TextBox txtEdad;
        private TextBox txtCorreo;
        private Label label5;
        private Label label6;
        private Button btnRegistrar;
        private Label label7;
        private Label label8;
    }
}