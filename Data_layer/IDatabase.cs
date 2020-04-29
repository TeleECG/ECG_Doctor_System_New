using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    public interface IDatabase
    {
        string CPRNumber { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        DateTime Date { get; set; }
        List<double> ECG { get; set; }
        int Pulse { get; set; }
        int HRV { get; set; }
        void Get_ECG();
    }

}
