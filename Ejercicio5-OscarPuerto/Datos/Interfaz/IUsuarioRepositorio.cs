using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Interfaz
{
    public interface IUsuarioRepositorio
    {
        Task<Usuarios> GetPorCodigo(string codigo);
        Task<bool> Nuevo(Usuarios usuario);
        Task<bool> Actualizar(Usuarios usuario);
        Task<bool> Eliminar(string codigo);
        Task<IEnumerable<Usuarios>> GetLista();
    }
}
