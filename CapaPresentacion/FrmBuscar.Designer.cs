namespace CapaPresentacion
{
    partial class FrmBuscar
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
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            lblApe = new Label();
            lblCorreo = new Label();
            btnBuscar = new Button();
            label7 = new Label();
            label8 = new Label();
            lblEdad = new Label();
            lblNom = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 16);
            label1.Name = "label1";
            label1.Size = new Size(255, 32);
            label1.TabIndex = 1;
            label1.Text = "Búsqueda de clientes";
            // 
            // txtId
            // 
            txtId.Location = new Point(154, 74);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.Size = new Size(184, 23);
            txtId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(27, 71);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 5;
            label2.Text = "Identificación:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(27, 119);
            label3.Name = "label3";
            label3.Size = new Size(78, 21);
            label3.TabIndex = 7;
            label3.Text = "Nombres:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 159);
            label4.Name = "label4";
            label4.Size = new Size(47, 21);
            label4.TabIndex = 8;
            label4.Text = "Edad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(401, 119);
            label6.Name = "label6";
            label6.Size = new Size(77, 21);
            label6.TabIndex = 11;
            label6.Text = "Apellidos:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(271, 159);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 12;
            label5.Text = "Correo:";
            // 
            // lblApe
            // 
            lblApe.AutoSize = true;
            lblApe.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApe.Location = new Point(492, 119);
            lblApe.Name = "lblApe";
            lblApe.Size = new Size(16, 21);
            lblApe.TabIndex = 15;
            lblApe.Text = "-";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCorreo.Location = new Point(343, 159);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(16, 21);
            lblCorreo.TabIndex = 16;
            lblCorreo.Text = "-";
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(550, 267);
            btnBuscar.Margin = new Padding(3, 2, 3, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(104, 31);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.TopCenter;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Location = new Point(288, 25);
            label7.Name = "label7";
            label7.Size = new Size(414, 23);
            label7.TabIndex = 20;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Location = new Point(27, 275);
            label8.Name = "label8";
            label8.Size = new Size(414, 23);
            label8.TabIndex = 21;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEdad.Location = new Point(85, 159);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(16, 21);
            lblEdad.TabIndex = 14;
            lblEdad.Text = "-";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNom.Location = new Point(117, 119);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(16, 21);
            lblNom.TabIndex = 13;
            lblNom.Text = "-";
            // 
            // FrmBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnBuscar);
            Controls.Add(lblCorreo);
            Controls.Add(lblApe);
            Controls.Add(lblEdad);
            Controls.Add(lblNom);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmBuscar";
            Text = "Búsqueda de clientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Label lblApe;
        private Label lblCorreo;
        private Button btnBuscar;
        private Label label7;
        private Label label8;
        private Label lblEdad;
        private Label lblNom;
    }
}