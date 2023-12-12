using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoApp.ViewModels
{
    public class ListarTareasViewModel
    {
        public List<Tarea> Tareas;
        public ListarTareasViewModel(List<Tarea> listaTareas)
        {
            Tareas = listaTareas;
        }
    }
}