using Refactoring.Services;
using Refactoring.Models;
using Refactoring.Other;

namespace Refactoring.Services
{
    public static class ReportService
    {
        public static void LogSalaryCalculation(Employee employee)
        {
            Console.WriteLine($"Starting salary calculation for employee {employee.Id}");
            Console.WriteLine($"Salary calculated for employee {employee.Id} on {Date.GetFormattedDate()}");
        }

        public static void LogSalary(string employeeId, double netSalary)
        { 
            string date = Date.GetFormattedDate();

            File.AppendAllText("salary_report.txt", $"Employee {employeeId}: {netSalary} on {date}\n");
        }
         public static void GenerateReport()
        {
            string date = Date.GetFormattedDate();
            Console.WriteLine($"Report generated on {date}");
        }
    }
}