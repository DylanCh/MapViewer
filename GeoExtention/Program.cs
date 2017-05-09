using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder statement = new StringBuilder();
            double startLat, startLon, endLat, endLon;

            // for command line testing
            if (args.Length == 0)
            {
                Console.WriteLine("Enter the start point latitude and longitude separated by a new line");
                string next = Console.ReadLine();
                double.TryParse(next, out startLat);
                next = Console.ReadLine();
                double.TryParse(next, out startLon);
                Console.WriteLine("Enter the end point latitude and longitude separated by new line");
                next = Console.ReadLine();
                double.TryParse(next, out endLat);
                next = Console.ReadLine();
                double.TryParse(next, out endLon);
            }

            else // get input from Windows Form/WPF
            {
                double.TryParse(args[0], out startLat);
                double.TryParse(args[1], out startLon);
                double.TryParse(args[2], out endLat);
                double.TryParse(args[3], out endLon);
            }

            Console.WriteLine("Start point: ({0},{1})",startLat,startLon);
            Console.WriteLine("End point: ({0},{1})", endLat, endLon);

            statement.Append("DECLARE @startPoint geography = 'POINT(" + startLat + " " + startLon + ")'; ");
            statement.Append("DECLARE @endPoint geography = 'POINT(" + endLat + " " + endLon + ")'; ");
            statement.Append("SELECT @startPoint.STDistance(@endPoint);");

            String result = "";

            string conString =  GeoExtension.Properties.Settings.Default.ConnectionString;
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(statement.ToString(), connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    result = reader.GetValue(i).ToString();
                                }
                            }
                        }
                    }
            }
        }
        catch (Exception e){
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(result);
            Console.Read();
        }
    }
}
