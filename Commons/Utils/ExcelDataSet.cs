//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.OleDb;
//using System.IO;
//using System.Web;

//namespace Commons.Utils
//{
//    public class ExcelDataSet
//    {
//        public DataSet dataSet(string excelConnectionString, string sheetName)
//        {
//            DataSet ds = new DataSet();
//            bool found = false;
//            OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
//            excelConnection.Open();
//            DataTable dt = new DataTable();

//            dt = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
//            if (dt == null)
//            {
//                return null;
//            }
//            excelConnection.Close();
//            String[] excelSheets = new String[dt.Rows.Count];
//            int t = 0;

           

//            //excel data saves in temp file here.
//            foreach (DataRow row in dt.Rows)
//            {
//                excelSheets[t] = row["TABLE_NAME"].ToString().ToLower();
//                if(excelSheets[t] == (sheetName).ToLower())
//                {
//                    found = true;
//                    break;
//                }
//                t++;
//            }
//            if(found == false)
//            {
//                t = 10000;
//            }
//            try
//            {
//                OleDbConnection excelConnection1 = new OleDbConnection(excelConnectionString);
//                string query = string.Format("Select * from [{0}] ", excelSheets[t]);
//                OleDbDataAdapter dataAdapter;
//                using (dataAdapter = new OleDbDataAdapter(query, excelConnection1))
//                {
//                    dataAdapter.Fill(ds);
//                }
//                return ds;
//            }
//            catch(Exception e)
//            {
//                throw e;
//            }

//        }

//        public List<DataSet> dataSetForOvt(string excelConnectionString, string sheetName)
//        {
//            DataSet ds = new DataSet();
//            DataSet ds1 = new DataSet();
//            DataSet ds2 = new DataSet();
//            bool found = false;
//            OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
//            excelConnection.Open();
//            DataTable dt = new DataTable();

//            dt = excelConnection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
//            if (dt == null)
//            {
//                return null;
//            }
//            excelConnection.Close();
//            String[] excelSheets = new String[dt.Rows.Count];
//            int t = 0;



//            //excel data saves in temp file here.
//            foreach (DataRow row in dt.Rows)
//            {
//                excelSheets[t] = row["TABLE_NAME"].ToString().ToLower();
//                if (excelSheets[t] == (sheetName).ToLower())
//                {
//                    found = true;
//                    break;
//                }
//                t++;
//            }
//            if (found == false)
//            {
//                t = 10000;
//            }
//            try
//            {
//                OleDbConnection excelConnection1 = new OleDbConnection(excelConnectionString);
//                string query1 = string.Format("Select * from[Spend Trend$A:IU] ", excelSheets[t]);
//                OleDbDataAdapter dataAdapter;
//                using (dataAdapter = new OleDbDataAdapter(query1, excelConnection1))
//                {
//                    dataAdapter.Fill(ds);
//                }

//                string query2 = string.Format("Select * from[Spend Trend$IV:MR] ", excelSheets[t]);
              
//                using (dataAdapter = new OleDbDataAdapter(query2, excelConnection1))
//                {
//                    dataAdapter.Fill(ds1);
//                }

//                //string query3= string.Format("Select * from[Spend Trend$MT:NY] ", excelSheets[t]);

//                //using (dataAdapter = new OleDbDataAdapter(query3, excelConnection1))
//                //{
//                //    dataAdapter.Fill(ds2);
//                //}

//                List<DataSet> datasetList = new List<DataSet>();
//                datasetList.Add(ds);
//                datasetList.Add(ds1);
//             //   datasetList.Add(ds2);


//                return datasetList;
//            }
//            catch (Exception e)
//            {
//                throw e;
//            }

//        }

//    }
//}
