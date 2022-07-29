using BlazorApp1.Server.Models;

namespace BlazorApp1.Server.Service
{
    public interface IAdelantoService
    {
        Task<Adelanto> AddAdelanto(Adelanto adelanto);
        Task<bool> UpdateAdelanto(int id, Adelanto adelanto);
        Task<bool> DeleteAdelanto(int id);
        Task<List<Adelanto>> GetAllAdelantos();
        Task<Adelanto> GetAdelanto(int id);
    }
}
