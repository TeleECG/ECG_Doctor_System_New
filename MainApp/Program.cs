using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_layer;
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
            TeleMedDb _teleMedDb = new TeleMedDb();
            TeleMedDb.PatientMeasurement _patientMeasurement = new TeleMedDb.PatientMeasurement();
            TeleMedDb.ECGMeasurement _ecgMeasurement = new TeleMedDb.ECGMeasurement();
            TeleMedDb.ECGLead _ecgLead = new TeleMedDb.ECGLead();

            //Presentationlayer 
            IForm _GUI = new Doctor.Program(_teleMedDb, _patientMeasurement, _ecgMeasurement, _ecgLead);
            _GUI.Start();

        }
    }
}


