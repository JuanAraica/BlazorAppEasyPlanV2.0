using BlazorApp1.Server.Models;

namespace BlazorApp1.Server.Service
{
    public interface IJornadaService
    {
        Task<Jornada> AddJornada(Jornada jornada);
        Task<bool> UpdateJornada(int id, Jornada jornada);
        Task<bool> DeleteJornada(int id);
        Task<List<Jornada>> GetAllPersons();
        Task<Jornada> GetPerson(int id);
    }
}
