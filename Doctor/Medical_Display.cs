using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Data_layer;
using LumenWorks.Framework.IO.Csv;


namespace Doctor
{
    public partial class Medical_Display : Form
    {
        private string _pathLead1 = @"C:\Users\ina-m\OneDrive\Dokumenter\4. semester\Projekt\EKG-signaler\1Lead.csv";

        

        private TeleMedDb _teleMedDb;
        private TeleMedDb.PatientMeasurement _patientMeasurement;
        List<TeleMedDb.PatientMeasurement> _patient = new List<TeleMedDb.PatientMeasurement>();
        List<TeleMedDb.ECGMeasurement> _ecgMeasurementsList = new List<TeleMedDb.ECGMeasurement>();

        public Medical_Display(TeleMedDb teleMedDb, TeleMedDb.PatientMeasurement patientMeasurement)
        {
            _teleMedDb = teleMedDb;
            _patientMeasurement = patientMeasurement;
            InitializeComponent();
        }

        public byte[] ReadCsvLead1()
        {
            //1. Lead
            var csvTable1 = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(System.IO.File.OpenRead(_pathLead1)), true))
            {
                csvTable1.Load(csvReader);

            }
            return ConvertDataTableToByteArray(csvTable1);
        }

        private byte[] ConvertDataTableToByteArray(DataTable dataTableConvert)
        {
            byte[] binaryDataResult = null;
            using (MemoryStream memStream = new MemoryStream())
            {
                BinaryFormatter brFormatter = new BinaryFormatter();
                dataTableConvert.RemotingFormat = System.Data.SerializationFormat.Binary;
                brFormatter.Serialize(memStream, dataTableConvert);
                binaryDataResult = memStream.ToArray();
                
            }
            return binaryDataResult;
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
            //int Id = 0;

            byte[] test = ReadCsvLead1();
            double xtid = 0;
            List<double> ecgLeadsList = new List<double>();
            ECG1Chart.Visible = true;
            for (int i = 2; i < test.Length-4; i += 8)
            {
                ecgLeadsList.Add(BitConverter.ToDouble(test, i));
            }

            foreach (var VARIABLE in ecgLeadsList)
            {
                ECG1Chart.Series[0].Points.AddXY(xtid, VARIABLE);
                xtid += 0.005;
            }


            //for (int i = 0; i < _patient.Count; i++)
            //{
            //    if (Convert.ToDateTime(DateLB.SelectedItem) == _patient[i].Date)
            //    {
            //        Id = _patient[i].PatientMeasurementId;
            //    }
            //}

            //_patientMeasurement = _teleMedDb.GetMeasurementsAndLeads(Id);

            //_ecgMeasurementsList = _patientMeasurement.ECGMeasurements;

            //int counterMeasure = 0;
            //Chart helperChart = null;

            //ECG1Chart.Visible = true;
            //ECG2Chart.Visible = true;
            //ECG3Chart.Visible = true;

            //foreach (var measure in _ecgMeasurementsList) // Vi kigger på hver måling 
            //{
            //    int coutnerLeads = 0;

            //    if (counterMeasure == 0)
            //    {
            //        helperChart = ECG1Chart;
            //        puls1l.Text = Convert.ToString(measure.Pulse);
            //        hrv1l.Text = Convert.ToString(measure.HRV);
            //    }

            //    if (counterMeasure == 1)
            //    {
            //        helperChart = ECG2Chart;
            //        puls2l.Text = Convert.ToString(measure.Pulse);
            //        hrv2l.Text = Convert.ToString(measure.HRV);
            //    }

            //    if (counterMeasure == 2)
            //    {
            //        helperChart = ECG3Chart;
            //        puls3l.Text = Convert.ToString(measure.Pulse);
            //        hrv3l.Text = Convert.ToString(measure.HRV);
            //    }

            //    foreach (var lead in measure.ECGLeads) // Vi kigger på hver lead til den pågældende måling 
            //    {
            //        for (int i = 0; i < lead.ECGLeadValues.Length; i += 8)
            //        {
            //            List<double> ecgLeadsList = new List<double>();
            //            //ecgLeadsList.Add(BitConverter.ToDouble(lead.ECGLeadValues, i)); // Converterer fra byte array til list double
            //            ecgLeadsList.Add(BitConverter.ToDouble(test, i));

            //            //helperChart.Series[coutnerLeads].Points.DataBindXY(ecgLeadsList); // Tegner graf
            //            helperChart.Series[coutnerLeads].Points.DataBindXY(test);
            //        }

            //        coutnerLeads++;
            //    }

            //    counterMeasure++;
            //}
        }
    }
}
