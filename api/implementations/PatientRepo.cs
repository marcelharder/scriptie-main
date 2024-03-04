using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.data;
using api.entities;
using api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api.implementations
{
    public class PatientRepo : IPatient
    {
        private DataContext _context;
        public PatientRepo(DataContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<List<Patient>> getListOfPatients()
        {
            var vendors = new List<Patient>();
            await Task.Run(()=>{
            var help = _context.Patients.AsQueryable();
            foreach(Patient p in help){vendors.Add(p);}
            });
            
           return vendors;
        }

        public async Task<Patient> getSpecificPatient(int Id)
        {
            var help = await _context.Patients
            .Include(cas => cas.CAS)
            .Include(gli => gli.GLI)
            .FirstOrDefaultAsync(p => p.Id == Id);
            return help;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0; 
        }

        public void Update<T>(T entity) where T : class
        {
             _context.Update(entity);
        }
    }
}