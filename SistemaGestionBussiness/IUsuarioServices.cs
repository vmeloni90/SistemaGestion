using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public interface IUsuarioServices: IUsuarioRepository
    {
        void AgregarUsuario(Usuario usuario);
        Usuario ObtenerUsuarioPorId(int usuarioId);
        void ActualizarUsuario(Usuario usuario);
        void EliminarUsuario(int usuarioId);
        Usuario ObtenerUsuarioPorNombreUsuario(string nombreUsuario);
        List<Usuario> GetUsuarios();
    }
}