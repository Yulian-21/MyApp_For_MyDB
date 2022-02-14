using System;
using System.Linq;
using System.Data.SqlClient;
using MyADO.NetApp.DataClasses;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Reflection;

namespace MyADO.NetApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var helper = new HelperMethods();
            var resultPath = helper.GetPath();

            using (var context = new MyContext())
            {

                //var machines = context.WorkingMachine.Select(_ => _.MachineName).ToList();
                //var models = context.WorkingMachine.Select(_ => _.ModelName).ToList();

                //Dictionary<string, string> pcNames = new();

                //for (int i = 0; i < machines.Count; i++)
                //    pcNames.Add(models[i], machines[i]);

                //foreach (var item in pcNames)
                //    Console.WriteLine($" Machine name:  {item.Value} || Model Name: {item.Key}");

                var employeesId = context.Employees.Select(_ => _.EmployeeID).ToList();
                var employeesName = context.Employees.Select(_ => _.EmployeeName).ToList();
                var empSurName = context.Employees.Select(_ => _.EmployeeSurname).ToList();
                var empRank = context.Employees.Select(_ => _.RanksId).ToList();
                var wM = context.Employees.Select(_ => _.WorkingMachineId.ToString()).ToList();
                var hB = context.Employees.Select(_ => _.HiredBy.ToString()).ToList();
                var admissionDate = context.Employees.Select(_ => _.DateofAdmission.ToString("yyyy/MM/dd")).ToList();
                var pMId = context.Employees.Select(_ => _.ReportingTo.ToString()).ToList();

                var employeeTable = helper.SetupDT();

                for (int i = 0; i < employeesId.Count; i++)
                {
                    var newRow = employeeTable.NewRow();

                    newRow["Employee ID"] = employeesId[i];
                    newRow["Employee Surname"] = empSurName[i];
                    newRow["Employee Name"] = employeesName[i];
                    newRow["Ranks Id"] = empRank[i];
                    newRow["Working Machine"] = wM[i];
                    newRow["Hired By"] = hB[i];
                    newRow["Date of Admission"] = admissionDate[i];
                    newRow["Reporting To"] = pMId[i];

                    employeeTable.Rows.Add(newRow);
                }

                var path = @"C:\Users\yulian.dius\source\repos\MyADO.NetApp\Result\EmployeeSource.docx";
                //var path = Path.Combine(resultPath, "EmployeeSource.docx");
                helper.WriteTable(employeeTable, path);


            }
            Console.WriteLine("aaaaaaa");

        }



    }


    public class HelperMethods
    {
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



//var machine = new WorkingMachine()
//{
//    //MachineID = 10,
//    MachineName = "Acer",
//    ModelName = "Nitro"
//};

//context.WorkingMachine.Add(machine);
//context.SaveChanges();
//*********************
//var salary = new Salary()
//{
//    DollarsPerHour = 12
//};

//context.Salary.Add(salary);
//context.SaveChanges();
//*********************
//context.WorkingMachine.Remove(machine);
//context.SaveChanges();

//var somth = context.Salary.Select(_ => _.DollarsPerHour);
//foreach (var item in somth)
//{
//    Console.WriteLine(item);
//}


//**********************************************

//while (reader.Read()) // построчно считываем данные
//{
//    object id = reader.GetValue(0);
//    object name = reader.GetValue(1);
//    object age = reader.GetValue(2);

//    Console.WriteLine("{0} \t{1} \t{2}", id, name, age);
//}

/*  public const string ConnectionString = @"Data Source=CODLING;Initial Catalog=ITCompany;Integrated Security=SSPI;";
        static void Main(string[] args)
        {
            var queryString = "SELECT * FROM Employees";

            using var connStr = new SqlConnection(ConnectionString);
            connStr.Open();

            SqlCommand command = new(queryString, connStr);
            using (SqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read())
                {
                    Console.WriteLine(reader[7].ToString() + ". " + reader[0].ToString() + "/ " + reader[1].ToString() + "/ " + reader[2].ToString() + "/ " + reader[3].ToString() + "/ " + reader[4].ToString() + "/ " + reader[5].ToString() + "/ " + Convert.ToDateTime(reader[6]).ToString("yyyy/MM/dd"));

                }
            }

            Console.WriteLine("************************************************************");

            var queryString2 = " select PMName, count(*) from ProjectManagers join Employees on Employees.ReportingTo = ProjectManagers.PMID Group by PMName Order by count(*) asc  ";

            SqlCommand command2 = new(queryString2, connStr);
            using (SqlDataReader reader = command2.ExecuteReader())
            {
                var i = 1;
                while (reader.Read())
                {
                    Console.WriteLine($"{i}. " + reader[0].ToString() + "/ " + reader[1].ToString());
                    i++;
                }
            }

            connStr.Close();

        }*/