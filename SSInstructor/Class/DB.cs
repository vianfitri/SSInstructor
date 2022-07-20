using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace SSInstructor.Class
{
    public class DB
    {
        #region Field
        private OleDbDataAdapter oAccessAdapter;
        private OleDbConnection oAccessConn;
        private OleDbCommand oAccessCmd;
        private OleDbDataReader oAccessReader;
        private MySqlDataAdapter oMySqlAdapter;
        private MySqlConnection oMySqlConn;
        private MySqlCommand oMySqlCmd;

        private MySqlDataReader oMySqlReader;
        private SqlDataAdapter oSqlAdapter;
        private SqlConnection oSqlConn;
        private SqlCommand oSqlCmd;

        private SqlDataReader oSqlReader;
        private string sAccessFile;
        private string sHost;
        private string sPort;
        private string sUser;
        private string sPassword;
        private string sConn;

        private string sErrorMessage;

        public enum DBase
        {
            Access,
            MySQL,
            SQLServer
        }
        private DBase eDatabaseType;
        #endregion

        #region "Properties"

        public string ErrorMessage
        {
            get { return sErrorMessage; }
        }

        public string ConnectionString
        {
            get { return sConn; }
            set { sConn = value; }
        }

        public string DbHost
        {
            get { return sHost; }
            set { sHost = value; }
        }

        public string DbPort
        {
            get { return sPort;  }
            set { sPort = value; }
        }

        public string DbUser
        {
            get { return sUser; }
            set { sUser = value; }
        }

        public string DbPassword
        {
            get { return sPassword; }
            set { sPassword = value; }
        }

        public DBase DatabaseType
        {
            get { return eDatabaseType; }
            set { eDatabaseType = value; }
        }

        #endregion

        #region "Functions"

        #region "Data Collections"

        //---------------------------------------------------------------------------------------------------------------------
        // Multiple data in array
        //---------------------------------------------------------------------------------------------------------------------
        public bool GetAllDatabases(ref string[] DatabaseNameList)
        {
            return GetColumnData("SHOW DATABASES", 0, ref DatabaseNameList);
        }

        public bool GetAllTables(string DatabaseName, ref string[] TableNameList)
        {
            return GetColumnData("SHOW TABLES FROM " + DatabaseName, 0, ref TableNameList);
        }

        public bool GetColumnData(string Query, int FieldPos, ref double[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";

            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData[idx] = oMySqlReader.GetDouble(FieldPos);
                        idx++;
                    }
                }
                
                oMySqlReader.Close();
            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        public bool GetColumnData(string Query, string FieldPos, ref double[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData[idx] = oMySqlReader.GetDouble(FieldPos);
                        idx++;
                    }
                }
                
                oMySqlReader.Close();
            
            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref int[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData[idx] = oMySqlReader.GetInt32(FieldPos);
                        idx++;
                    }
                }
                
                oMySqlReader.Close();
            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();
    
            return stat;
        }

        public bool GetColumnData(string Query, string FieldPos, ref int[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData[idx] = oMySqlReader.GetInt32(FieldPos);
                        idx++;
                    }
                }
                
                oMySqlReader.Close();
            
            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref object[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";

            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData[idx] = oMySqlReader.GetValue(FieldPos);
                        idx++;
                    }
                }
                
                oMySqlReader.Close();
            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref string[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";

            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData[idx] = oMySqlReader.GetString(FieldPos);
                        idx++;
                    }
                }
                
                oMySqlReader.Close();
            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();
    
            return stat;
        }

        public bool GetColumnData(string Query, string FieldPos, ref string[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData[idx] = oMySqlReader.GetString(FieldPos);
                        idx++;
                    }
                }
                
                oMySqlReader.Close();
            }
            
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Multiple data in List
        //---------------------------------------------------------------------------------------------------------------------
        public bool GetAllDatabases(ref List<string> DatabaseNameList)
        {
            DatabaseNameList.Clear();

            return GetColumnData("SHOW DATABASES", 0, ref DatabaseNameList);
        }

        public bool GetAllTables(string DatabaseName, ref List<string> TableNameList)
        {
            TableNameList.Clear();

            return GetColumnData("SHOW TABLES FROM " + DatabaseName, 0, ref TableNameList);
        }

        public bool GetColumnData(string Query, int FieldPos, ref List<double> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData.Add(oMySqlReader.GetDouble(FieldPos));
                    }
                }
                
                oMySqlReader.Close();
            
            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        public bool GetColumnData(string Query, string FieldPos, ref List<double> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData.Add(oMySqlReader.GetDouble(FieldPos));
                    }
                }
                
                oMySqlReader.Close();

            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref List<int> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData.Add(oMySqlReader.GetInt32(FieldPos));
                    }
                }
                
                oMySqlReader.Close();
                
            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();
 
            return stat;
        }

        public bool GetColumnData(string Query, string FieldPos, ref List<int> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData.Add(oMySqlReader.GetInt32(FieldPos));
                    }
                }
                
                oMySqlReader.Close();
                
            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref List<object> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData.Add(oMySqlReader.GetValue(FieldPos));
                    }
                }
                
                oMySqlReader.Close();
                
            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();
 
            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref List<string> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);

            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData.Add(oMySqlReader.GetString(FieldPos));
                    }
                }
                
                oMySqlReader.Close();
                
            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();
 
            return stat;
        }

        public bool GetColumnData(string Query, string FieldPos, ref List<string> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);            
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        ListColData.Add(oMySqlReader.GetString(FieldPos));
                    }
                }
                
                oMySqlReader.Close();
                
            }
            catch (Exception ex)
            {
                ListColData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Single data
        //---------------------------------------------------------------------------------------------------------------------
        public bool GetData(string Query, int FieldPos, ref double aData)
        {
            bool stat = true;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    oMySqlReader.Read();
                    aData = oMySqlReader.GetDouble(FieldPos);
                }
                
                oMySqlReader.Close();
                
            }
            catch (Exception ex)
            {
                aData = 0;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();
 
            return stat;
        }

        public bool GetData(string Query, string FieldPos, ref double aData)
        {
            bool stat = true;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    oMySqlReader.Read();
                    aData = oMySqlReader.GetDouble(FieldPos);
                }
                
                oMySqlReader.Close();
            
            }
            catch (Exception ex)
            {
                aData = 0;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        public bool GetData(string Query, int FieldPos, ref int aData)
        {
            bool stat = true;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    oMySqlReader.Read();
                    aData = oMySqlReader.GetInt32(FieldPos);
                }
                
                oMySqlReader.Close();
                
            }
            catch (Exception ex)
            {
                aData = 0;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        public bool GetData(string Query, string FieldPos, ref int aData)
        {
            bool stat = true;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    oMySqlReader.Read();
                    aData = oMySqlReader.GetInt32(FieldPos);
                }
                
                oMySqlReader.Close();
                
            }
            catch (Exception ex)
            {
                aData = 0;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        public bool GetData(string Query, int FieldPos, ref object aData)
        {
            bool stat = true;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    oMySqlReader.Read();
                    aData = oMySqlReader.GetValue(FieldPos);
                }
                
                oMySqlReader.Close();
                
            }
            catch (Exception ex)
            {
                aData = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();
 
            return stat;
        }

        public bool GetData(string Query, int FieldPos, ref string aData)
        {
            bool stat = true;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                                
                if (oMySqlReader.HasRows)
                {
                    oMySqlReader.Read();
                    aData = oMySqlReader.GetString(FieldPos);
                }
                
                oMySqlReader.Close();
                
            }
            catch (Exception ex)
            {
                aData = "";
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        public bool GetData(string Query, string FieldPos, ref string aData)
        {
            bool stat = true;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    oMySqlReader.Read();
                    aData = oMySqlReader.GetString(FieldPos);
                }
                
                oMySqlReader.Close();
                
            }
            catch (Exception ex)
            {
                aData = "";
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        //---------------------------------------------------------------------------------------------------------------------
        // DataTable / DataSet
        //---------------------------------------------------------------------------------------------------------------------
        public bool GetTableData(string Query, ref DataSet oDataSet)
        {
            bool stat = true;

            oDataSet.Clear();
            sErrorMessage = "";
            
            oMySqlAdapter = new MySqlDataAdapter();
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlCmd.ExecuteNonQuery();
                oMySqlAdapter.SelectCommand = oMySqlCmd;
                oMySqlAdapter.Fill(oDataSet);
                
            }
            catch (Exception ex)
            {
                oDataSet = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlAdapter.Dispose();
            oMySqlCmd.Dispose();
            oMySqlConn.Close();
 
            return stat;
        }

        public bool GetTableData(string Query, ref DataTable oDataTable)
        {
            bool stat = true;

            oDataTable.Clear();
            sErrorMessage = "";
            
            oMySqlAdapter = new MySqlDataAdapter();
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlCmd.ExecuteNonQuery();
                oMySqlAdapter.SelectCommand = oMySqlCmd;
                oMySqlAdapter.Fill(oDataTable);
                
            }
            catch (Exception ex)
            {
                oDataTable = null;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlAdapter.Dispose();
            oMySqlCmd.Dispose();
            oMySqlConn.Close();
 
            return stat;
        }

        //---------------------------------------------------------------------------------------------------------------------
        public bool GetTotalRow(string Query, ref int TotalRow)
        {
            bool stat = true;

            TotalRow = 0;
            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlReader = oMySqlCmd.ExecuteReader();
                
                if (oMySqlReader.HasRows)
                {
                    while (oMySqlReader.Read())
                    {
                        TotalRow += 1;
                    }
                }
                
                oMySqlReader.Close();
                
            }
            catch (Exception ex)
            {
                TotalRow = 0;
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();
 
            return stat;
        }

        //---------------------------------------------------------------------------------------------------------------------
        public bool GetDatabaseStatus()
        {
            bool stat = true;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            
            try
            {
                oMySqlConn.Open();
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlConn.Close();

            return stat;
        }

        #endregion

        #region "Insert, Update, Delete"

        public bool SetCommand(string Query)
        {
            bool stat = true;

            sErrorMessage = "";
            
            oMySqlConn = new MySqlConnection(sConn);
            oMySqlCmd = new MySqlCommand(Query, oMySqlConn);
            
            try
            {
                oMySqlConn.Open();
                oMySqlCmd.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                sErrorMessage = ex.Message;
                stat = false;
            }
            
            oMySqlCmd.Dispose();
            oMySqlConn.Close();

            return stat;
        }

        #endregion

        #region "Init"

        public DB()
        {
            sAccessFile = "";
            sHost = "";
            sPort = "";
            sUser = "";
            sPassword = "";
            sConn = "";
            sErrorMessage = "";
        }

        public DB(DBase DatabaseType, string AccessFile, string Hostname, string Port, string Username, string Password)
        {
            eDatabaseType = DatabaseType;
            sAccessFile = AccessFile;
            sHost = Hostname;
            sPort = Port;
            sUser = Username;
            sPassword = Password;
            sConn = "";
            sErrorMessage = "";

            
            if (string.IsNullOrEmpty(sPort.Trim()))
                sPort = "3306";
            sConn = "Server=" + sHost + "; Port=" + sPort + "; Uid=" + sUser + "; Pwd=" + sPassword + ";";
        }
    }
    #endregion
    #endregion
}
