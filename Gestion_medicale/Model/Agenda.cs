using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_medicale.Model
{
    public class Agenda
    {
        [Key]
        public int IdAgenda { get; set; }
        public DateTime? DatePlanifie { get; set; }
        public string Titre { get; set; }
        public string HeureDebut { get; set; }
        public string HeureFin { get; set; }
        public int Creneau { get; set; }
        public string Lieu { get; set; }
        public string Statut { get; set; }
        public int IdMedecin { get; set; }
        [ForeignKey("IdMedecin")]
        public Medecins Medecin { get; set; }
        public int IdRV { get; set; }
        [ForeignKey("IdRV")]
        public RendezVous RendezVous{ get; set; }
    }
}
