using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_medicale.Model
{
    public class RendezVous
    {
        [Key]
        public int IdRV { get; set; }

        [Required]
        public DateTime DateRV { get; set; }

        [Required, MaxLength(50)]
        public string Statut { get; set; }

        [Required]
        public int IdSoin { get; set; }
        [ForeignKey("IdSoin")]

        [Required]
        public int MedecinId { get; set; }

        public virtual Patient Patient { get; set; }
        public virtual Medecins Medecin { get; set; }
    }
}
