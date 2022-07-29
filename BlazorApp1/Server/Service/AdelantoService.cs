using BlazorApp1.Server.Models;
using BlazorApp1.Server.Repository;

namespace BlazorApp1.Server.Service
{
    public class AdelantoService : IAdelantoService
    {
        private readonly IRepository<Adelanto> _adelanto;
        public AdelantoService(IRepository<Adelanto> adelanto)
        {
            _adelanto = adelanto;
        }
        public async Task<Adelanto> AddAdelanto(Adelanto adelanto)
        {
            return await _adelanto.CreateAsync(adelanto);
        }

        public async Task<bool> DeleteAdelanto(int id)
        {
            await _adelanto.DeleteAsync(id);
            return true;
        }

        public async Task<Adelanto> GetAdelanto(int id)
        {
            return await _adelanto.GetByIdAsync(id);
        }

        public async Task<List<Adelanto>> GetAllAdelantos()
        {
            return await _adelanto.GetAllAsync();
        }

        public async Task<bool> UpdateAdelanto(int id, Adelanto adelanto)
        {
            var data = await _adelanto.GetByIdAsync(id);
            if (data != null)
            {
                data.CedulaTra = adelanto.CedulaTra;
                data.Monto = adelanto.Monto;
                data.FechaAdelanto = adelanto.FechaAdelanto;
                data.EmisorAdelanto = adelanto.EmisorAdelanto;
                await _adelanto.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
    }
}
