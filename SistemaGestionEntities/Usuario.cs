﻿namespace SistemaGestionEntities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public  string NombreUsuario { get; set; } 
        public string Password { get; set; }
        public string Salt { get; set; }
        public string Mail { get; set; }
    }
}
