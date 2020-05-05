using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Doctor
{
    public class Program : IForm
    {
        private Get_ECG_Controller _getEcgController;
        private ECG_Meassure _ecgMeassure;

        public Program(Get_ECG_Controller getEcgController, ECG_Meassure ecgMeassure)
        {
            _getEcgController = getEcgController;
            _ecgMeassure = ecgMeassure;
        }

        [STAThread]
        public override void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Medical_Display(_getEcgController,_ecgMeassure));
        }
    }
}
