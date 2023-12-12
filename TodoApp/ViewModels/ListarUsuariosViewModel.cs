using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.ViewModels
{
    public class ListarUsuariosViewModel
    {
        public List<Usuario> Usuarios;
        public ListarUsuariosViewModel(List<Usuario> listaUsuarios)
        {
            Usuarios = listaUsuarios;
        }
    }
}