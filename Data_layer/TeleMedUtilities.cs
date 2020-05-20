using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Data_layer.Data;


namespace Data_layer
{
    public class TeleMedUtilities
    {
        public List<PatientMeasurements> GetPatient(string CPR)
        {
            using (var context = new F20ST4PRJ4TeleMedDatabaseContext())
            {
                var patientMeasurements = context.PatientMeasurements.Where(patient => patient.CPRNumber == CPR).ToList();
                return patientMeasurements;
            }
        }

        public PatientMeasurements GetMeasurementsAndLeads(int ID)
        {
            using (var context = new F20ST4PRJ4TeleMedDatabaseContext())
            {
                var patientWithMeasurements = context.PatientMeasurements.Where(patient => patient.PatientMeasurementId == ID).
                    Include(measure => measure.ECGMeasurements).
                    ThenInclude(leads => leads.ECGLeads).FirstOrDefault();

                return patientWithMeasurements;
            }
        }
    }
  
}
