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
            bool stat = true;

            switch (eDatabaseType)
            {
                case DBase.MySQL:
                    stat = GetColumnData("SHOW DATABASES", 0, ref DatabaseNameList);
                    break;

                case DBase.SQLServer:
                    stat = GetColumnData("SELECT name FROM sys.databases WHERE dbid>4", 0, ref DatabaseNameList);
                    break;

                default:
                    DatabaseNameList = null;
                    sErrorMessage = "Function is not available for this database type !";
                    stat = false;
                    break;
            }

            return stat;
        }

        public bool GetAllTables(string DatabaseName, ref string[] TableNameList)
        {
            bool stat = true;

            switch (eDatabaseType)
            {
                case DBase.Access:
                    DataTable dt = new DataTable();
                    string[] restrictions = new string[5];

                    restrictions[3] = "Table";
                    oAccessConn = new OleDbConnection(sConn);

                    try
                    {
                        oAccessConn.Open();
                        dt = oAccessConn.GetSchema("Tables", restrictions);
                        oAccessConn.Close();

                        for (int i = 0; i <= dt.Rows.Count - 1; i++)
                        {
                            TableNameList[i] = dt.Rows[i][2].ToString();
                        }

                    }
                    catch (Exception ex)
                    {
                        TableNameList = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }
                    break;

                case DBase.MySQL:
                    stat = GetColumnData("SHOW TABLES FROM " + DatabaseName, 0, ref TableNameList);
                    break;

                case DBase.SQLServer:
                    stat = GetColumnData("SELECT * FROM " + DatabaseName + ".sys.tables WHERE name<>'sysdiagrams'", 0, ref TableNameList);
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref double[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            while (oAccessReader.Read())
                            {
                                ListColData[idx] = oAccessReader.GetDouble(FieldPos);
                                idx++;
                            }
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            while (oSqlReader.Read())
                            {
                                ListColData[idx] = oSqlReader.GetDouble(FieldPos);
                                idx++;
                            }
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, string FieldPos, ref double[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.MySQL:
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
                    break;

                default:
                    ListColData = null;
                    sErrorMessage = "Function is not available for this database type !";
                    stat = false;
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref int[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            while (oAccessReader.Read())
                            {
                                ListColData[idx] = oAccessReader.GetInt32(FieldPos);
                                idx++;
                            }
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            while (oSqlReader.Read())
                            {
                                ListColData[idx] = oSqlReader.GetInt32(FieldPos);
                                idx++;
                            }
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, string FieldPos, ref int[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.MySQL:
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
                    break;

                default:
                    ListColData = null;
                    sErrorMessage = "Function is not available for this database type !";
                    stat = false;
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref object[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            while (oAccessReader.Read())
                            {
                                ListColData[idx] = oAccessReader.GetValue(FieldPos);
                                idx++;
                            }
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            while (oSqlReader.Read())
                            {
                                ListColData[idx] = oSqlReader.GetValue(FieldPos);
                                idx++;
                            }
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref string[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            while (oAccessReader.Read())
                            {
                                ListColData[idx] = oAccessReader.GetString(FieldPos);
                                idx++;
                            }
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            while (oSqlReader.Read())
                            {
                                ListColData[idx] = oSqlReader.GetString(FieldPos);
                                idx++;
                            }
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, string FieldPos, ref string[] ListColData)
        {
            bool stat = true;
            int idx = 0;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.MySQL:
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
                    break;

                default:
                    ListColData = null;
                    sErrorMessage = "Function is not available for this database type !";
                    stat = false;
                    break;
            }

            return stat;
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Multiple data in List
        //---------------------------------------------------------------------------------------------------------------------
        public bool GetAllDatabases(ref List<string> DatabaseNameList)
        {
            bool stat = true;

            DatabaseNameList.Clear();

            switch (eDatabaseType)
            {
                case DBase.MySQL:
                    stat = GetColumnData("SHOW DATABASES", 0, ref DatabaseNameList);
                    break;

                case DBase.SQLServer:
                    stat = GetColumnData("SELECT name FROM sys.databases WHERE dbid>4", 0, ref DatabaseNameList);
                    break;

                default:
                    DatabaseNameList = null;
                    sErrorMessage = "Function is not available for this database type !";
                    stat = false;
                    break;
            }

            return stat;
        }

        public bool GetAllTables(string DatabaseName, ref List<string> TableNameList)
        {
            bool stat = true;

            TableNameList.Clear();

            switch (eDatabaseType)
            {
                case DBase.Access:
                    DataTable dt = new DataTable();
                    string[] restrictions = new string[5];

                    restrictions[3] = "Table";
                    oAccessConn = new OleDbConnection(sConn);

                    try
                    {
                        oAccessConn.Open();
                        dt = oAccessConn.GetSchema("Tables", restrictions);
                        oAccessConn.Close();

                        for (int i = 0; i <= dt.Rows.Count - 1; i++)
                            TableNameList.Add(dt.Rows[i][2].ToString());

                    }
                    catch (Exception ex)
                    {
                        TableNameList = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }
                    break;

                case DBase.MySQL:
                    stat = GetColumnData("SHOW TABLES FROM " + DatabaseName, 0, ref TableNameList);
                    break;

                case DBase.SQLServer:
                    stat = GetColumnData("SELECT * FROM " + DatabaseName + ".sys.tables WHERE name<>'sysdiagrams'", 0, ref TableNameList);
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref List<double> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            while (oAccessReader.Read())
                            {
                                ListColData.Add(oAccessReader.GetDouble(FieldPos));
                            }
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            while (oSqlReader.Read())
                            {
                                ListColData.Add(oSqlReader.GetDouble(FieldPos));
                            }
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, string FieldPos, ref List<double> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.MySQL:
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
                    break;

                default:
                    ListColData = null;
                    sErrorMessage = "Function is not available for this database type !";
                    stat = false;
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref List<int> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            while (oAccessReader.Read())
                            {
                                ListColData.Add(oAccessReader.GetInt32(FieldPos));
                            }
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            while (oSqlReader.Read())
                            {
                                ListColData.Add(oSqlReader.GetInt32(FieldPos));
                            }
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, string FieldPos, ref List<int> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.MySQL:
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
                    break;

                default:
                    ListColData = null;
                    sErrorMessage = "Function is not available for this database type !";
                    stat = false;
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref List<object> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            while (oAccessReader.Read())
                            {
                                ListColData.Add(oAccessReader.GetValue(FieldPos));
                            }
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            while (oSqlReader.Read())
                            {
                                ListColData.Add(oSqlReader.GetValue(FieldPos));
                            }
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, int FieldPos, ref List<string> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            while (oAccessReader.Read())
                            {
                                ListColData.Add(oAccessReader.GetString(FieldPos));
                            }
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            while (oSqlReader.Read())
                            {
                                ListColData.Add(oSqlReader.GetString(FieldPos));
                            }
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        ListColData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetColumnData(string Query, string FieldPos, ref List<string> ListColData)
        {
            bool stat = true;

            ListColData.Clear();
            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.MySQL:
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
                    break;

                default:
                    ListColData = null;
                    sErrorMessage = "Function is not available for this database type !";
                    stat = false;
                    break;
            }

            return stat;
        }

        //---------------------------------------------------------------------------------------------------------------------
        // Single data
        //---------------------------------------------------------------------------------------------------------------------
        public bool GetData(string Query, int FieldPos, ref double aData)
        {
            bool stat = true;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            oAccessReader.Read();
                            aData = oAccessReader.GetDouble(FieldPos);
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        aData = 0;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            aData = oSqlReader.GetDouble(FieldPos);
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        aData = 0;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetData(string Query, string FieldPos, ref double aData)
        {
            bool stat = true;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.MySQL:
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
                    break;

                default:
                    aData = 0;
                    sErrorMessage = "Function is not available for this database type !";
                    stat = false;
                    break;
            }

            return stat;
        }

        public bool GetData(string Query, int FieldPos, ref int aData)
        {
            bool stat = true;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            oAccessReader.Read();
                            aData = (int)(oAccessReader[0]);    //aData = oAccessReader.GetInt32(FieldPos)
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        aData = 0;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            aData = oSqlReader.GetInt32(FieldPos);
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        aData = 0;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetData(string Query, string FieldPos, ref int aData)
        {
            bool stat = true;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.MySQL:
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
                    break;

                default:
                    aData = 0;
                    sErrorMessage = "Function is not available for this database type !";
                    stat = false;
                    break;
            }

            return stat;
        }

        public bool GetData(string Query, int FieldPos, ref object aData)
        {
            bool stat = true;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            oAccessReader.Read();
                            aData = oAccessReader.GetValue(FieldPos);
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        aData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            aData = oSqlReader.GetValue(FieldPos);
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        aData = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetData(string Query, int FieldPos, ref string aData)
        {
            bool stat = true;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            oAccessReader.Read();
                            aData = oAccessReader.GetString(FieldPos);
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        aData = "";
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            aData = oSqlReader.GetString(FieldPos);
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        aData = "";
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetData(string Query, string FieldPos, ref string aData)
        {
            bool stat = true;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.MySQL:
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
                    break;

                default:
                    aData = "";
                    sErrorMessage = "Function is not available for this database type !";
                    stat = false;
                    break;
            }

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

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessAdapter = new OleDbDataAdapter();
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessCmd.ExecuteNonQuery();
                        oAccessAdapter.SelectCommand = oAccessCmd;
                        oAccessAdapter.Fill(oDataSet);

                    }
                    catch (Exception ex)
                    {
                        oDataSet = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessAdapter.Dispose();
                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlAdapter = new SqlDataAdapter();
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlCmd.ExecuteNonQuery();
                        oSqlAdapter.SelectCommand = oSqlCmd;
                        oSqlAdapter.Fill(oDataSet);

                    }
                    catch (Exception ex)
                    {
                        oDataSet = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlAdapter.Dispose();
                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        public bool GetTableData(string Query, ref DataTable oDataTable)
        {
            bool stat = true;

            oDataTable.Clear();
            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessAdapter = new OleDbDataAdapter();
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessCmd.ExecuteNonQuery();
                        oAccessAdapter.SelectCommand = oAccessCmd;
                        oAccessAdapter.Fill(oDataTable);

                    }
                    catch (Exception ex)
                    {
                        oDataTable = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessAdapter.Dispose();
                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlAdapter = new SqlDataAdapter();
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlCmd.ExecuteNonQuery();
                        oSqlAdapter.SelectCommand = oSqlCmd;
                        oSqlAdapter.Fill(oDataTable);

                    }
                    catch (Exception ex)
                    {
                        oDataTable = null;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlAdapter.Dispose();
                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        //---------------------------------------------------------------------------------------------------------------------
        public bool GetTotalRow(string Query, ref int TotalRow)
        {
            bool stat = true;

            TotalRow = 0;
            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessReader = oAccessCmd.ExecuteReader();

                        if (oAccessReader.HasRows)
                        {
                            while (oAccessReader.Read())
                            {
                                TotalRow += 1;
                            }
                        }

                        oAccessReader.Close();

                    }
                    catch (Exception ex)
                    {
                        TotalRow = 0;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlReader = oSqlCmd.ExecuteReader();

                        if (oSqlReader.HasRows)
                        {
                            while (oSqlReader.Read())
                            {
                                TotalRow += 1;
                            }
                        }

                        oSqlReader.Close();

                    }
                    catch (Exception ex)
                    {
                        TotalRow = 0;
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        //---------------------------------------------------------------------------------------------------------------------
        public bool GetDatabaseStatus()
        {
            bool stat = true;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);

                    try
                    {
                        oAccessConn.Open();
                    }
                    catch (Exception ex)
                    {
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);

                    try
                    {
                        oSqlConn.Open();
                    }
                    catch (Exception ex)
                    {
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlConn.Close();
                    break;
            }

            return stat;
        }

        #endregion

        #region "Insert, Update, Delete"

        public bool SetCommand(string Query)
        {
            bool stat = true;

            sErrorMessage = "";

            switch (eDatabaseType)
            {
                case DBase.Access:
                    oAccessConn = new OleDbConnection(sConn);
                    oAccessCmd = new OleDbCommand(Query, oAccessConn);

                    try
                    {
                        oAccessConn.Open();
                        oAccessCmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oAccessCmd.Dispose();
                    oAccessConn.Close();
                    break;

                case DBase.MySQL:
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
                    break;

                case DBase.SQLServer:
                    oSqlConn = new SqlConnection(sConn);
                    oSqlCmd = new SqlCommand(Query, oSqlConn);

                    try
                    {
                        oSqlConn.Open();
                        oSqlCmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        sErrorMessage = ex.Message;
                        stat = false;
                    }

                    oSqlCmd.Dispose();
                    oSqlConn.Close();
                    break;
            }

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

            switch (eDatabaseType)
            {
                case DBase.Access:
                    string access_ext = Path.GetExtension(sAccessFile);

                    if (access_ext.Contains("mdb"))
                        sConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + sAccessFile + ";Password=" + sPassword + ";";
                    else if (access_ext.Contains("accdb"))
                        sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + sAccessFile + ";Jet OLEDB:Database Password=" + sPassword + ";";
                    break;

                case DBase.MySQL:
                    if (string.IsNullOrEmpty(sPort.Trim()))
                        sPort = "3306";
                    sConn = "Server=" + sHost + "; Port=" + sPort + "; Uid=" + sUser + "; Pwd=" + sPassword + ";";
                    break;

                case DBase.SQLServer:
                    sConn = "server=" + sHost + "; user id=" + sUser + "; password=" + sPassword + "; Trusted_Connection=yes; connection timeout=30;";
                    break;
            }
        }
    }
    #endregion
    #endregion
}
