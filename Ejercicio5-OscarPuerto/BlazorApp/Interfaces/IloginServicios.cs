using Modelos;
namespace BlazorApp.Interfaces

{
    public interface IloginServicios
    {
        Task<bool> ValidarUsuario(Login login);
    }
}
