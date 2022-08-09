using BlazorApp1.Server.AppDbContext;
using BlazorApp1.Server.Models;
using BlazorApp1.Server.Repository;
using Microsoft.EntityFrameworkCore;
namespace BlazorApp1.Server.Service
{
    public class HistorialService : IHistorialService
    {
        private readonly IRepository<Historial> _historial;
        public HistorialService(IRepository<Historial> historial)
        {
            _historial = historial;
        }


        public async Task<Historial> AddHistorial(Historial historial)
        {
            return await _historial.CreateAsync(historial);
        }

        public async Task<bool> DeleteHistorial(int id)
        {
            await _historial.DeleteAsync(id);
            return true;
        }

        public async Task<List<Historial>> GetAllHistorials()
        {
            return await _historial.GetAllAsync();
        }

        public async Task<Historial> GetHistorial(int id)
        {
            return await _historial.GetByIdAsync(id);
        }

        public async Task<bool> UpdateHistorial(int id, Historial historial)
        {
            var data = await _historial.GetByIdAsync(id);
            if (data != null)
            {
                data.Registro = historial.Registro;
                data.fecha = historial.fecha;
                await _historial.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
    }
}
