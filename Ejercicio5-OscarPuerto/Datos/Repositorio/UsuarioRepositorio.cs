using Dapper;
using Datos.Interfaz;
using Modelos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private string CadenaConexon;

        public UsuarioRepositorio(string _cadenaConexion)
        {
            CadenaConexon = _cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexon);
        }


        public Task<bool> Actualizar(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(string codigo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuarios>> GetLista()
        {
            throw new NotImplementedException();
        }

        public async Task<Usuarios> GetPorCodigo(string codigo)
        {
            Usuarios user = new Usuarios();
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "SELECT * FROM login WHERE Correo = @Correo;";
                user = await conexion.QueryFirstAsync<Usuarios>(sql, new { codigo });
            }
            catch (Exception ex)
            {
            }
            return user;
        }

        public Task<bool> Nuevo(Usuarios usuario)
        {
            throw new NotImplementedException();
        }
    }
}
