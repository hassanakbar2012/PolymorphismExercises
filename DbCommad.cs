using System;

namespace PolymorphismExercise
{
    public class DbCommad
    {
        private DbConnection _dbConnection;
        public string Instruction { get; set; }
        public DbCommad(DbConnection dbConnection, string instruction)
        {
            _dbConnection = dbConnection ?? throw new InvalidOperationException();

            if (String.IsNullOrWhiteSpace(instruction))
                throw new InvalidOperationException();
            Instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Running the instruction.");
            _dbConnection.CloseConnection();
        }
    }
}
