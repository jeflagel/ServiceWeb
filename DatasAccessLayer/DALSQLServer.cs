using DataAccessLayer;
using EntitiesLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatasAccessLayer
{
    class DALSQLServer : IDAL
    {
        String _connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\jeremy\Desktop\Cours\TP_C#\ThronesTournamentConsole\ThronesTournamentConsole\DATA\database.mdf;Integrated Security=True;Connect Timeout=30";
        public IList<Character> GetAllCharactere()
        {
            IList<Character> result = new List<Character>();
            String request = "Select * from Character";
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlcommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlreader = sqlcommand.ExecuteReader();
                while (sqlreader.Read())
                {
                    result.Add(String.Format("{0} ({1})",
                        sqlreader.GetString(1),
                        sqlreader.GetGuid(0).ToString()));
                }
                sqlConnection.Close();
            }
            return result;
        }

        public IList<Character> GetCharactere(int id)
        {
            IList<Character> result = new List<Character>();
            String request = "Select * from Character where id="+id;
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlcommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlreader = sqlcommand.ExecuteReader();
                while (sqlreader.Read())
                {
                    result.Add(String.Format("{0} ({1})",
                        sqlreader.GetString(1),
                        sqlreader.GetGuid(0).ToString()));
                }
                sqlConnection.Close();
            }
            return result;
        }

        public IList<House> GetHouses()
        {
            IList<House> result = new List<House>();
            String request = "Select * from House";
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlcommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlreader = sqlcommand.ExecuteReader();
                while (sqlreader.Read())
                {
                    result.Add(String.Format("{0} ({1})",
                        sqlreader.GetString(1),
                        sqlreader.GetGuid(0).ToString()));
                }
                sqlConnection.Close();
            }
            return result;
        }

        public IList<Territory> GetTerritory()
        {
            IList<Territory> result = new List<Territory>();
            String request = "Select * from House";
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                SqlCommand sqlcommand = new SqlCommand(request, sqlConnection);
                sqlConnection.Open();

                SqlDataReader sqlreader = sqlcommand.ExecuteReader();
                while (sqlreader.Read())
                {
                    result.Add(String.Format("{0} ({1})",
                        sqlreader.GetString(1),
                        sqlreader.GetGuid(0).ToString()));
                }
                sqlConnection.Close();
            }
            return result;
        }
    }
}
