using BlazorApp1.Server.AppDbContext;
using BlazorApp1.Server.Models;
using BlazorApp1.Server.Repository;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Server.Service
{
    public class SalarioService : ISalarioService
    {
        private readonly IRepository<Salario> _salario;
        public SalarioService(IRepository<Salario> salario)
        {
            _salario = salario;
        }




        public async Task<Salario> AddSalario(Salario salario)
        {
            return await _salario.CreateAsync(salario);
        }

        public async Task<bool> DeleteSalario(int id)
        {
            await _salario.DeleteAsync(id);
            return true;
        }

        public async Task<List<Salario>> GetAllSalarios()
        {
            return await _salario.GetAllAsync();
        }

        public async Task<Salario> GetSalario(int id)
        {
            return await _salario.GetByIdAsync(id);
        }

        public async Task<bool> UpdateSalario(int id, Salario salario)
        {
            var data = await _salario.GetByIdAsync(id);
            if (data != null)
            {
                data.CedulaTra = salario.CedulaTra;
                data.SalarioBruto = salario.SalarioBruto;
                data.Seguro = salario.Seguro;
                data.Adelantos = salario.Adelantos;
                data.Otros = salario.Otros;
                data.SalarioNeto = salario.SalarioNeto;
                data.PrimeraFecha = salario.PrimeraFecha;
                data.UltimaFecha = salario.UltimaFecha;
                data.TotalDeducciones = salario.TotalDeducciones;
                data.FechaSalario = salario.FechaSalario;
                await _salario.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
    }
}
