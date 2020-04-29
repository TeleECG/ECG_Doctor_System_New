using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    public class Get_ECG_Controller
    {
        public IDatabase _telemedicine_Database;
        public string CPRNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public List<double> ECG { get; set; }
        public int Pulse { get; set; }
        public int HRV { get; set; }

        public Get_ECG_Controller(IDatabase telemedicine_Database)
        {
            _telemedicine_Database = telemedicine_Database;
        }
        public void Get_ECG_Measurement()
        {
            _telemedicine_Database.Get_ECG();

            CPRNumber = _telemedicine_Database.CPRNumber;
            Name = _telemedicine_Database.Name;
            Address = _telemedicine_Database.Address;
            Date = _telemedicine_Database.Date;
            ECG = _telemedicine_Database.ECG;
            Pulse = _telemedicine_Database.Pulse;
            HRV = _telemedicine_Database.HRV;
        }


    }
}
