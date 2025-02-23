using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_medicale.Model
{
    public class SoinAdministre
    {
        [Key]
        public int Id { get; set; }

        public int IdSoin { get; set; }
        public int IdPatient { get; set; }
        public int IdMedecin { get; set; }

        [ForeignKey("IdSoin")]
        public virtual Soin Soin { get; set; }

        [ForeignKey("IdPatient")]
        public virtual Patient Patient { get; set; }

        [ForeignKey("IdMedecin")]
        public virtual Medecins Medecin { get; set; }
    }
}