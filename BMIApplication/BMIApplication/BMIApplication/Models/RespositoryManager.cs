
namespace BMIApplication.Models
{
    using Microsoft.Data.Sqlite;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IDataTable
    {
        IDataTable Create(string tableName);
        IDataTable CreateField(string name, string criteria);
        IDataTable AlterField(string name, string criteria);
        IDataTable RenameField(string name, string criteria);
    }


    public class SqliteTable : IDataTable
    {
        public IDataTable AlterField(string name, string criteria)
        {
            throw new NotImplementedException();
        }

        public IDataTable Create(string tableName)
        {
            //check if the table already exists or not.

            return this;
        }

        public IDataTable CreateField(string name, string criteria)
        {
            throw new NotImplementedException();
        }

        public IDataTable RenameField(string name, string criteria)
        {
            throw new NotImplementedException();
        }
    }
    public class RespositoryManager : IRespositoryManager , IDisposable
    {
        private SqliteConnection connector;

        protected RespositoryManager(string databaseName)
        {
            connector = new SqliteConnection(String.Format("Filename={0}", databaseName));
            connector.Open();

            string UserTable = "CREATE TABLE IF NOT EXIST user_tbl (col_userid Varchar(40)  PRIMARY KEY";
            SqliteCommand createUserTable = new SqliteCommand(UserTable, connector);
            createUserTable.ExecuteReader();
            //Create All the tables.
        }

        public UserCredential   UserCredential => throw new NotImplementedException();

        public IUserRespository UserRespository => throw new NotImplementedException();

        /// <summary>
        ///  Implementing this interface , you can now destroy most of the object created.
        /// </summary>
        public void Dispose()
        {
           if(connector != null)
            {
                connector.Close();
            }
        }
    }
}
