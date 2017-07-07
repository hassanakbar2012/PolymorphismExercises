using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; private set; }

        public DbConnection(string connection)
        {
            ConnectionString = connection ?? throw new InvalidOperationException();
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}
