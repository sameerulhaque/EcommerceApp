using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commons.Utils
{
    public static class StaticDataSet
    {
        public static DataTable ToDataSetForAccrual_OLD_OLD<T>(this IList<T> list, string sheetname)
        {
            Type elementType = typeof(T);
            DataTable t = new DataTable(sheetname);
            if (sheetname == "AgencyMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("AgencyName");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");


                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                t.Columns.Add("Version_1_JanuaryMonthAmount");
                t.Columns.Add("Version_2_JanuaryMonthAmount");
                t.Columns.Add("Version_1_FebruaryMonthAmount");
                t.Columns.Add("Version_2_FebruaryMonthAmount");
                t.Columns.Add("Version_1_MarchMonthAmount");
                t.Columns.Add("Version_2_MarchMonthAmount");
                t.Columns.Add("Version_1_AprilMonthAmount");
                t.Columns.Add("Version_2_AprilMonthAmount");
                t.Columns.Add("Version_1_MayMonthAmount");
                t.Columns.Add("Version_2_MayMonthAmount");
                t.Columns.Add("Version_1_JuneMonthAmount");
                t.Columns.Add("Version_2_JuneMonthAmount");
                t.Columns.Add("Version_1_JulyMonthAmount");
                t.Columns.Add("Version_2_JulyMonthAmount");
                t.Columns.Add("Version_1_AugastMonthAmount");
                t.Columns.Add("Version_2_AugastMonthAmount");
                t.Columns.Add("Version_1_SeptemberMonthAmount");
                t.Columns.Add("Version_2_SeptemberMonthAmount");
                t.Columns.Add("Version_1_OctoberMonthAmount");
                t.Columns.Add("Version_2_OctoberMonthAmount");
                t.Columns.Add("Version_1_NovemberMonthAmount");
                t.Columns.Add("Version_2_NovemberMonthAmount");
                t.Columns.Add("Version_1_DecemberMonthAmount");
                t.Columns.Add("Version_2_DecemberMonthAmount");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "AgencyName" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message"
                            || propInfo.Name == "Version_1_JanuaryMonthAmount" || propInfo.Name == "Version_2_JanuaryMonthAmount" || propInfo.Name == "Version_1_FebruaryMonthAmount" || propInfo.Name == "Version_2_FebruaryMonthAmount" ||
                            propInfo.Name == "Version_1_MarchMonthAmount" || propInfo.Name == "Version_2_MarchMonthAmount" || propInfo.Name == "Version_1_AprilMonthAmount" || propInfo.Name == "Version_2_AprilMonthAmount"
                            || propInfo.Name == "Version_1_MayMonthAmount" || propInfo.Name == "Version_2_MayMonthAmount" || propInfo.Name == "Version_1_JuneMonthAmount" || propInfo.Name == "Version_2_JuneMonthAmount" || propInfo.Name == "Version_1_JulyMonthAmount" || propInfo.Name == "Version_2_JulyMonthAmount" || propInfo.Name == "Version_1_AugastMonthAmount" || propInfo.Name == "Version_2_AugastMonthAmount"
                            || propInfo.Name == "Version_1_SeptemberMonthAmount" || propInfo.Name == "Version_2_SeptemberMonthAmount" || propInfo.Name == "Version_1_OctoberMonthAmount" || propInfo.Name == "Version_2_OctoberMonthAmount" || propInfo.Name == "Version_1_NovemberMonthAmount" || propInfo.Name == "Version_2_NovemberMonthAmount" || propInfo.Name == "Version_1_DecemberMonthAmount" || propInfo.Name == "Version_2_DecemberMonthAmount")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "CustomerMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("CustomerName");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "CustomerName" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "VendorMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("VendorName");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "VendorName" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "ProductMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("ProductName");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "ProductName" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "ProgramMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("ProgramName");
                t.Columns.Add("MediaType");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "ProgramName" || propInfo.Name == "MediaType" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "MediaTypeMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("MediaType");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "MediaType" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            return t;
        }

        public static DataTable ToDataSetForAccrual<T>(this IList<T> list, string sheetname)
        {
            Type elementType = typeof(T);
            DataTable t = new DataTable(sheetname);
            if (sheetname == "AgencyMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("AgencyName");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");


                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //t.Columns.Add("Version_1_JanuaryMonthAmount");
                //t.Columns.Add("Version_2_JanuaryMonthAmount");
                t.Columns.Add("VarianceJanuaryMonthAmount");
                //t.Columns.Add("Version_1_FebruaryMonthAmount");
                //t.Columns.Add("Version_2_FebruaryMonthAmount");
                t.Columns.Add("VarianceFebruaryMonthAmount");
                //t.Columns.Add("Version_1_MarchMonthAmount");
                //t.Columns.Add("Version_2_MarchMonthAmount");
                t.Columns.Add("VarianceMarchMonthAmount");
                //t.Columns.Add("Version_1_AprilMonthAmount");
                //t.Columns.Add("Version_2_AprilMonthAmount");
                t.Columns.Add("VarianceAprilMonthAmount");
                //t.Columns.Add("Version_1_MayMonthAmount");
                //t.Columns.Add("Version_2_MayMonthAmount");
                t.Columns.Add("VarianceMayMonthAmount");
                //t.Columns.Add("Version_1_JuneMonthAmount");
                //t.Columns.Add("Version_2_JuneMonthAmount");
                t.Columns.Add("VarianceJuneMonthAmount");
                //t.Columns.Add("Version_1_JulyMonthAmount");
                //t.Columns.Add("Version_2_JulyMonthAmount");
                t.Columns.Add("VarianceJulyMonthAmount");
                //t.Columns.Add("Version_1_AugastMonthAmount");
                //t.Columns.Add("Version_2_AugastMonthAmount");
                t.Columns.Add("VarianceAugastMonthAmount");
                //t.Columns.Add("Version_1_SeptemberMonthAmount");
                //t.Columns.Add("Version_2_SeptemberMonthAmount");

                t.Columns.Add("VarianceSeptemberMonthAmount");
                //t.Columns.Add("Version_1_OctoberMonthAmount");
                //t.Columns.Add("Version_2_OctoberMonthAmount");
                t.Columns.Add("VarianceOctoberMonthAmount");
                //t.Columns.Add("Version_1_NovemberMonthAmount");
                //t.Columns.Add("Version_2_NovemberMonthAmount");
                t.Columns.Add("VarianceNovemberMonthAmount");
                //t.Columns.Add("Version_1_DecemberMonthAmount");
                //t.Columns.Add("Version_2_DecemberMonthAmount");
                t.Columns.Add("VarianceDecemberMonthAmount");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "AgencyName" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message"
                            //|| propInfo.Name == "Version_1_JanuaryMonthAmount" || propInfo.Name == "Version_2_JanuaryMonthAmount" || propInfo.Name == "Version_1_FebruaryMonthAmount" || propInfo.Name == "Version_2_FebruaryMonthAmount" || 
                            //propInfo.Name == "Version_1_MarchMonthAmount" || propInfo.Name == "Version_2_MarchMonthAmount" || propInfo.Name == "Version_1_AprilMonthAmount" || propInfo.Name == "Version_2_AprilMonthAmount"
                            //|| propInfo.Name == "Version_1_MayMonthAmount" || propInfo.Name == "Version_2_MayMonthAmount" || propInfo.Name == "Version_1_JuneMonthAmount" || propInfo.Name == "Version_2_JuneMonthAmount" || propInfo.Name == "Version_1_JulyMonthAmount" || propInfo.Name == "Version_2_JulyMonthAmount" || propInfo.Name == "Version_1_AugastMonthAmount" || propInfo.Name == "Version_2_AugastMonthAmount"
                            //|| propInfo.Name == "Version_1_SeptemberMonthAmount" || propInfo.Name == "Version_2_SeptemberMonthAmount" || propInfo.Name == "Version_1_OctoberMonthAmount" || propInfo.Name == "Version_2_OctoberMonthAmount" 
                            //|| propInfo.Name == "Version_1_NovemberMonthAmount" || propInfo.Name == "Version_2_NovemberMonthAmount" || propInfo.Name == "Version_1_DecemberMonthAmount" || propInfo.Name == "Version_2_DecemberMonthAmount"

                            || propInfo.Name == "VarianceNovemberMonthAmount" || propInfo.Name == "VarianceDecemberMonthAmount" || propInfo.Name == "VarianceOctoberMonthAmount" || propInfo.Name == "VarianceSeptemberMonthAmount"
                            || propInfo.Name == "VarianceAugastMonthAmount" || propInfo.Name == "VarianceJulyMonthAmount" || propInfo.Name == "VarianceJuneMonthAmount" || propInfo.Name == "VarianceMayMonthAmount"
                            || propInfo.Name == "VarianceJanuaryMonthAmount" || propInfo.Name == "VarianceFebruaryMonthAmount" || propInfo.Name == "VarianceMarchMonthAmount" || propInfo.Name == "VarianceAprilMonthAmount"
                            )
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "CustomerMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("CustomerName");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "CustomerName" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "VendorMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("VendorName");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "VendorName" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "ProductMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("ProductName");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "ProductName" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "ProgramMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("ProgramName");
                t.Columns.Add("MediaType");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "ProgramName" || propInfo.Name == "MediaType" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "MediaTypeMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("MediaType");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "MediaType" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            return t;
        }


        public static DataTable ToDataSet<T>(this IList<T> list, string sheetname)
        {
            Type elementType = typeof(T);
            DataTable t = new DataTable(sheetname);

            if (sheetname == "AgencyMediaSpendingList")
            {

                //add a column to table for each public property on T
                foreach (var propInfo in elementType.GetProperties())
                {
                    Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                    t.Columns.Add(propInfo.Name);
                }


                //go through each property on T and add each value to the table


                foreach (T item in list)
                {
                    DataRow row = t.NewRow();

                    foreach (var propInfo in elementType.GetProperties())
                    {

                        row[propInfo.Name] = propInfo.GetValue(item);

                    }

                    t.Rows.Add(row);
                }
            }
            return t;
        }

        public static DataTable ToDataSetForRebateAccrual<T>(this IList<T> list, string sheetname)
        {
            Type elementType = typeof(T);
            DataTable t = new DataTable(sheetname);
            if (sheetname == "AccrualRebate")
            {
                //add a column to table for each public property on T
                t.Columns.Add("AgencyName");
                t.Columns.Add("CustomerName");
                t.Columns.Add("VendorName");
                t.Columns.Add("ModelType");
                t.Columns.Add("AcrualRebateRate");
                t.Columns.Add("JanuaryMonthAmount");
                t.Columns.Add("AcrualRebateJan");
                t.Columns.Add("FebruaryMonthAmount");
                t.Columns.Add("AcrualRebateFeb");
                t.Columns.Add("MarchMonthAmount");
                t.Columns.Add("AcrualRebateMar");
                t.Columns.Add("AprilMonthAmount");
                t.Columns.Add("AcrualRebateApr");
                t.Columns.Add("MayMonthAmount");
                t.Columns.Add("AcrualRebateMay");
                t.Columns.Add("JuneMonthAmount");
                t.Columns.Add("AcrualRebateJun");
                t.Columns.Add("JulyMonthAmount");
                t.Columns.Add("AcrualRebateJul");
                t.Columns.Add("AugastMonthAmount");
                t.Columns.Add("AcrualRebateAug");
                t.Columns.Add("SeptemberMonthAmount");
                t.Columns.Add("AcrualRebateSep");
                t.Columns.Add("OctoberMonthAmount");
                t.Columns.Add("AcrualRebateOct");
                t.Columns.Add("NovemberMonthAmount");
                t.Columns.Add("AcrualRebateNov");
                t.Columns.Add("DecemberMonthAmount");
                t.Columns.Add("AcrualRebateDec");
                t.Columns.Add("TotalMonthAmount");
                t.Columns.Add("AdjustedMediaSpendingFinal");
                t.Columns.Add("TotalAcrualRebate");


                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "TotalMonthAmount" || propInfo.Name == "TotalAcrualRebate" ||
                            propInfo.Name == "AgencyName" || propInfo.Name == "CustomerName" ||
                            propInfo.Name == "VendorName" || propInfo.Name == "ModelType" ||
                            propInfo.Name == "AcrualRebateRate" || propInfo.Name == "JanuaryMonthAmount" ||
                            propInfo.Name == "AcrualRebateJan" || propInfo.Name == "FebruaryMonthAmount" ||
                            propInfo.Name == "AcrualRebateFeb" || propInfo.Name == "MarchMonthAmount" ||
                            propInfo.Name == "AcrualRebateMar" || propInfo.Name == "AprilMonthAmount" ||
                            propInfo.Name == "AcrualRebateApr" || propInfo.Name == "MayMonthAmount" ||
                            propInfo.Name == "AcrualRebateMay" || propInfo.Name == "JuneMonthAmount" ||
                            propInfo.Name == "AcrualRebateJun" || propInfo.Name == "JulyMonthAmount" ||
                            propInfo.Name == "AcrualRebateJul" || propInfo.Name == "AugastMonthAmount" ||
                            propInfo.Name == "AcrualRebateAug" || propInfo.Name == "SeptemberMonthAmount" ||
                            propInfo.Name == "AcrualRebateSep" || propInfo.Name == "OctoberMonthAmount" ||
                            propInfo.Name == "AcrualRebateOct" || propInfo.Name == "NovemberMonthAmount" ||
                            propInfo.Name == "AcrualRebateNov" || propInfo.Name == "DecemberMonthAmount" ||
                            propInfo.Name == "AdjustedMediaSpendingFinal" || propInfo.Name == "AcrualRebateDec")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "UnileverAccrualRebate")
            {


                //add a column to table for each public property on T
                t.Columns.Add("VendorName");
                // t.Columns.Add("ModelType");
                //t.Columns.Add("_TotalAdjustedMediaSpendingFinal");
                //t.Columns.Add("_UnileverPakistanFoodsLtd");
                //t.Columns.Add("_UnileverPakistanLtd");
                //t.Columns.Add("_NetSpending");
                //t.Columns.Add("_ApplicableRate");
                //t.Columns.Add("_ApplicableRateNetSpending");
                //t.Columns.Add("_IncrementalPercentage");
                //t.Columns.Add("_RebateAllSpend");
                //t.Columns.Add("_RebateNetSpending");
                //t.Columns.Add("_IncrementalRebate");
                //t.Columns.Add("_UlBase");
                //t.Columns.Add("_AVBFactor");
                //t.Columns.Add("_UlIncremental");
                //t.Columns.Add("_UlExisting");
                //t.Columns.Add("_TotalUlPassBack");

                t.Columns.Add("TotalAdjustedMediaSpendingFinal");
                t.Columns.Add("UnileverPakistanFoodsLtd");
                t.Columns.Add("UnileverPakistanLtd");
                t.Columns.Add("NetSpending");
                t.Columns.Add("ApplicableRate");
                t.Columns.Add("ApplicableRateNetSpending");
                t.Columns.Add("IncrementalPercentage");
                t.Columns.Add("RebateAllSpend");
                t.Columns.Add("RebateNetSpending");
                t.Columns.Add("IncrementalRebate");
                t.Columns.Add("UlBase");
                t.Columns.Add("AVBFactor");
                t.Columns.Add("UlIncremental");
                t.Columns.Add("UlExisting");
                t.Columns.Add("TotalUlPassBack");
              

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "VendorName" ||
                            propInfo.Name == "TotalAdjustedMediaSpendingFinal" || propInfo.Name == "UnileverPakistanFoodsLtd" ||
                            propInfo.Name == "UnileverPakistanLtd" || propInfo.Name == "NetSpending" || propInfo.Name == "ApplicableRate" ||
                            propInfo.Name == "ApplicableRateNetSpending" || propInfo.Name == "IncrementalPercentage" ||
                            propInfo.Name == "RebateAllSpend" || propInfo.Name == "RebateNetSpending" ||
                            propInfo.Name == "IncrementalRebate" || propInfo.Name == "UlBase" ||
                            propInfo.Name == "AVBFactor" || propInfo.Name == "UlIncremental" ||
                            propInfo.Name == "UlIncremental" || propInfo.Name == "UlExisting" ||
                            propInfo.Name == "TotalUlPassBack")

                        //    propInfo.Name == "_TotalAdjustedMediaSpendingFinal" || propInfo.Name == "_UnileverPakistanFoodsLtd" ||
                        //propInfo.Name == "_UnileverPakistanLtd" || propInfo.Name == "_NetSpending" || propInfo.Name == "_ApplicableRate" ||
                        //propInfo.Name == "_ApplicableRateNetSpending" || propInfo.Name == "_IncrementalPercentage" ||
                        //propInfo.Name == "_RebateAllSpend" || propInfo.Name == "_RebateNetSpending" ||
                        //propInfo.Name == "_IncrementalRebate" || propInfo.Name == "_UlBase" ||
                        //propInfo.Name == "_AVBFactor" || propInfo.Name == "_UlIncremental" ||
                        //propInfo.Name == "_UlIncremental" || propInfo.Name == "_UlExisting" ||
                        //propInfo.Name == "_TotalUlPassBack")
                        {
                          
                                row[propInfo.Name] = propInfo.GetValue(item);
                        
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "CustomerMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("CustomerName");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "CustomerName" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "VendorMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("VendorName");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "VendorName" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "ProductMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("ProductName");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "ProductName" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "ProgramMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("ProgramName");
                t.Columns.Add("MediaType");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "ProgramName" || propInfo.Name == "MediaType" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            else if (sheetname == "MediaTypeMediaSpendingList")
            {
                //add a column to table for each public property on T
                t.Columns.Add("MediaType");
                t.Columns.Add("Version1_Amount");
                t.Columns.Add("Version2_Amount");
                t.Columns.Add("Amount");
                t.Columns.Add("Message");

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if (propInfo.Name == "MediaType" || propInfo.Name == "Version1_Amount" || propInfo.Name == "Version2_Amount" || propInfo.Name == "Amount" || propInfo.Name == "Message")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
          else  if (sheetname == "AdditionalIncentive")
            {
                //add a column to table for each public property on T
                t.Columns.Add("AgencyName");
                t.Columns.Add("CustomerName");
                t.Columns.Add("VendorName");
                t.Columns.Add("AdjustedMediaSpendingFinal");
                t.Columns.Add("ModelType");
                t.Columns.Add("IncentiveRate");
                t.Columns.Add("Incentive");
            

                //go through each property on T and add each value to the table
                foreach (T item in list)
                {
                    DataRow row = t.NewRow();
                    foreach (var propInfo in elementType.GetProperties())
                    {
                        if(propInfo.Name=="AgencyName" || propInfo.Name== "CustomerName" ||
                            propInfo.Name=="VendorName" || propInfo.Name== "AdjustedMediaSpendingFinal" ||
                            propInfo.Name== "ModelType" || propInfo.Name== "IncentiveRate" || propInfo.Name=="Incentive")
                        {
                            row[propInfo.Name] = propInfo.GetValue(item);
                        }
                    }
                    t.Rows.Add(row);
                }
            }
            return t;
        }

    }
}
