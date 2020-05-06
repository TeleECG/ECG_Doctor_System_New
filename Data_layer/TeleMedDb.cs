using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace Data_layer
{
    public class TeleMedDb : DbContext
    {
        public DbSet<PatientMeasurement> PatientMeasurements { get; set; } // En liste af patients - den modsvarer tabellen i databasen. 
        public DbSet<ECGMeasurement> ECGMeasurements { get; set; } // En liste af ECGMeasurements - den modsvarer tabellen i databasen.
        public DbSet<ECGLead> ECGLeads { get; set; } // En liste af ECGLeads - den modsvarer tabellen i databasen.

        private const String _database = "F20ST4PRJ4TeleMedDatabase";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=st-i4dab.uni.au.dk; Initial Catalog=" + _database + "; " +
                                 "Persist Security Info=True; User ID=" + _database + "; Password=" + _database + "");
        } // Åbner forbindelse til database og holder øje med at der er konsistens mellem database og koden

        public List<PatientMeasurement> GetPatient(string CPR)
        {
           using (var context = new TeleMedDb())
           {
                var patientMeasurement = context.PatientMeasurements.Where(patient => patient.CPRNumber == CPR).ToList();
                return patientMeasurement;
           }
        }

        public PatientMeasurement GetMeasurementsAndLeads(int ID)
        {
            using (var context = new TeleMedDb())
            {
                var patientWithMeasurement = context.PatientMeasurements.Where(patient => patient.PatientMeasurementId == ID).
                    Include(measure => measure.ECGMeasurements).
                    ThenInclude(leads => leads.ECGLeads).FirstOrDefault();

                return patientWithMeasurement;
            }
        }

        public class PatientMeasurement // Patient klassen sendes i databasen med følgende: 
        {
            public PatientMeasurement() //Default constructor
            {
                ECGMeasurements = new List<ECGMeasurement>();
            }

            public int PatientMeasurementId { get; set; } //Et autogenerede Id-nummer, der kun passer til den specifikke patient. 
            public string CPRNumber { get; set; } // CPR-nummer tilhørende patienten, som indtastes på brugergrænsefladen.
            public string Name { get; set; } // Navn tilhørende patienten, som indtastes på brugergrænsefladen.
            public string Address { get; set; } // Adresse tilhørende patienten, som indtastes på brugergrænsefladen.
            public DateTime Date { get; set; } // Autogenereret dato, der passer til tidspunktet dataen flyttes til databasen. 
            public List<ECGMeasurement> ECGMeasurements { get; } // En liste bestående af objekter af klassen ECGMeasurement.
        }

        public class ECGMeasurement // ECGMeasurement klassen sendes i databasen og kobles op med Patientobjektet med følgende: 
        {
            public ECGMeasurement()
            {
                ECGLeads = new List<ECGLead>();
            }

            public int ECGMeasurementId { get; set; } //Et autogenerede Id-nummer, der kun passer til den specifikke ECGMeasurement. 
            public PatientMeasurement PatientMeasurement { get; set; } //Objekt af Patient klassen
            public int PatientMeasurementId { get; set; } //Tilknytter ECGMeasurement til den specifikke Patient via PatientId
            public int MeasurementNumber { get; set; } // Et nummer der afgør om det er 1., 2., eller 3. måling
            public List<ECGLead> ECGLeads { get; set; } // En liste bestående af objekter af klassen ECGLead.
            public int Pulse { get; set; } // Patientens puls, som er udregnet ud fra den målte EKG data.
            public int HRV { get; set; } // Patientens HRV, som er udregnet ud fra den målte EKG data.

        }
        public class ECGLead // ECGMeasurement klassen sendes i databasen og kobles op med ECGMeasurementobjektet med følgende: 
        {
            public ECGLead()
            {
                
            }

            public int ECGLeadId { get; set; } //Et autogenerede Id-nummer, der kun passer til det specifikke ECGLead. 
            public ECGMeasurement ECGMeasurement { get; set; } //Objekt af ECGMeasurement klassen 
            public int ECGMeasurementId { get; set; } //Tilknytter ECGMeasurement til den specifikke ECGMeasurement via ECGMeasurementId
            public int LeadNumber { get; set; } // Et nummer der afgør om det er 1., 2., eller 3. afledning der i dette lead er målt
            public byte[] ECGLeadValues { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        }
    }
}
