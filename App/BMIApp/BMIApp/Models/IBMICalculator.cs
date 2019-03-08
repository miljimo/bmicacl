﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIApp.Models
{
    struct UserCredential
    {
        private string uid;
        private string lastname;
        private string surname;
    }
     

  
    public interface  IBMICalculator
    {
        double Calculate(double mass, double height);
    }

    public class   BaseCommandQuery
    {
        private
            SQLiteConnection _conn;
      
        BaseCommandQuery(ref SQLiteConnection conn)
        {
            _conn = conn;
        }
        SQLiteDataReader Query(string sqlString)
        {
            SQLiteCommand command = new SQLiteCommand(sqlString, Connection);
            return  command.ExecuteReader();
        }

        int QueryUpdate(string sqlString)
        {
            SQLiteCommand command = new SQLiteCommand(sqlString, Connection);
            return command.ExecuteNonQuery();
        }

        public SQLiteConnection Connection
        {
            get
            {
                return _conn;
            }
        }
    }


}
