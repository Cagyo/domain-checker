using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace DomainChecker
{
    class Writer
    {
        string FileName;
        Form1 f;
        private List<string> data = new List<string>();
        public Writer(Form1 f, string FileName, List<string> data)
        {
            this.f = f;
            this.FileName = FileName;
            this.data = data;
        }

        public void TxtWrite()
        {
            try
            {
                FileStream FileS = null;
                try
                {
                    FileS = new FileStream(FileName, FileMode.Create);
                }
                catch (IOException)
                {
                    f.RunForm2(f, "Ошибка открытия файла!");
                }

                StreamWriter FileSW = new StreamWriter(FileS);
                try
                {
                    for (int i = 0; i < data.Count; i += 5)
                        FileSW.WriteLine(data[i] + "|" + data[i + 1] + "|" + data[i + 2] + "|" + data[i + 3] + "|" + data[i + 4], Encoding.GetEncoding(65001));
                }
                catch (IOException)
                {
                    f.RunForm2(f, "Ошибка ввода-вывода!");
                }
                finally
                {
                    FileSW.Close();
                }
            }
            catch
            {
                if (FileName.Contains("wservers.txt"))
                    f.RunForm2(f, "Ошибка ввода-вывода!\r\nПеренесите в папку с DomainChecker.exe\r\nфайл базы whois-серверов wservers.txt.\r\nПриложение будет закрыто...");
            }
        }


        public void XlsWrite()
        {
            try
            {
                //добавить отлов исключения при неналичии экселя
                Excel.Application excelapp = null;
                Excel.Workbooks excelappworkbooks;
                Excel.Workbook excelappworkbook;
                Excel.Sheets excelsheets;
                Excel.Worksheet excelworksheet;
                Excel.Range excelcells;
                excelapp = new Excel.Application();
                excelapp.Visible = false;
                excelappworkbooks = excelapp.Workbooks;
                //Открываем книгу и получаем на нее ссылку
                excelappworkbook = excelapp.Workbooks.Add(Type.Missing); 
                excelsheets = excelappworkbook.Worksheets;
                //Получаем ссылку на лист 1
                excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);

                try
                {
                    excelcells = (Excel.Range)excelworksheet.Cells[1, 1];
                    excelcells.Value2 = "Домен";
                    excelcells = (Excel.Range)excelworksheet.Cells[1, 2];
                    excelcells.Value2 = "Занятость";
                    excelcells = (Excel.Range)excelworksheet.Cells[1, 3];
                    excelcells.Value2 = "ТиЦ";
                    excelcells = (Excel.Range)excelworksheet.Cells[1, 4];
                    excelcells.Value2 = "IP домена";
                    excelcells = (Excel.Range)excelworksheet.Cells[1, 5];
                    excelcells.Value2 = "PR";
                    for (int i = 0, m = 2; i < data.Count; i += 5, m++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            excelcells = (Excel.Range)excelworksheet.Cells[m, j + 1];
                            excelcells.Value2 = data[i + j];
                        }
                    }
                    excelappworkbook.SaveAs(FileName, Excel.XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing,
                        Type.Missing, Type.Missing, Type.Missing);
                }
                catch (NullReferenceException)
                {
                    f.RunForm2(f, "Ошибка записи!");
                    excelcells = null;
                    excelappworkbook.Close(true, Type.Missing, Type.Missing);
                    excelapp.Workbooks.Close();
                    excelappworkbooks = null;
                    excelworksheet = null;
                    excelsheets = null;
                    excelappworkbook = null;
                    excelapp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelapp);
                    excelapp = null;
                    GC.Collect();
                }
                finally
                {
                    excelcells = null;
                    excelappworkbook.Close();
                    excelapp.Workbooks.Close();
                    excelappworkbooks = null;
                    excelworksheet = null;
                    excelsheets = null;
                    excelappworkbook = null;
                    excelapp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelapp);
                    excelapp = null;
                    GC.Collect();
                }
            }
            catch (System.Runtime.InteropServices.COMException)
            {
                f.RunForm2(f, "Файл не существует, проверьте правильность пути!");
            }
            catch (Exception exc)
            {
                f.RunForm2(f, exc.Message);
            }
        }
    }
}
