using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyADO.NetApp.HelperClasses
{

    public class HelperMethods
    {
        public HelperMethods()
        {

        }

        public DataTable SetupDT()
        {
            var employeeTable = new DataTable();

            employeeTable.Columns.Add("Employee ID");
            employeeTable.Columns.Add("Employee Surname");
            employeeTable.Columns.Add("Employee Name");
            employeeTable.Columns.Add("Ranks Id");
            employeeTable.Columns.Add("Working Machine");
            employeeTable.Columns.Add("Hired By");
            employeeTable.Columns.Add("Reporting To");
            employeeTable.Columns.Add("Date of Admission");

            return employeeTable;
        }

        public void WriteTable(DataTable table, string path)
        {
            var stream = new FileStream(path, FileMode.Open, FileAccess.Write);
            using var writer = new StreamWriter(stream, Encoding.Default);

            var cols = new List<string>();

            foreach (DataColumn col in table.Columns) cols.Add(col.ColumnName);

            var headers = string.Join(" || ", cols);
            writer.WriteLine(headers);

            foreach (DataRow row in table.Rows)
            {
                var cells = new List<string>();
                foreach (DataColumn column in table.Columns)
                {
                    var cell = row[column];
                    cells.Add(cell.ToString());
                }
                var rowLine = string.Join(" || ", cells);
                writer.WriteLine(rowLine);
            }
            writer.Flush();
            writer.Dispose();
        }

        public string GetPath()
        {
            var solution = Assembly.GetExecutingAssembly();
#pragma warning disable SYSLIB0012 // Type or member is obsolete
            var dir = Path.GetDirectoryName(solution.CodeBase);
#pragma warning restore SYSLIB0012 // Type or member is obsolete

            if (dir == null || dir == "") return "";
            var path = dir.Replace("file:\\", "");

            return $"{path}\\Result";
        }

    }
}
