using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkTools.Utils {
    internal class DbHelper {
        private readonly string connectionString;

        public DbHelper(string connectionString) {
            this.connectionString = connectionString;
        }

        public int ExecuteNonQuery(string sql, CommandType commandType = CommandType.Text, params SqlParameter[] parameters) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteNonQuery();
            }
        }

        public object ExecuteScalar(string sql, CommandType commandType = CommandType.Text, params SqlParameter[] parameters) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = sql;
                cmd.CommandType = commandType;
                cmd.Parameters.AddRange(parameters);
                return cmd.ExecuteScalar();
            }
        }

        public SqlDataReader ExecuteReader(string sql, CommandType commandType = CommandType.Text, params SqlParameter[] parameters) {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = commandType;
            cmd.Parameters.AddRange(parameters);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        public DataTable ExecuteDataTable(string sql, CommandType commandType = CommandType.Text, params SqlParameter[] parameters) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.CommandType = commandType;
                adapter.SelectCommand.Parameters.AddRange(parameters);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
        }

        public DataSet ExecuteDataSet(string sql, CommandType commandType = CommandType.Text, params SqlParameter[] parameters) {
            using (SqlConnection conn = new SqlConnection(connectionString)) {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.SelectCommand.CommandType = commandType;
                adapter.SelectCommand.Parameters.AddRange(parameters);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
            }
        }
    }
}
