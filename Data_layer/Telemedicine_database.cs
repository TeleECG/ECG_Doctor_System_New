using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Doctor;
using Domain;

namespace Data_layer
{
    public class Telemedicine_database : IDatabase
    {
        private SqlConnection _connection;
        private const String _database = "F20ST4PRJ4TeleMedDatabase";

        public Telemedicine_database()
        {
            _connection = new SqlConnection("Data Source=st-i4dab.uni.au.dk; Initial Catalog=" + _database + "; " +
                                            "Persist Security Info=True; User ID=" + _database + "; Password=" + _database + "");
        }
        public void Get_ECG(ECG_Meassure ecgMeassure)
        {
            try
            {
                _connection.Open();

                SqlDataReader _reader;

                byte[] bytesArray;
                List<double> _data = new List<double>();

                using (SqlCommand command = new SqlCommand("Select CPR, Name, Address, Date, ECGMeasure, Pulse, HRV from EKGDATA WHERE CPR = CPRNumber from EKGDATA)", _connection)) //Mangler de rigtige navne, og hvordan der skal vælges det korrekte
                {
                    _reader = command.ExecuteReader();

                    while (_reader.Read())
                    {
                        bytesArray = (byte[])_reader["ECGMeasure"];

                        for (int i = 0; i < bytesArray.Length; i += 8)
                        {
                            _data.Add(BitConverter.ToDouble(bytesArray, i));
                        }

                        ecgMeassure.CPRNumber = "CPR";
                        ecgMeassure.Name = "Name";
                        ecgMeassure.Address = "Address";
                        ecgMeassure.Date = Convert.ToDateTime("Date");
                        ecgMeassure.ECG = _data; //Skal det være en list af list???
                        ecgMeassure.Pulse = Convert.ToInt32("Pulse");
                        ecgMeassure.HRV = Convert.ToInt32("HRV");
                    }
                }

            }

            catch (SqlException e)
            {
                Console.WriteLine(e);
                throw;
            }

            finally { _connection.Close(); }
        }
    }
}
