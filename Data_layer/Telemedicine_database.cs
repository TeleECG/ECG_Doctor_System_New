using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Doctor;

namespace Data_layer
{
    public class Telemedicine_database : IDatabase
    {
        private SqlConnection _connection;
        private const String _database = "NameHere";
        public string CPRNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public List<double> ECG { get; set; }
        public int Pulse { get; set; }
        public int HRV { get; set; }

        public Telemedicine_database()
        {
            _connection = new SqlConnection("Data Source=st-i4dab.uni.au.dk; Initial Catalog=" + _database + "; " +
                                            "Persist Security Info=True; User ID=" + _database + "; Password=" + _database + "");
        }
        public void Get_ECG()
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

                        CPRNumber = "CPR";
                        Name = "Name";
                        Address = "Address";
                        Date = Convert.ToDateTime("Date");
                        ECG = _data; //Skal det være en list af list???
                        Pulse = Convert.ToInt32("Pulse");
                        HRV = Convert.ToInt32("HRV");
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
