using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Doctor
{
    public partial class Medical_Display : Form
    {
        private string _CPR = "";
        private ECG_Meassure _ecgMeassure;
        private Get_ECG_Controller _ecgController;

        public Medical_Display(Get_ECG_Controller ecgController, ECG_Meassure ecgMeassure)
        {
            _ecgController = ecgController;
            _ecgMeassure = ecgMeassure;
            InitializeComponent();
        }

        private void SearchB_Click(object sender, EventArgs e)
        {
            if (CPRTB.Text == _CPR)
            {

            }
        }

        private void DateB_Click(object sender, EventArgs e)
        {
            NameTB.Text = _ecgMeassure.Name;
            CPRTB.Text = _ecgMeassure.CPRNumber;
            ECG1Chart.Visible = true;
            ECG2Chart.Visible = true;
            ECG3Chart.Visible = true; 
            ECG1Chart.Series[0].Points.DataBindXY(_ecgMeassure.ECG);
        }
    }
}
