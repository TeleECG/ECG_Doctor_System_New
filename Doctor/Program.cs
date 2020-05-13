using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data_layer;
using Data_layer.Data;


namespace Doctor
{
    public class Program : IForm
    {
        private TeleMedUtilities _teleMedDb;
        

        public Program(TeleMedUtilities teleMedDb)
        {
            _teleMedDb = teleMedDb;
            
        }

        [STAThread]
        public override void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Medical_Display(_teleMedDb));
        }
    }
}
