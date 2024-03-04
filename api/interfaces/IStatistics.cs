using System.Threading.Tasks;
using api.entities;

namespace api.Interfaces
{
    public interface IStatistics
    {
        Task<CAS> CalculateCASFEV1(string value);
        Task<CAS> CalculateCASTLC(string value);
        Task<CAS> CalculateCASRV(string value);
        Task<CAS> CalculateCASERV(string value);
        Task<CAS> CalculateCASIC(string value);
        Task<CAS> CalculateCASVC(string value);
      
        Task<GLI> CalculateGLIFEV1(string value);
        Task<GLI> CalculateGLITLC(string value);
        Task<GLI> CalculateGLIRV(string value);
        Task<GLI> CalculateGLIERV(string value);
        Task<GLI> CalculateGLIIC(string value);
        Task<GLI> CalculateGLIVC(string value);
       

    }
}