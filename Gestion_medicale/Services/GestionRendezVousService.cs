using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_medicale.Interfaces;
using Gestion_medicale.Model;

namespace Gestion_medicale.Services
{
    internal class GestionRendezVousService : IGestionRendezVous
    {
        private List<RendezVous> rendezVousList = new List<RendezVous>();

        public void CreerRendezVous(RendezVous rdv)
        {
            rdv.IdRV = rendezVousList.Count + 1;
            rdv.Statut = "Confirmé";
            rendezVousList.Add(rdv);
            Console.WriteLine($"Rendez-vous créé pour {rdv.Patient.NomPrenom} avec le Dr. {rdv.Medecin.NomPrenom} le {rdv.DateRV}.");
        }

        public void ModifierRendezVous(RendezVous rdv)
        {
            var rdvExist = rendezVousList.FirstOrDefault(r => r.IdRV == rdv.IdRV);
            if (rdvExist != null)
            {
                rdvExist.DateRV = rdv.DateRV;
                rdvExist.Statut = rdv.Statut;
                rdvExist.Patient = rdv.Patient;
                rdvExist.Medecin = rdv.Medecin;
                Console.WriteLine($"Rendez-vous ID {rdv.IdRV} modifié avec succès.");
            }
            else
            {
                Console.WriteLine("Rendez-vous introuvable.");
            }
        }

        public void AnnulerRendezVous(int id)
        {
            var rdv = rendezVousList.FirstOrDefault(r => r.IdRV == id);
            if (rdv != null)
            {
                rdv.Statut = "Annulé";
                Console.WriteLine($"Rendez-vous ID {id} annulé avec succès.");
            }
            else
            {
                Console.WriteLine("Rendez-vous introuvable.");
            }
        }

        public List<RendezVous> ListerRendezVous()
        {
            return rendezVousList;
        }
        public interface INotification
        {
            void EnvoyerNotification(string message, Personne destinataire);
        }
    }

}

