using BlazorApp1.Server.Models;

namespace BlazorApp1.Server.Service
{
    public interface IHistorialService
    {
        Task<Historial> AddHistorial(Historial historial);
        Task<bool> UpdateHistorial(int id, Historial historial);
        Task<bool> DeleteHistorial(int id);
        Task<List<Person>> GetAllHistorials();
        Task<Person> GetHistorial(int id);
    }
}
