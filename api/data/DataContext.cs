using api.entities;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;

namespace api.data{

public class DataContext: DbContext
{
    
   public DataContext(DbContextOptions options): base(options)
    {

    }

    public DbSet<AppUser> Users {get; set;}
    public DbSet<Patient> Patients {get; set;}

    public DbSet<GLI> glis {get; set;}
    public DbSet<CAS> cas {get; set;}

}
}