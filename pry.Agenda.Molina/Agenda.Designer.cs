namespace pry.Agenda.Molina
{
    partial class Agenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agenda));
            btnRegistrar = new Button();
            lblContacto = new Label();
            label1 = new Label();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            mskNúmero = new MaskedTextBox();
            lstResultados = new ListBox();
            lblCantContact = new Label();
            lblFecha = new Label();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Font = new Font("Segoe UI", 9F);
            btnRegistrar.Location = new Point(83, 191);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(95, 33);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Location = new Point(35, 42);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(69, 20);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 129);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 2;
            label1.Text = "Número";
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.Location = new Point(202, 191);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 33);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(129, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(197, 27);
            txtNombre.TabIndex = 4;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // mskNúmero
            // 
            mskNúmero.Enabled = false;
            mskNúmero.Location = new Point(129, 122);
            mskNúmero.Mask = "(999)000-0000";
            mskNúmero.Name = "mskNúmero";
            mskNúmero.Size = new Size(97, 27);
            mskNúmero.TabIndex = 5;
            mskNúmero.TextChanged += mskNúmero_TextChanged;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(58, 258);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(231, 104);
            lstResultados.TabIndex = 6;
            // 
            // lblCantContact
            // 
            lblCantContact.AutoSize = true;
            lblCantContact.Location = new Point(35, 409);
            lblCantContact.Name = "lblCantContact";
            lblCantContact.Size = new Size(112, 20);
            lblCantContact.TabIndex = 7;
            lblCantContact.Text = "Cant Contactos:";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(242, 409);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(47, 20);
            lblFecha.TabIndex = 8;
            lblFecha.Text = "Fecha";
            // 
            // Agenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 450);
            Controls.Add(lblFecha);
            Controls.Add(lblCantContact);
            Controls.Add(lstResultados);
            Controls.Add(mskNúmero);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(label1);
            Controls.Add(lblContacto);
            Controls.Add(btnRegistrar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Agenda";
            Text = "Agenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegistrar;
        private Label lblContacto;
        private Label label1;
        private Button btnCancelar;
        private TextBox txtNombre;
        private MaskedTextBox mskNúmero;
        private ListBox lstResultados;
        private Label lblCantContact;
        private Label lblFecha;
    }
}