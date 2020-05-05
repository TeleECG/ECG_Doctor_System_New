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
        public byte[] ECGLeadValues1_1 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues1_2 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues1_3 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues2_1 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues2_2 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues2_3 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues3_1 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues3_2 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
        public byte[] ECGLeadValues3_3 { get; set; } //Byte-array hvor ECG-værdier skal lægges i
    }
}
