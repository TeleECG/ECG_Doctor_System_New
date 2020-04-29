using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_layer;
using Doctor;

namespace MainApp
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public Program()
        {
            //Datalayer 
            IDatabase _telemedicineDatabase = new Telemedicine_database();

            //Logiclayer 
            Get_ECG_Controller _getEcgController = new Get_ECG_Controller(_telemedicineDatabase);

            //Presentationlayer 
            IForm _GUI = new Doctor.Program(_getEcgController);
            _GUI.Start();

        }
    }
}
