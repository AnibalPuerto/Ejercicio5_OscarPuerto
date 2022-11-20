using Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using MySql.Data.MySqlClient;
using Dapper;

namespace Datos.Repositorio
{
    public class LoginRepositorio : ILoginRepositorio
    {
        private string CadenaConexon;

        public LoginRepositorio(string _cadenaConexion)
        {
            CadenaConexon = _cadenaConexion;
        }

        private MySqlConnection Conexion()
        {
            return new MySqlConnection(CadenaConexon);
        }

        public async Task<bool> ValidarUsuario(Login login)
        {
            bool valido = false;
            try
            {
                using MySqlConnection conexion = Conexion();
                await conexion.OpenAsync();
                string sql = "SELECT 1 FROM login WHERE Correo = @Correo AND Contraseña = @Contraseña;";
                valido = await conexion.ExecuteScalarAsync<bool>(sql, new { login.Correo, login.Contraseña });
            }
            catch (Exception ex)
            {
            }
            return valido;
        }
    }
}
