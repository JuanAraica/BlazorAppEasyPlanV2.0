using BlazorApp1.Server.Models;
using BlazorApp1.Server.Repository;

namespace BlazorApp1.Server.Service
{
    public class ClienteServices : IClienteServices
    {
        private readonly IRepository<Cliente> _cliente;

        public ClienteServices(IRepository<Cliente> cliente)
        {
            _cliente = cliente;
        }
        public async Task<Cliente> AddCliente(Cliente cliente)
        {
            return await _cliente.CreateAsync(cliente);
        }

        public async Task<bool> DeleteCliente(int id)
        {
            await _cliente.DeleteAsync(id);
            return true;
        }

        public async Task<List<Cliente>> GetAllClientes()
        {
            return await _cliente.GetAllAsync();
        }

        public async Task<Cliente> GetCliente(int id)
        {
            return await _cliente.GetByIdAsync(id);
        }

        public async Task<bool> UpdateCliente(int id, Cliente cliente)
        {
            var data = await _cliente.GetByIdAsync(id);
            if (data != null)
            {
                data.NombreCliente = cliente.NombreCliente;
                data.Contacto = cliente.Contacto;
                data.Direccion = cliente.Direccion;
                data.Telefono = cliente.Telefono;
                data.Email = cliente.Email;
                data.Proyecto = cliente.Proyecto;
                await _cliente.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
    }
}
