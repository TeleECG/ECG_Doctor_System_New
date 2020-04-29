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
        private string _CPRNumber = "";

        private Get_ECG_Controller _ecgController;

        public Medical_Display(Get_ECG_Controller ecgController)
        {
            _ecgController = ecgController;
            InitializeComponent();
        }

        private void SearchB_Click(object sender, EventArgs e)
        {

        }

        private void DateB_Click(object sender, EventArgs e)
        {

        }
    }
}
