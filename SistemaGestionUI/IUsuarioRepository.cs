using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionUI
{
    public interface IUsuarioRepository
    {
        void AgregarUsuario(Usuario usuario);
        Usuario ObtenerUsuarioPorId(int usuarioId);
        List<Usuario> ObtenerTodosLosUsuarios();
        void ActualizarUsuario(Usuario usuario);
        void EliminarUsuario(int usuarioId);
        Usuario ObtenerUsuarioPorNombreUsuario(string nombreUsuario);
    }
}
