using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Threading;

namespace DomainChecker
{
    class Loader
    {
        string FileName;
        Form1 f;
        private List<string> data = new List<string>();
        public Loader(Form1 f, string FileName)
        {
            this.f = f;
            this.FileName = FileName;
        }

        public List<string> GetData()
        {
            return data;
        }

        public List<string> XlsRead()
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
                excelappworkbook = excelapp.Workbooks.Open(@FileName,
                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                 Type.Missing, Type.Missing);
                excelsheets = excelappworkbook.Worksheets;
                //Получаем ссылку на лист 1
                excelworksheet = (Excel.Worksheet)excelsheets.get_Item(1);
                try
                {
                    int m;
                    bool eof = false;
                    for (m = 1; eof == false; m++)
                    {
                        excelcells = (Excel.Range)excelworksheet.Cells[m, 1];
                        if (excelcells.Value2 != null)
                        {
                            data.Add(Convert.ToString(excelcells.Value2));
                        }
                        else eof = true;
                    }
                }
                catch (NullReferenceException)
                {
                    f.RunForm2(f, "Ошибка чтения!");
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
                f.RunForm2(f,"Файл не существует, проверьте правильность пути!");
            }
            catch (Exception exc)
            {
                f.RunForm2(f, exc.Message);
            }
            return data;
        }
        public List<string> TxtRead()
        {
            try
            {
                FileStream FileS = null;
                try
                {
                    FileS = new FileStream(FileName, FileMode.Open);
                }
                catch (IOException)
                {
                    f.RunForm2(f, "Ошибка открытия файла!");
                }
                string s;

                StreamReader FileSR = new StreamReader(FileS);
                try
                {
                    while ((s = FileSR.ReadLine()) != null)
                    {
                        data.Add(s);
                    }
                }
                catch (IOException)
                {
                    f.RunForm2(f, "Ошибка ввода-вывода!");
                }
                finally
                {
                    FileSR.Close();
                }
            }
            catch
            {
                if (FileName.Contains("wservers.txt"))
                    f.RunForm2(f, "Ошибка ввода-вывода!\r\nПеренесите в папку с DomainChecker.exe\r\nфайл базы whois-серверов wservers.txt.\r\nПриложение будет закрыто...");
            }
            return data;
        }
    }
}
