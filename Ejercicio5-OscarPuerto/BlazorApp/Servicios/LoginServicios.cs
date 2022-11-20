
using BlazorApp.Interfaces;
using Datos.Interfaz;
using Datos.Repositorio;
using Modelos;

namespace BlazorApp.Servicios
{
    public class LoginServicios : IloginServicios
    {
        private readonly Config _configuracion;
        private ILoginRepositorio loginRepositorio;

        public LoginServicios(Config config)
        {
            _configuracion = config;
            loginRepositorio = new LoginRepositorio(config.CadenaConexion);
        }


        public async Task<bool> ValidarUsuario(Login login)
        {
            return await loginRepositorio.ValidarUsuario(login);
        }
    }
}
