using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class ECG_Meassure
    {
        public string CPRNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public List<double> ECG { get; set; }
        public int Pulse { get; set; }
        public int HRV { get; set; }
    }
}
