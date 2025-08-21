namespace CapaPresentacion
{
    partial class frmListar
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
            dgvListado = new DataGridView();
            btnListar = new Button();
            label7 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 24);
            label1.Name = "label1";
            label1.Size = new Size(225, 32);
            label1.TabIndex = 2;
            label1.Text = "Listado de clientes";
            // 
            // dgvListado
            // 
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(18, 76);
            dgvListado.Margin = new Padding(3, 2, 3, 2);
            dgvListado.Name = "dgvListado";
            dgvListado.RowHeadersWidth = 51;
            dgvListado.Size = new Size(670, 202);
            dgvListado.TabIndex = 3;
            // 
            // btnListar
            // 
            btnListar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnListar.Location = new Point(584, 290);
            btnListar.Margin = new Padding(3, 2, 3, 2);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(104, 30);
            btnListar.TabIndex = 18;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Location = new Point(274, 33);
            label7.Name = "label7";
            label7.Size = new Size(414, 23);
            label7.TabIndex = 19;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(18, 297);
            label2.Name = "label2";
            label2.Size = new Size(554, 23);
            label2.TabIndex = 20;
            // 
            // frmListar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(btnListar);
            Controls.Add(dgvListado);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmListar";
            Text = "Listado de clientes";
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvListado;
        private Button btnListar;
        private Label label7;
        private Label label2;
    }
}