using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.ViewModels
{
    public class ListarTablerosViewModel
    {
        public List<Tablero> Tableros;
        public ListarTablerosViewModel(List<Tablero> listaTableros)
        {
            Tableros = listaTableros;
        }
    }
}