using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Data_layer;
using Data_layer.Data;

// Reference til eventhandler: https://www.codeproject.com/Articles/1276879/MSChart-Extension-Zoom-and-Pan-Control-Version-2-2
namespace Doctor
{
    public partial class Medical_Display : Form
    {
        private TeleMedUtilities _teleMedDb;
        private F20ST4PRJ4TeleMedDatabaseContext context;
        List<PatientMeasurements> _patient = new List<PatientMeasurements>();
        List<ECGMeasurements> _ecgMeasurementsList = new List<ECGMeasurements>();

        public Medical_Display(TeleMedUtilities teleMedDb)
        {
            _teleMedDb = teleMedDb;
            InitializeComponent();
            //ECG1Chart.EnableZoomAndPanControls(ChartCursorSelected, ChartCursorMoved,
            //    zoomChanged,
            //    new ChartOption()
            //    {
            //        ContextMenuAllowToHideSeries = true,
            //        XAxisPrecision = 0,
            //        YAxisPrecision = 2
            //    });

            // Client interface BUG:
            // OnAxisViewChang* is only called on Cursor_MouseUp, 
            //  so the following events are never raised
            //ECG1Chart.AxisViewChanging += OnAxisViewChanges;
            //ECG1Chart.AxisViewChanged += OnAxisViewChanges;
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
                if(DateLB.SelectedItem.Equals(_patient[i].Date.ToString()))
                {
                    Id = _patient[i].PatientMeasurementId;
                }
            }

            var _patientMeasurement = _teleMedDb.GetMeasurementsAndLeads(Id);

            _ecgMeasurementsList = _patientMeasurement.ECGMeasurements.ToList(); 
            
            int counterMeasure = 0;
           
            Chart helperChart = null;

            ECG1Chart.Visible = true;
            //ECG1Chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            //ECG1Chart.MouseWheel += chart_MouseWheel;
            ECG2Chart.Visible = true;
            //ECG2Chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            //ECG2Chart.MouseWheel += chart_MouseWheel;
            ECG3Chart.Visible = true;
            //ECG3Chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            //ECG3Chart.MouseWheel += chart_MouseWheel;

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

                double xtime = 0;
                List<double> ecgLeadsList = new List<double>();

                foreach (var lead in measure.ECGLeads) // Vi kigger på hver lead til den pågældende måling 
                {
                    for (int i = 0; i < lead.ECGLeadValues.Length; i += 8)
                    {
                        ecgLeadsList.Add(BitConverter.ToDouble(lead.ECGLeadValues, i)); // Converterer fra byte array til list double
                    }
                   
                    coutnerLeads++;
                }

                foreach (var values in ecgLeadsList)
                {
                    helperChart.Series[0].Points.AddXY(xtime, values); // Tegner graf
                    xtime += 0.002;
                }

                counterMeasure++;
            }
        }

        //private void OnAxisViewChanges(object sender, ViewEventArgs viewEventArgs)
        //{
        //    Debug.Fail("Don't worry, this event is never raised.");
        //}

        //private void ChartCursorSelected(Chart sender, ChartCursor e)
        //{
        //    //txtChartSelect.Text = e.X.ToString("F4") + ", " + e.Y.ToString("F4");
        //    //PointF diff = sender.CursorsDiff();
        //    //txtCursorDelta.Text = diff.X.ToString("F4") + ", " + diff.Y.ToString("F4");
        //}

        //private void ChartCursorMoved(Chart sender, ChartCursor e)
        //{
        //    //txtChartValue.Text = e.X.ToString("F4") + ", " + e.Y.ToString("F4");
        //}

        //private void zoomChanged(Chart sender)
        //{
        //}

        // Her er referencen brugt
        //private void chart_MouseWheel(object sender, MouseEventArgs e)
        //{
        //    var chart = (Chart)sender;
        //    var xAxis = chart.ChartAreas[0].AxisX;
        //    var yAxis = chart.ChartAreas[0].AxisY;

        //    try
        //    {
        //        if (e.Delta < 0) // Scrolled down.
        //        {
        //            xAxis.ScaleView.ZoomReset();
        //            yAxis.ScaleView.ZoomReset();
        //        }
        //        else if (e.Delta > 0) // Scrolled up.
        //        {
        //            var xMin = xAxis.ScaleView.ViewMinimum;
        //            var xMax = xAxis.ScaleView.ViewMaximum;
        //            var yMin = yAxis.ScaleView.ViewMinimum;
        //            var yMax = yAxis.ScaleView.ViewMaximum;

        //            var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
        //            var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
        //            var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
        //            var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

        //            xAxis.ScaleView.Zoom(posXStart, posXFinish);
        //            yAxis.ScaleView.Zoom(posYStart, posYFinish);
        //        }
        //    }
        //    catch { }
        //}
    }
}
