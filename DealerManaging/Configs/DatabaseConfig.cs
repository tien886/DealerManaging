using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace DealerManaging.Configs;

public class DatabaseConfig
{
    private readonly SQLiteAsyncConnection _database;
    public DatabaseConfig(string db_path)
    {
        //_database = new SQLiteAsyncConnection(db_path);
        //_database.CreateTableAsync<>
    }

}

