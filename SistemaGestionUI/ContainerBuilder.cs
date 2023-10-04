using SistemaGestionBussiness;
using System.ComponentModel;

namespace SistemaGestionUI
{
    public class ContainerBuilder
    {
        private object container;

        public ContainerBuilder()
        {
            using (var scope = container.BeginLifetimeScope())
            {
                var usuarioService = scope.Resolve<UsuarioServices>();

              
            }

        }
    }
}