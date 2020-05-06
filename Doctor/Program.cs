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

        public Program(TeleMedDb teleMedDb, TeleMedDb.PatientMeasurement patientMeasurement)
        {
            _teleMedDb = teleMedDb;
            _patientMeasurement = patientMeasurement;
        }

        [STAThread]
        public override void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Medical_Display(_teleMedDb,_patientMeasurement));
        }
    }
}
