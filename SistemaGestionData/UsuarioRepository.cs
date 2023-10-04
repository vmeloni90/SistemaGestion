using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGestionEntities;
using static SistemaGestionData.Contexto;


namespace SistemaGestionData
{
    public class UsuarioRepository
    {
        private readonly Contexto context;

       

        public UsuarioRepository(Contexto dbContext)
        {
            context = dbContext;
        }

        public void AgregarUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            context.Usuarios.Add(usuario);
            context.SaveChanges();
        }

        public Usuario ObtenerUsuarioPorId(int usuarioId)
        {
            return context.Usuarios.Find(usuarioId);
        }

        public List<Usuario> ObtenerTodosLosUsuarios()
        {
            return context.Usuarios.ToList();
        }

        public void ActualizarUsuario(Usuario usuario)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            context.Entry(usuario).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void EliminarUsuario(int usuarioId)
        {
            var usuario = context.Usuarios.Find(usuarioId);
            if (usuario != null)
            {
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
            }
        }
        public Usuario ObtenerUsuarioPorNombreUsuario(string nombreUsuario)
        {
            return context.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
        }

    }
}
