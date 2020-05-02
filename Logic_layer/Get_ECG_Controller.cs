using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Doctor
{
    public class Get_ECG_Controller
    {
        private IDatabase _telemedicine_Database;
        private ECG_Meassure _ecgMeassure;
        
        public Get_ECG_Controller(IDatabase telemedicine_Database, ECG_Meassure ecgMeassure)
        {
            _telemedicine_Database = telemedicine_Database;
            _ecgMeassure = ecgMeassure;
        }

        public void Get_ECG_Measurement()
        {
            _telemedicine_Database.Get_ECG(_ecgMeassure);
        }


    }
}
