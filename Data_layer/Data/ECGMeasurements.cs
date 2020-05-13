using System;
using System.Collections.Generic;

namespace Data_layer.Data
{
    public partial class ECGMeasurements
    {
        public ECGMeasurements()
        {
            ECGLeads = new HashSet<ECGLeads>();//en anden form for liste
        }

        public int ECGMeasurementId { get; set; }
        public int PatientMeasurementId { get; set; }
        public int MeasurementNumber { get; set; }
        public int Pulse { get; set; }
        public int HRV { get; set; }

        public virtual PatientMeasurements PatientMeasurement { get; set; }
        public virtual ICollection<ECGLeads> ECGLeads { get; set; }//der laves en instans af et hashset
    }
}
