using BlazorApp1.Server.Models;

namespace BlazorApp1.Server.Service
{
    public interface IClienteServices
    {
        Task<Cliente> AddCliente(Cliente cliente);
        Task<bool> UpdateCliente(int id, Cliente cliente);
        Task<bool> DeleteCliente(int id);
        Task<List<Cliente>> GetAllClientes();
        Task<Cliente> GetCliente(int id);
    }
}
