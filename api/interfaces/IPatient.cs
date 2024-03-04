using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using api.entities;

namespace api.Interfaces
{
    public interface IPatient
    {
        Task<Patient> getSpecificPatient(int Id);
        Task<List<Patient>> getListOfPatients();
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        Task<bool> SaveAll();
    }
}