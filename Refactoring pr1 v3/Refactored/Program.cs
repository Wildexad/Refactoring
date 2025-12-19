using Refactoring.Models;
using Refactoring.Services;

namespace Refactoring
{
    class Programm
    {
        static void Main()
        {
            Employee employee = new Employee(
                id: "emp123",
                hoursWorked: 160,
                rate: 25.0,
                grade: "B",
                insurance: true,
                taxExempt: false,
                department: "IT",
                yearsOfExperience: 7
            );

        ReportService.LogSalaryCalculation(employee);

        double salary = SalaryCalculator.CalculateSalary(employee);
        Console.WriteLine($"Calculated salary: {salary}");

        string grade = GradeCalculator.GetEmployeeGrade(employee.Department, employee.YearsOfExperience);
        Console.WriteLine($"Calculated grade: {grade}");

        ReportService.LogSalary(employee.Id, salary);

        ReportService.GenerateReport();
        }
    }
}