namespace Domain.DTO
{
    public class UsuarioRequest
    {
        public string Nombre { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? FkRol { get; set; }
    }
}