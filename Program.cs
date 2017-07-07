using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("SqlConnection String");
            OracleConnection oracleConnection = new OracleConnection("OracleConnection String");
            var dbCommand = new DbCommad(oracleConnection, "get all employees");
            dbCommand.Execute();
            

        }
    }
}
