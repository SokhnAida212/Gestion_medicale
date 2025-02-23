﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_medicale.Model
{
    public class Soin
    {
        [Key]
        public int IdSoin { get; set; }

        [Required]
        [MaxLength(100)]
        public string NomSoin { get; set; }

        public virtual ICollection<SoinAdministre> SoinsAdministres { get; set; } = new List<SoinAdministre>();
    }
}
