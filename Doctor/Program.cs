using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_layer;


namespace Doctor
{
    public class Program : IForm
    {
        private TeleMedDb _teleMedDb;
        private TeleMedDb.PatientMeasurement _patientMeasurement;
        private TeleMedDb.ECGMeasurement _ecgMeasurement;
        private TeleMedDb.ECGLead _ecgLead;

        public Program(TeleMedDb teleMedDb, TeleMedDb.PatientMeasurement patientMeasurement, TeleMedDb.ECGMeasurement ecgMeasurement, TeleMedDb.ECGLead ecgLead)
        {
            _teleMedDb = teleMedDb;
            _patientMeasurement = patientMeasurement;
            _ecgMeasurement = ecgMeasurement;
            _ecgLead = ecgLead;
        }

        [STAThread]
        public override void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Medical_Display(_teleMedDb,_patientMeasurement,_ecgMeasurement,_ecgLead));
        }
    }
}
