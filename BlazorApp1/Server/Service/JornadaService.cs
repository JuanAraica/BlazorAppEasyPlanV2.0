using BlazorApp1.Server.AppDbContext;
using BlazorApp1.Server.Models;
using BlazorApp1.Server.Repository;
using Microsoft.EntityFrameworkCore;
namespace BlazorApp1.Server.Service
{
    public class JornadaService : IJornadaService
    {
        private readonly IRepository<Jornada> _jornada;
        public JornadaService(IRepository<Jornada> jornada)
        {
            _jornada = jornada;
        }
        public async Task<Jornada> AddJornada(Jornada jornada)
        {
            return await _jornada.CreateAsync(jornada);
        }

        public async Task<bool> DeleteJornada(int id)
        {
            await _jornada.DeleteAsync(id);
            return true;
        }

        public async Task<List<Jornada>> GetAllJornadas()
        {
            return await _jornada.GetAllAsync();
        }

        public async Task<Jornada> GetJornada(int id)
        {
            return await _jornada.GetByIdAsync(id);
        }

        public async Task<bool> UpdateJornada(int id, Jornada jornada)
        {
            var data = await _jornada.GetByIdAsync(id);
            if (data != null)
            {
                data.CedulaTra = jornada.CedulaTra;
                data.nombreJornada = jornada.nombreJornada;
                data.FechaJornada = jornada.FechaJornada;
                data.TipoJornada = jornada.TipoJornada;
                data.HoraInicio = jornada.HoraInicio;
                data.HoraFin = jornada.HoraFin;
                data.PrecioHoraRegular = jornada.PrecioHoraRegular;
                data.PrecioHoraExtra = jornada.PrecioHoraExtra;
                data.CantidadHorasRegulares = jornada.CantidadHorasRegulares;
                data.CantidadHorasExtras = jornada.CantidadHorasExtras;
                data.ValorTotalHoraExtra = jornada.ValorTotalHoraExtra;
                data.ValorTotalHorasRegulares = jornada.ValorTotalHorasRegulares;
                data.PrecioDia = jornada.PrecioDia;
                data.UnidadMedida = jornada.UnidadMedida;
                data.PrecioUnidadMedida = jornada.PrecioUnidadMedida;
                data.ValorTotalUnidadMedida = jornada.ValorTotalUnidadMedida;
                data.PrecioMetro = jornada.PrecioMetro;
                data.PrecioPaquete = jornada.PrecioPaquete;
                data.LaborExtra = jornada.LaborExtra;
                data.PrecioLaborExtra = jornada.PrecioLaborExtra;
                data.SalarioJornada = jornada.SalarioJornada;
                data.Observacion = jornada.Observacion;
                await _jornada.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
    }
}
