using SistemaGestionEntities;
using SistemaGestionBussiness.Helper;
using SistemaGestionUI;

namespace SistemaGestionBussiness
{
    public class UsuarioServices
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioServices(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
        }

        public void AgregarUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            if (NombreUsuarioYaExiste(usuario.NombreUsuario))
            {
                throw new InvalidOperationException("El nombre de usuario ya está en uso.");
            }

            _usuarioRepository.AgregarUsuario(usuario);
        }

        public void RegistrarUsuario(Usuario usuario)
        {
            var salt = HashingHelper.GenerateSalt();
            var hashedPassword = HashingHelper.HashPassword(usuario.Password, salt);

            usuario.Password = hashedPassword;
            _usuarioRepository.AgregarUsuario(usuario);
        }

        public bool AutenticarUsuario(string nombreUsuario, string passwordPlainText)
        {
            var usuario = _usuarioRepository.ObtenerUsuarioPorNombreUsuario(nombreUsuario);
            if (usuario != null)
            {
                var hashedPassword = HashingHelper.HashPassword(passwordPlainText /* salt asociado al usuario */);
                return hashedPassword == usuario.Password;
            }
            return false;
        }

        private bool NombreUsuarioYaExiste(string nombreUsuario)
        {
            return _usuarioRepository.ObtenerUsuarioPorNombreUsuario(nombreUsuario) != null;
        }

        public Usuario ObtenerUsuarioPorId(int usuarioId)
        {
            return _usuarioRepository.ObtenerUsuarioPorId(usuarioId);
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            return _usuarioRepository.ObtenerTodosLosUsuarios();
        }

        public void ActualizarUsuario(Usuario usuarioActualizado)
        {
            if (usuarioActualizado == null)
            {
                throw new ArgumentNullException(nameof(usuarioActualizado));
            }

            var usuarioEnBD = _usuarioRepository.ObtenerUsuarioPorId(usuarioActualizado.Id);
            if (usuarioEnBD == null)
            {
                throw new InvalidOperationException("El usuario no existe en la base de datos.");
            }

            var existingUser = _usuarioRepository.ObtenerUsuarioPorNombreUsuario(usuarioActualizado.NombreUsuario);
            if (existingUser != null && existingUser.Id != usuarioActualizado.Id)
            {
                throw new InvalidOperationException("El nombre de usuario ya está en uso por otro usuario.");
            }

            usuarioEnBD.Nombre = usuarioActualizado.Nombre;
            usuarioEnBD.Apellido = usuarioActualizado.Apellido;
            usuarioEnBD.NombreUsuario = usuarioActualizado.NombreUsuario;
            usuarioEnBD.Mail = usuarioActualizado.Mail;

            if (usuarioActualizado.Password != usuarioEnBD.Password)
            {
                var salt = HashingHelper.GenerateSalt(); /* Obtiene el salt del usuario si lo tienes guardado, o genera uno nuevo */
                var hashedPassword = HashingHelper.HashPassword(usuarioActualizado.Password, salt);
                usuarioEnBD.Password = hashedPassword;
            }

            _usuarioRepository.ActualizarUsuario(usuarioEnBD);
        }

        public void EliminarUsuario(int usuarioId)
        {
            if (usuarioId <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(usuarioId), "El ID del usuario es inválido.");
            }

            _usuarioRepository.EliminarUsuario(usuarioId);
        }

        public Usuario ObtenerUsuarioPorNombreUsuario(string nombreUsuario)
        {
            if (string.IsNullOrEmpty(nombreUsuario))
            {
                throw new ArgumentException("El nombre de usuario es requerido.", nameof(nombreUsuario));
            }

            return _usuarioRepository.ObtenerUsuarioPorNombreUsuario(nombreUsuario);
        }
    }
}

