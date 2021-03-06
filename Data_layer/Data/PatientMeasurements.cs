﻿using System;
using System.Collections.Generic;

namespace Data_layer.Data
{
    public partial class PatientMeasurements
    {
        public PatientMeasurements()
        {
            ECGMeasurements = new HashSet<ECGMeasurements>();
        }

        public int PatientMeasurementId { get; set; }
        public string CPRNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }

        public virtual ICollection<ECGMeasurements> ECGMeasurements { get; set; }
    }
}
