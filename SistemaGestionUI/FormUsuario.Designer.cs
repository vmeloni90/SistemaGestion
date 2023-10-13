namespace SistemaGestionUI
{
    partial class FormUsuario
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
            tabControl1 = new TabControl();
            apellidoUsuario = new TabPage();
            btn_add_user = new Button();
            txtPassword = new TextBox();
            label6 = new Label();
            txtMail = new TextBox();
            label5 = new Label();
            txtNombreUsuario = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            apellidoUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(apellidoUsuario);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1038, 593);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // apellidoUsuario
            // 
            apellidoUsuario.AllowDrop = true;
            apellidoUsuario.Controls.Add(btn_add_user);
            apellidoUsuario.Controls.Add(txtPassword);
            apellidoUsuario.Controls.Add(label6);
            apellidoUsuario.Controls.Add(txtMail);
            apellidoUsuario.Controls.Add(label5);
            apellidoUsuario.Controls.Add(txtNombreUsuario);
            apellidoUsuario.Controls.Add(label4);
            apellidoUsuario.Controls.Add(label3);
            apellidoUsuario.Controls.Add(txtApellido);
            apellidoUsuario.Controls.Add(label2);
            apellidoUsuario.Controls.Add(txtNombre);
            apellidoUsuario.Controls.Add(label1);
            apellidoUsuario.Location = new Point(4, 24);
            apellidoUsuario.Name = "apellidoUsuario";
            apellidoUsuario.Padding = new Padding(3);
            apellidoUsuario.Size = new Size(1030, 565);
            apellidoUsuario.TabIndex = 0;
            apellidoUsuario.Text = "Crear Usuario";
            apellidoUsuario.UseVisualStyleBackColor = true;
            // 
            // btn_add_user
            // 
            btn_add_user.BackColor = Color.MistyRose;
            btn_add_user.Cursor = Cursors.Hand;
            btn_add_user.FlatStyle = FlatStyle.Popup;
            btn_add_user.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add_user.ForeColor = Color.MediumBlue;
            btn_add_user.Location = new Point(296, 251);
            btn_add_user.Name = "btn_add_user";
            btn_add_user.Size = new Size(75, 45);
            btn_add_user.TabIndex = 11;
            btn_add_user.Text = "Agregar Usuario";
            btn_add_user.UseVisualStyleBackColor = false;
            btn_add_user.Click += btn_add_user_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(130, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 23);
            txtPassword.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 200);
            label6.Name = "label6";
            label6.Size = new Size(74, 14);
            label6.TabIndex = 9;
            label6.Text = "Contraseña";
            // 
            // txtMail
            // 
            txtMail.Location = new Point(130, 160);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(241, 23);
            txtMail.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 169);
            label5.Name = "label5";
            label5.Size = new Size(30, 14);
            label5.TabIndex = 7;
            label5.Text = "Mail";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(130, 131);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(241, 23);
            txtNombreUsuario.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 139);
            label4.Name = "label4";
            label4.Size = new Size(102, 14);
            label4.TabIndex = 5;
            label4.Text = "Nombre Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(184, 16);
            label3.Name = "label3";
            label3.Size = new Size(668, 32);
            label3.TabIndex = 4;
            label3.Text = "INGRESE LOS DATOS PARA CREAR UN USUARIO";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(130, 101);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(241, 23);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 109);
            label2.Name = "label2";
            label2.Size = new Size(103, 14);
            label2.TabIndex = 2;
            label2.Text = "Apellido Usuario";
            label2.Click += label2_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(130, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(241, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 80);
            label1.Name = "label1";
            label1.Size = new Size(102, 14);
            label1.TabIndex = 0;
            label1.Text = "Nombre Usuario";
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1030, 565);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Modificar/ Eliminar Usuario";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1030, 565);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Mostrar Usuario";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 594);
            Controls.Add(tabControl1);
            Name = "FormUsuario";
            Text = "FormUsuario";
            Load += FormUsuario_Load;
            tabControl1.ResumeLayout(false);
            apellidoUsuario.ResumeLayout(false);
            apellidoUsuario.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage apellidoUsuario;
        private TabPage tabPage2;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private TabPage tabPage3;
        private TextBox txtApellido;
        private Label label3;
        private Label label4;
        private Button btn_add_user;
        private TextBox txtPassword;
        private Label label6;
        private TextBox txtMail;
        private Label label5;
        private TextBox txtNombreUsuario;
    }
}