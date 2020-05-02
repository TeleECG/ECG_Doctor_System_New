using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor
{
    public class Program : IForm
    {
        private Get_ECG_Controller _getEcgController;

        public Program(Get_ECG_Controller getEcgController)
        {
            _getEcgController = getEcgController;
        }

        [STAThread]
        public override void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Medical_Display(_getEcgController));
        }
    }
}
