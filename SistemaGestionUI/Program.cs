using SistemaGestionBussiness;
using SistemaGestionData;

namespace SistemaGestionUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            var builder = new ContainerBuilder();

            // Registra las implementaciones concretas.
            builder.RegisterType<UsuarioRepository>().As<IUsuarioRepository>();
            builder.RegisterType<UsuarioServices>();

            // Crea el contenedor.
            var container = builder.Build();

        }
    }
}