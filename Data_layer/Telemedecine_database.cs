using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Doctor
{
    public class Telemedecine_database : IDatabase
    {
        private SqlConnection _connection;
        private const String _database = "NameHere";

        public Telemedecine_database()
        {
            _connection = new SqlConnection("Data Source=st-i4dab.uni.au.dk; Initial Catalog=" + _database + "; " +
                                            "Persist Security Info=True; User ID=" + _database + "; Password=" + _database + "");
        }
        public void Get_ECG(string CPRNumber, string Name, string Address, DateTime Date, List<double> ECG, int Pulse, int HRV)
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
