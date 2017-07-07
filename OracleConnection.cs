using System;

namespace PolymorphismExercise
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connection)
            : base(connection)
        {

        }
        public override void CloseConnection()
        {
            Console.WriteLine("Oracle connection to the database has been closed!");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle connection to the database has been opened!");
        }
    }
}
