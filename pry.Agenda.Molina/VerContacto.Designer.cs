namespace pry.Agenda.Molina
{
    partial class VerContacto
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
            btnAtras = new Button();
            lblVerContacto = new Label();
            btnSiguiente = new Button();
            SuspendLayout();
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.ActiveBorder;
            btnAtras.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.Location = new Point(49, 287);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(166, 60);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // lblVerContacto
            // 
            lblVerContacto.BorderStyle = BorderStyle.Fixed3D;
            lblVerContacto.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVerContacto.Location = new Point(45, 26);
            lblVerContacto.Name = "lblVerContacto";
            lblVerContacto.Size = new Size(367, 231);
            lblVerContacto.TabIndex = 2;
            lblVerContacto.Text = "_";
            lblVerContacto.TextAlign = ContentAlignment.MiddleCenter;
            lblVerContacto.Click += lblVerContacto_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = SystemColors.ActiveBorder;
            btnSiguiente.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.Location = new Point(246, 287);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(166, 60);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // VerContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(449, 368);
            Controls.Add(btnAtras);
            Controls.Add(btnSiguiente);
            Controls.Add(lblVerContacto);
            Name = "VerContacto";
            Text = "VerContacto";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAtras;
        private Label lblVerContacto;
        private Button btnSiguiente;
    }
}