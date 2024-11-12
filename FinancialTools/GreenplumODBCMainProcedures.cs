using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Threading.Tasks;

using FinancialTools;
using System.Globalization;
using Npgsql;

namespace FinancialTools
{
    partial class GreenplumODBC
    {

        /************************************************************************************************************************************/
        /************************************************************************************************************************************/
        /*********************************************************** Main *********************************************************/
        /************************************************************************************************************************************/
        /************************************************************************************************************************************/
        public static string sqlMainCheckAndCreate()
        {

            string connectionString = GetMainConnectionString();
            string errorMessages = default;
            using (var awConnection = new NpgsqlConnection(connectionString))
            {

                try
                {
                    awConnection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(sqlOMIGTableCreate, awConnection);
                    command.CommandTimeout = 86400;
                    command.ExecuteNonQuery();
                    awConnection.Close();
                }

                catch (NpgsqlException e)
                {

                    errorMessages = e.ToString();
                }
                return errorMessages;}
                errorMessages = e.ToString();

                    //System.Diagnostics.EventLog log = new System.Diagnostics.EventLog();
                    //log.Source = "My Application";
                    //log.WriteEntry(errorMessages);
                }
                return errorMessages;
            }
        }errorMessages = e.ToString();

                }
                return errorMessages;

            }
        }

        public static List<ExcelCell> sqlOMIGGetList(string CIN)
        {
            string connectionString = GetMainConnectionString();
            string errorMessages = default;
            List<ExcelCell> cellList = new List<ExcelCell>();
            using (var awConnection = new NpgsqlConnection(connectionString))
            {

                try
                {
                    awConnection.Open();
                    NpgsqlCommand command = new NpgsqlCommand(String.Format(sqlOMIGTableCreate, CIN), awConnection);
                    command.CommandTimeout = 86400;
                    command.CommandTimeout = 86400;
                    command.ExecuteNonQueryAsync();
                    NpgsqlDataReader thisReader = (NpgsqlDataReader) command.ExecuteReader();
                    while (thisReader.Read())
                    {
                        ExcelCell cell = new ExcelCell(thisReader.GetValue(1).ToString(), thisReader.GetValue(2).ToString(), thisReader.GetValue(3).ToString(), thisReader.GetValue(4).ToString(), thisReader.GetValue(5).ToString());
                        cellList.Add(cell);

                    }
                    awConnection.Close();
                }

                catch (NpgsqlException e)
                {

                    errorMessages = e.ToString();

                }
                return cellList;
                

            }
        }public static string GetMainConnectionString()
{
    // You will need to modify this connection string to match your SQL Server Configuration
    return "Server=example_server;Database=example_db;port=5432;User Id=example_user;Password=example_password";
}