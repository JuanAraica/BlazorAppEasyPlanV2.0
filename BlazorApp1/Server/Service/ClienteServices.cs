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

        public Task<bool> DeleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Cliente>> GetAllClientes()
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> GetCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCliente(int id, Cliente cliente)
        {
            var data = await _person.GetByIdAsync(id);
            if (data != null)
            {
                data.FirstName = person.FirstName;
                data.LastName = person.LastName;
                data.Email = person.Email;
                data.MobileNo = person.MobileNo;
                await _person.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
    }
}
