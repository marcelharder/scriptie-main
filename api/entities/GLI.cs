using System.ComponentModel.DataAnnotations;

namespace api.entities {
public class GLI
    {
        [Key]
        public int GliId { get; set; }
        public string measured {get; set;}
        public string predicted {get; set;}
        public string zscore {get; set;}
        public string LLN {get; set;}
        public string ULN {get; set;}
        public string Perc_Predicted {get; set;}
        public string BDR_perc_changed {get; set;}
        public Patient Patient {get; set;}
        public int PatientId{get; set;}
    }
}