using System;

namespace PolymorphismExercise
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connection)
            : base(connection)
        {

        }
        public override void CloseConnection()
        {
            Console.WriteLine("SQL connection to the database has been closed!");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL connection to the database has been opened!");
        }
    }
}
