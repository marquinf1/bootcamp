using Dapper;
using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;


namespace Tarefas.DAO 
{
    public class TarefaDAO 
    {
        public string DataSourceFile => Environment.CurrentDirectory + "TarefasDB.sqlite";
        public SQLiteConnection Connection => new SQLiteConnection("Datasource" + DataSourceFile);

        public TarefaDAO()
        {
            if (!File.Exists(DataSourceFile)) 
            {
                CreateDatabase();
            }
        }

        public void CreateDatabase() 
        {
            using (var con = Connection)
            {
                con.Open();
                con.Execute(
                    @"CREATE TABLE Tarefas 
                    (
                        Id          INTEGER PRIMARY KEY AUTOINCREMENT,
                        Titulo      VARCHAR(100) NOT NULL,
                        Descricao   VARCHAR(100) NOT NULL,
                    )"
                );
            }
        }
    }

}