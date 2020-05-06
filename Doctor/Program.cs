using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Doctor
{
    public class Program : IForm
    {
        

        public Program()
        {
         
        }

        [STAThread]
        public override void Start()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Medical_Display());
        }
    }
}
