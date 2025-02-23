using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.EntityFramework;
using Gestion_medicale.Model;

namespace Gestion_medicale.Data
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]

    public class BdRdvMedicalContext : DbContext
    {
        public BdRdvMedicalContext()
            : base("name=RdvMedicalDB") { }

        public DbSet<Personne> Personne { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Utilisateurs> Utilisateurs { get; set; }
        public DbSet<Medecins> Medecins { get; set; }
        public DbSet<Secretaires> Secretaires { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }
        public DbSet<GroupeSanguin> GroupeSanguin { get; set; }
        public DbSet<Specialite> Specialite { get; set; }
        public DbSet<SoinAdministre> SoinAdministre { get; set; }
    }
}