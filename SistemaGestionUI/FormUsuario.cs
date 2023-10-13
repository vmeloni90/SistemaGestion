using SistemaGestionBussiness;
using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionUI
{
    public partial class FormUsuario : Form
    {
        private IUsuarioServices _usuarioService;
        public FormUsuario()
        {
            InitializeComponent();
           

        
        }
        

        private void FormUsuario_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_user_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                NombreUsuario = txtNombreUsuario.Text,
                Mail = txtMail.Text,
                Password = txtPassword.Text
            };

            try
            {
                _usuarioService.AgregarUsuario(nuevoUsuario);
                MessageBox.Show("Usuario agregado con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
