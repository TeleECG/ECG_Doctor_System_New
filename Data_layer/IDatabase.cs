﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor
{
    public interface IDatabase
    {
        void Get_ECG(string CPRNumber, string Name, string Address, DateTime Date, List<double> ECG, int Pulse,
            int HRV);
    }

}
