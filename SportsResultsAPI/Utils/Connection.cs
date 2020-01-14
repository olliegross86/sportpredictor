using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace SportsResultsAPI.Utils
{
    public class Connection
    {
        public string Value1 { get; set; }

        public string RugbyString()
        {
            string connectionString = @"Data Source=olliegross.database.windows.net; Initial Catalog=SportsResults; User id=ollie.gross@uwe.ac.uk@olliegross; Password=Merlin&Bryn86;";

            using (var connection = new SqlConnection(connectionString))

            using (var command = connection.CreateCommand())

            {
                connection.Open();

                //command.CommandType = CommandType.StoredProcedure;

                command.CommandText = "SELECT TOP (1000) [SportTypeId],[SportType] FROM[dbo].[SportType]";

                //command.Parameters.AddWithValue("intFrIndex", 0);

                using (var reader = command.ExecuteReader())

                {

                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Value1 = reader.GetValue(1).ToString();
                                
                            }

                        }
                    }


                }
                
            }
            
            return Value1;
        }
    }
}
