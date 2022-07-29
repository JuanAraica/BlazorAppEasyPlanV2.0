using BlazorApp1.Server.Models;

namespace BlazorApp1.Server.Service
{
    public interface IWorkerService
    {
        Task<Worker> AddWorker(Worker worker);
        Task<bool> UpdateWorker(int id, Worker worker);
        Task<bool> DeleteWorker(int id);
        Task<List<Worker>> GetAllWorkers();
        Task<Worker> GetWorker(int id);
    }
}
