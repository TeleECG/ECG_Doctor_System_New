using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_layer;
using Data_layer.Data;
using Doctor;
using Microsoft.EntityFrameworkCore;


namespace MainApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var program = new Program();
        }

        public Program()
        {
            //Datalayer 
            TeleMedUtilities _teleMedDb = new TeleMedUtilities();
            PatientMeasurements _patientMeasurement = new PatientMeasurements();
            ECGMeasurements _ecgMeasurement = new ECGMeasurements();
            ECGLeads _ecgLead = new ECGLeads();

            //Presentationlayer 
            IForm _GUI = new Doctor.Program(_teleMedDb);
            _GUI.Start();

        }
    }
}


