using BlazorApp1.Server.Models;
using BlazorApp1.Server.Repository;

namespace BlazorApp1.Server.Service
{
    public class WorkerService : IWorkerService
    {
        private readonly IRepository<Worker> _worker;

        public WorkerService(IRepository<Worker> worker)
        {
            _worker = worker;
        }
        public async Task<Worker> AddWorker(Worker worker)
        {
            return await _worker.CreateAsync(worker);
        }

        public async Task<bool> DeleteWorker(int id)
        {
            await _worker.DeleteAsync(id);
            return true;
        }

        public async Task<List<Worker>> GetAllWorkers()
        {
            return await _worker.GetAllAsync();
        }

        public async Task<Worker> GetWorker(int id)
        {
            return await _worker.GetByIdAsync(id);
        }

        public async Task<bool> UpdateWorker(int id, Worker worker)
        {
            var data = await _worker.GetByIdAsync(id);
            if (data != null)
            {
                data.CedulaTra = worker.CedulaTra;
                data.Nombre = worker.Nombre;
                data.Apellido = worker.Apellido;
                data.Puesto = worker.Puesto;
                data.Edad = worker.Edad;
                data.Telefono = worker.Telefono;
                data.Correo = worker.Correo;
                data.FechaNacimiento = worker.FechaNacimiento;
                data.Nacionalidad = worker.Nacionalidad;
                data.Ciudad = worker.Ciudad;
                data.Direccion = worker.Direccion;
                data.FechaEmpleo = worker.FechaEmpleo;
                data.Empleador = worker.Empleador;
                data.FechaDespido = worker.FechaDespido;
                data.InicioIncapacidad = worker.InicioIncapacidad;
                data.FinalIncapacidad = worker.FinalIncapacidad;
                data.Padecimientos = worker.Padecimientos;
                data.Estado = worker.Estado;
                data.Observacion = worker.Observacion;
                await _worker.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
    }
}
