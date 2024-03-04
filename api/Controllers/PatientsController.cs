using System.ComponentModel.Design;
using System.Data.Common;
using System.Threading.Tasks;
using api.entities;
using api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace scriptie.Controllers
{
    [ApiController]

    public class PatientsController : ControllerBase
    {
        private IPatient _patient;
        private IStatistics _stat;
        public PatientsController(IPatient patient, IStatistics stat)
        {
            _patient = patient;
            _stat = stat;
        }
        [HttpPost("api/AddPatient")]
        public async Task<IActionResult> addPatient()
        {
            var newPatient = new Patient();
            newPatient.gender = "Choose";
            _patient.Add(newPatient);

            if (await _patient.SaveAll())
            {
                var newCas = new CAS
                {
                    PatientId = newPatient.Id
                };
                _patient.Add(newCas);
                await _patient.SaveAll();

                var newGli = new GLI
                {
                    PatientId = newPatient.Id
                };
                _patient.Add(newGli);
                await _patient.SaveAll();


                return CreatedAtRoute("getPatient", new { id = newPatient.Id }, newPatient);
            };
            return BadRequest("cant add patient");
        }

        [HttpGet("api/getSpecificPatient/{id}", Name = "getPatient")]
        public async Task<IActionResult> getPatient(int id)
        {
            return Ok(await _patient.getSpecificPatient(id));
        }

        [HttpGet("api/getPatientList")]
        public async Task<IActionResult> getListOfPatients()
        {
            return Ok(await _patient.getListOfPatients());
        }

        [HttpPut("api/UpdatePatient")]
        public async Task<IActionResult> updatePatient([FromBody] Patient pat)
        {
            
            _patient.Update(pat);
            if (await _patient.SaveAll()) { return Ok(); } else { return BadRequest(""); }
        }

        [HttpGet("api/calculateCas/{id}/{value}")]
        public async Task<IActionResult> getCalculatedCas(int id, string value)
        {
            // Id = which calculation should be done, 1-FEV1, 2-TLC, 3-RV, 4-ERV, 5-IC, 6-VC
            // if value is bv RV if id = 3

            switch (id)
            {
                case 1: return Ok(await _stat.CalculateCASFEV1(value));
                case 2: return Ok(await _stat.CalculateCASTLC(value));
                case 3: return Ok(await _stat.CalculateCASRV(value));
                case 4: return Ok(await _stat.CalculateCASRV(value));
                case 5: return Ok(await _stat.CalculateCASIC(value));
                case 6: return Ok(await _stat.CalculateCASVC(value));

            }
            return BadRequest("Something went oops");

        }
        [HttpGet("api/calculateGli/{id}/{value}")]
        public async Task<IActionResult> getCalculatedGli(int id, string value)
        {
            // Id = which calculation should be done, 1-FEV1, 2-TLC, 3-RV, 4-ERV, 5-IC, 6-VC
            // if value is bv RV if id = 3

            switch (id)
            {
                case 1: return Ok(await _stat.CalculateGLIFEV1(value));
                case 2: return Ok(await _stat.CalculateGLITLC(value));
                case 3: return Ok(await _stat.CalculateGLIRV(value));
                case 4: return Ok(await _stat.CalculateGLIRV(value));
                case 5: return Ok(await _stat.CalculateGLIIC(value));
                case 6: return Ok(await _stat.CalculateGLIVC(value));

            }
            return BadRequest("Something went oops");

        }


    }
}
