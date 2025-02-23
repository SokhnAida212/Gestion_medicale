using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_medicale.Model
{
    public class Secretaires : Utilisateurs
    {
        [MaxLength(15)]
        public string TelephoneFixe { get; set; }

    }
}
