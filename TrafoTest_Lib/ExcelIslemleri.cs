using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using TrafoTest_Model.Model;

namespace TrafoTest_Lib
{
    public class ExcelIslemleri
    {
        public void ExceleAktar(System.Data.DataTable dtYeniRapor)
        {
            Application excel = null;
            Workbook wb = null;

            object missing = Type.Missing;
            Worksheet ws = null;

            try
            {
                excel = new Application();
                wb = excel.Workbooks.Add();
                ws = (Worksheet)wb.ActiveSheet;

                //Range rng = ws.Range[ws.Cells[0, 0], ws.Cells[0, dtYeniRapor.Columns.Count]];
                //rng.Merge();

                //ws.Range[ws.Cells[0, 0], ws.Cells[0, dtYeniRapor.Columns.Count]].MergeCells();

                //ws.Range["A1"].Value = "Akış Raporu";

                for (int Idx = 0; Idx < 9; Idx++)
                {
                    ws.Range["A1"].Offset[0, Idx].Value = dtYeniRapor.Columns[Idx].ColumnName;
                    ws.Range["A1"].Offset[0, Idx].ColumnWidth = 20;
                }


                for (int Idx = 0; Idx < dtYeniRapor.Rows.Count; Idx++)
                {
                    ws.Range["A2"].Offset[Idx].Resize[1, 9].Value = dtYeniRapor.Rows[Idx].ItemArray;
                }

                ws.Columns.AutoFit();

                excel.Visible = true;
                excel.ActiveWindow.Activate();
            }
            catch (COMException ex)
            {
                throw new Exception("Excel'e erişme hatası: " + ex.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Hata: " + ex.ToString());
            }
        } 
        public void ExceleAktar(List<ISLEM_DETAY> list, List<ISLEM_RECETE> listIslemRecete)
        {
            Application excel = null;
            Workbook wb = null;

            object missing = Type.Missing;
            Worksheet ws = null;

            try
            {
                excel = new Application();
                wb = excel.Workbooks.Add();
                ws = (Worksheet)wb.ActiveSheet;

                string[] columns = typeof(ISLEM_RECETE).GetProperties().Select(property => property.Name).ToArray();

                for (int Idx = 0; Idx < columns.Length; Idx++)
                {
                    ws.Range["A1"].Offset[0, Idx].Value = columns[Idx];
                    ws.Range["A1"].Offset[0, Idx].ColumnWidth = 20;
                }

                for (int Idx = 0; Idx < listIslemRecete.Count; Idx++)
                {

                }

                ws.Columns.AutoFit();
                excel.Visible = true;
                excel.ActiveWindow.Activate();
            }
            catch (COMException ex)
            {
                throw new Exception("Excel'e erişme hatası: " + ex.ToString());
            }
            catch (Exception ex)
            {
                throw new Exception("Hata: " + ex.ToString());
            }
        }
        public void ExportExcelAlarm<T>(List<T> list, Type type)//Ekledim
        {
            Application excelApp = ExceleAktar(list, type);
            excelApp.Visible = true;
        }

        public Application ExceleAktar<T>(List<T> list, Type type)
        {
            try
            {
                Application xlApp;
                Workbook xlWorkBook;
                Worksheet xlWorkSheet;
                object misValue = Missing.Value;

                xlApp = new Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

                int i = 1;

                string[] columns = type.GetProperties().Select(property => property.Name).ToArray();

                for (int Idx = 0; Idx < columns.Length; Idx++)
                {
                    xlWorkSheet.Range["A1"].Offset[0, Idx].Value = columns[Idx];
                    xlWorkSheet.Range["A1"].Offset[0, Idx].ColumnWidth = 20;
                }

                foreach (T t in list)
                {
                    int j = 0;

                    foreach (PropertyInfo info in typeof(T).GetProperties())
                    {
                        try
                        {
                            if (!IsNullableType(info.PropertyType))
                            {
                                xlWorkSheet.Cells[i + 1, j + 1] = info.GetValue(t, null);
                            }
                            else
                            {
                                if (info.GetValue(t, null) != null)
                                {
                                    xlWorkSheet.Cells[i + 1, j + 1] = info.GetValue(t, null);
                                }
                                else
                                {
                                    xlWorkSheet.Cells[i + 1, j + 1] = DBNull.Value;
                                }
                            }
                            j++;
                        }
                        catch
                        {

                        }
                    }
                    i++;
                }

                xlWorkSheet.Columns.AutoFit();

                return xlApp;
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                return null;
            }
        }
        public bool ExportExcel<T>(List<string> trafolar, string path, List<T> list, Type type)
        {
            Application excelApp = ExceleAktar(trafolar,path, list, type);

            excelApp.Range["Q1"].EntireColumn.Delete(null);
            excelApp.Range["P1"].EntireColumn.Delete(null);
            excelApp.Range["M1"].EntireColumn.Delete(null);
            excelApp.Range["C1"].EntireColumn.Delete(null);
            excelApp.Range["B1"].EntireColumn.Delete(null);

            excelApp.Visible = true;
            return true;
        }
        private Application ExceleAktar<T>(List<string> trafolar, string path, List<T> list, Type type)
        {
            try
            {
                Application xlApp;
                Workbook xlWorkBook;
                Worksheet xlWorkSheet;
                object misValue = Missing.Value;

                xlApp = new Application();
                xlWorkBook = xlApp.Workbooks.Add(misValue);
                xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);


                string[] columns = type.GetProperties().Select(property => property.Name).ToArray();

                for (int Idx = 0; Idx < columns.Length; Idx++)
                {
                    xlWorkSheet.Range["A1"].Offset[0, Idx].Value = columns[Idx];
                    xlWorkSheet.Range["A1"].Offset[0, Idx].ColumnWidth = 20;
                }

                int i = 1;
                foreach (T t in list)
                {
                    int j = 0;

                    foreach (PropertyInfo info in typeof(T).GetProperties())
                    {
                        try
                        {
                            if (!IsNullableType(info.PropertyType))
                            {
                                xlWorkSheet.Cells[i + 1, j + 1] = info.GetValue(t, null);
                            }
                            else
                            {
                                if (info.GetValue(t, null) != null)
                                {
                                    xlWorkSheet.Cells[i + 1, j + 1] = info.GetValue(t, null);
                                }
                                else
                                {
                                    xlWorkSheet.Cells[i + 1, j + 1] = DBNull.Value;
                                }
                            }
                            j++;
                        }
                        catch
                        {

                        }
                    }
                    i++;
                }


                int col = columns.Length + 1;

                Range myRange = (Range)xlWorkSheet.Cells[1, col];
                myRange.Value2 = "Trafolar";
                myRange.ColumnWidth =50;


                for (int Idx = 1; Idx < trafolar.Count; Idx++)
                {
                    Range rng = (Range)xlWorkSheet.Cells[Idx + 1, col];
                    rng.Value2 = trafolar[Idx - 1];
                }

                //xlWorkBook.SaveAs(path, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);

                //xlWorkBook.Close(true, misValue, misValue);
                //xlApp.Quit();

                //releaseObject(xlWorkSheet);
                //releaseObject(xlWorkBook);
                //releaseObject(xlApp);
                xlWorkSheet.Columns.AutoFit();

                if (list.Count > trafolar.Count)
                {
                    xlWorkSheet.Shapes.AddPicture(path, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, xlWorkSheet.Rows.RowHeight * (list.Count + 2), 742, 396);
                }
                else
                {
                    xlWorkSheet.Shapes.AddPicture(path, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, xlWorkSheet.Rows.RowHeight * (trafolar.Count + 2), 742, 396);

                }


                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                return xlApp;
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);
                return null;
            }
        }
        private void releaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                Loglama.Log(ex);                    
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }
        #region HELPER_FUNCTIONS
        //  This function is adapated from: http://www.codeguru.com/forum/showthread.php?t=450171
        //  My thanks to Carl Quirion, for making it "nullable-friendly".
        //public static DataTable ListToDataTable<T>(List<T> list)
        //{
        //    DataTable dt = new DataTable();

        //    foreach (PropertyInfo info in typeof(T).GetProperties())
        //    {
        //        dt.Columns.Add(new DataColumn(info.Name, GetNullableType(info.PropertyType)));
        //    }

        //    foreach (T t in list)
        //    {
        //        DataRow row = dt.NewRow();

        //        foreach (PropertyInfo info in typeof(T).GetProperties())
        //        {
        //            if (!IsNullableType(info.PropertyType))
        //            {
        //                row[info.Name] = info.GetValue(t, null);
        //            }
        //            else
        //            {
        //                if (info.GetValue(t, null) != null)
        //                {
        //                    row[info.Name] = info.GetValue(t, null);
        //                }
        //                else
        //                {
        //                    row[info.Name] = DBNull.Value;
        //                }
        //            }
        //        }

        //        dt.Rows.Add(row);
        //    }

        //    return dt;
        //}

        private static Type GetNullableType(Type t)
        {
            Type returnType = t;
            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                returnType = Nullable.GetUnderlyingType(t);
            }
            return returnType;
        }
        private static bool IsNullableType(Type type)
        {
            return (type == typeof(string) ||
                    type.IsArray ||
                    (type.IsGenericType &&
                     type.GetGenericTypeDefinition().Equals(typeof(Nullable<>))));
        }

        //public static bool CreateExcelDocument(System.Data.DataTable dt, string xlsxFilePath)
        //{
        //    System.Data.DataSet ds = new System.Data.DataSet();
        //    ds.Tables.Add(dt);
        //    bool result = CreateExcelDocument(ds, xlsxFilePath);
        //    ds.Tables.Remove(dt);
        //    return result;
        //}
        #endregion
    }
}