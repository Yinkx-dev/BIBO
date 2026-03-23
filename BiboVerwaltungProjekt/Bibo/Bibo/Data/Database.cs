using System.Data.SQLite;
using Dapper;
using System.Collections.Generic;
using System.Linq;

public class Database
{
    private readonly string _connectionString;

    public Database(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Einzelne Objekte aus db holen
    public T QuerySingle<T>(string sql, object param = null)
    {
        using (var conn = new SQLiteConnection(_connectionString))
        {
            conn.Open();
            return conn.Query<T>(sql, param).FirstOrDefault();
        }
    }

    // Listen aus db holen
    public List<T> QueryList<T>(string sql, object param = null)
    {
        using (var conn = new SQLiteConnection(_connectionString))
        {
            conn.Open();
            return conn.Query<T>(sql, param).ToList();
        }
    }

    // Execute-Statements (INSERT, UPDATE, DELETE)
    public int Execute(string sql, object param = null)
    {
        using (var conn = new SQLiteConnection(_connectionString))
        {
            conn.Open();
            return conn.Execute(sql, param);
        }
    }
}