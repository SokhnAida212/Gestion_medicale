using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_medicale.Model
{
    public class Patient : Personne
    {
        public int IdPatient { get; set; }

        [Required, MaxLength(3)]
        public string GroupeSanguin { get; set; }
        [Required]
        public float? Poids { get; set; }
        [Required]
        public float? Taille { get; set; }
        public int? IdSoin { get; set; }
        public virtual Soin Soin { get; set; }  

        public virtual ICollection<SoinAdministre> SoinsRecus { get; set; }

    }
}
