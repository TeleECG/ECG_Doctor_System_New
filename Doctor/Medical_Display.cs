﻿using System;
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

        private List<double> LeadReader1()
        {
            using (var reader = new StreamReader(@"C:\Users\Mie\Cloud\MiesTing\Universitet - ST\4.Semester ST\4. Semesterprojekt\Software\ECG_Doctor_System_New\Data_layer\1Lead.csv"))
            {
                List<double> listA = new List<double>();
                var h1= reader.ReadLine();
               var h2 =  reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listA.Add(Convert.ToDouble(Double.Parse(values[1].Replace('.', ',')))); //Prøv parse i stedet for konvertering til double 
                    
                }

                return listA;
            }
        }

        private List<double> LeadReader2()
        {
            using (var reader = new StreamReader(@"C:\Users\Mie\Cloud\MiesTing\Universitet - ST\4.Semester ST\4. Semesterprojekt\Software\ECG_Doctor_System_New\Data_layer\2Lead.csv"))
            {
                List<double> listA = new List<double>();
                var h1 = reader.ReadLine();
                var h2 = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listA.Add(Convert.ToDouble(Double.Parse(values[1].Replace('.', ',')))); //Prøv parse i stedet for konvertering til double 

                }

                return listA;
            }
        }
        private List<double> LeadReader3()
        {
            using (var reader = new StreamReader(@"C:\Users\Mie\Cloud\MiesTing\Universitet - ST\4.Semester ST\4. Semesterprojekt\Software\ECG_Doctor_System_New\Data_layer\3Lead.csv"))
            {
                List<double> listA = new List<double>();
                var h1 = reader.ReadLine();
                var h2 = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listA.Add(Convert.ToDouble(Double.Parse(values[1].Replace('.', ',')))); //Prøv parse i stedet for konvertering til double 

                }

                return listA;
            }
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
            List<double> lead1Liste = LeadReader1();
            List<double> lead2Liste = LeadReader2();
            List<double> lead3Liste = LeadReader3();
            double xtid = 0;
            ECG1Chart.Visible = true;
            foreach (var data in lead1Liste)
            {
                ECG1Chart.Series[0].Points.AddXY(xtid, data);
                xtid += 0.002;
            }

            foreach (var data in lead2Liste)
            {
                ECG1Chart.Series[0].Points.AddXY(xtid, data);
                xtid += 0.002;
            }
            foreach (var data in lead3Liste)
            {
                ECG1Chart.Series[0].Points.AddXY(xtid, data);
                xtid += 0.002;
            }

            //Nedenstående kode er den kode som skal bruges når vi kan hente ned fra databasen
            //int Id = 0;

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
            //            //helperChart.Series[coutnerLeads].Points.DataBindXY(ecgLeadsList); // Tegner graf
            //            
            //        }

            //        coutnerLeads++;
            //    }

            //    counterMeasure++;
            //}
        }
    }
}
