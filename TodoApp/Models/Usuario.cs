using TodoApp.ViewModels;
namespace TodoApp;

public enum Roles
{
    administrador,
    operador
}

public class Usuario
{
    private int id;
    private string nombreDeUsuario;
    private string contrasenia;
    private Roles rol;

    public int Id { get => id; set => id = value; }
    public string NombreDeUsuario { get => nombreDeUsuario; set => nombreDeUsuario = value; }
    public string Contrasenia { get => contrasenia; set => contrasenia = value; }
    public Roles Rol { get => rol; set => rol = value; }

    public Usuario() { }
    public Usuario(CrearUsuarioViewModel usuario)
    {
        this.NombreDeUsuario = usuario.NombreDeUsuario;
        this.Contrasenia = usuario.Contrasenia;
        this.Rol = usuario.Rol;
    }
    public Usuario(ModificarUsuarioViewModel usuario)
    {
        this.id = usuario.Id;
        this.NombreDeUsuario = usuario.NombreDeUsuario;
        this.Contrasenia = usuario.Contrasenia;
        this.Rol = usuario.Rol;
    }
}