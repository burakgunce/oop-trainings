namespace KurumsalMimari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBOperationsManager _dbOpSQL = new DBOperationsManager(new MSSQLOperations());
            _dbOpSQL.Insert();
            _dbOpSQL.Update();
            _dbOpSQL.Delete();
            _dbOpSQL.Read();


            DBOperationsManager _dbOpOracle = new DBOperationsManager(new OracleOperation());
            _dbOpOracle.Insert();
            _dbOpOracle.Update();
            _dbOpOracle.Delete();
            _dbOpOracle.Read();
        }
    }
}