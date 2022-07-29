using BlazorApp1.Server.Models;

namespace BlazorApp1.Server.Service
{
    public class HistorialService : IHistorialService
    {
        public Task<Historial> AddHistorial(Historial historial)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteHistorial(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> GetAllHistorials()
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetHistorial(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateHistorial(int id, Historial historial)
        {
            throw new NotImplementedException();
        }
    }
}
