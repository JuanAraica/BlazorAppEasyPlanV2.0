using BlazorApp1.Server.Models;

namespace BlazorApp1.Server.Service
{
    public interface ISalarioService
    {
        Task<Salario> AddSalario(Salario salario);
        Task<bool> UpdateSalario(int id, Salario salario);
        Task<bool> DeleteSalario(int id);
        Task<List<Salario>> GetAllSalarios();
        Task<Salario> GetSalario(int id);
    }
}
