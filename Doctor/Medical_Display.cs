using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Data_layer;

namespace Doctor
{
    public partial class Medical_Display : Form
    {
        private TeleMedDb _teleMedDb;
        private TeleMedDb.PatientMeasurement _patientMeasurement;
        private TeleMedDb.ECGMeasurement _ecgMeasurement;
        private TeleMedDb.ECGLead _ecgLead;
        List<TeleMedDb.PatientMeasurement> _patient = new List<TeleMedDb.PatientMeasurement>();
        List<TeleMedDb.ECGMeasurement> _ecgMeasurementsList = new List<TeleMedDb.ECGMeasurement>();

        public Medical_Display(TeleMedDb teleMedDb, TeleMedDb.PatientMeasurement patientMeasurement, TeleMedDb.ECGMeasurement ecgMeasurement, TeleMedDb.ECGLead ecgLead)
        {
            _teleMedDb = teleMedDb;
            _patientMeasurement = patientMeasurement;
            _ecgMeasurement = ecgMeasurement;
            _ecgLead = ecgLead;
            InitializeComponent();
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            _patient = _teleMedDb.GetPatient(CPRTB.Text);
            if (_patient.Count != 0)
            {
                NameTB.Text = _patient[0].Name;
                AdressTB.Text = _patient[0].Address;
                foreach (var VARIABLE in _patient)
                {
                    DateLB.Items.Add(Convert.ToString(VARIABLE.Date));
                }

                CPRTB.Clear();
            }
            else
                MessageBox.Show("CPR-nummer findes ikke i database");
                CPRTB.Clear();
        }

        private void DateB_Click(object sender, EventArgs e)
        {
            int Id = 0;


            for (int i = 0; i < _patient.Count; i++)
            {
                if (Convert.ToDateTime(DateLB.SelectedItem) == _patient[i].Date)
                {
                    Id = _patient[i].PatientMeasurementId;
                }
            }

            _patientMeasurement = _teleMedDb.GetMeasurementsAndLeads(Id);
            
            _ecgMeasurementsList = _patientMeasurement.ECGMeasurements;

            int counterMeasure = 0;
            Chart helperChart = null;

            ECG1Chart.Visible = true;
            ECG2Chart.Visible = true;
            ECG3Chart.Visible = true;

            foreach (var measure in _ecgMeasurementsList) // Vi kigger på hver måling 
            {
                int coutnerLeads = 0;

                if (counterMeasure == 0)
                {
                    helperChart = ECG1Chart;
                    puls1l.Text = Convert.ToString(measure.Pulse);
                    hrv1l.Text = Convert.ToString(measure.HRV);
                }

                if (counterMeasure == 1)
                {
                    helperChart = ECG2Chart;
                    puls2l.Text = Convert.ToString(measure.Pulse);
                    hrv2l.Text = Convert.ToString(measure.HRV);
                }

                if (counterMeasure == 2)
                {
                    helperChart = ECG3Chart;
                    puls3l.Text = Convert.ToString(measure.Pulse);
                    hrv3l.Text = Convert.ToString(measure.HRV);
                }

                foreach (var lead in measure.ECGLeads) // Vi kigger på hver lead til den pågældende måling 
                {
                    for (int i = 0; i < lead.ECGLeadValues.Length; i += 8)
                    {
                        List<double> ecgLeadsList = new List<double>();
                        ecgLeadsList.Add(BitConverter.ToDouble(lead.ECGLeadValues, i)); // Converterer fra byte array til list double

                        helperChart.Series[coutnerLeads].Points.DataBindXY(ecgLeadsList); // Tegner graf
                    }

                    coutnerLeads++;
                }

                counterMeasure++;
            }
        }
    }
}
