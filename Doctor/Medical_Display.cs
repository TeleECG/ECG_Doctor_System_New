using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor
{
    public partial class Medical_Display : Form
    {
        private string _CPR = "";
        

        public Medical_Display()
        {
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
            ECG1Chart.Visible = true;
            ECG2Chart.Visible = true;
            ECG3Chart.Visible = true; 
            //ECG1Chart.Series[0].Points.DataBindXY();
        }
    }
}
