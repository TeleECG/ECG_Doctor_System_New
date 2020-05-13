using System;
using System.Collections.Generic;

namespace Data_layer.Data
{
    public partial class ECGLeads
    {
        public int ECGLeadId { get; set; }
        public int ECGMeasurementId { get; set; }
        public int LeadNumber { get; set; }
        public byte[] ECGLeadValues { get; set; }

        public virtual ECGMeasurements ECGMeasurement { get; set; }
    }
}
