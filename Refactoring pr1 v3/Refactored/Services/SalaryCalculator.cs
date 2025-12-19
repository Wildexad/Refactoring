using Refactoring.Models;
using Refactoring.Other;

namespace Refactoring.Services
{
    public class SalaryCalculator
    {
        public static double CalculateSalary(Employee employee)
        {
            double baseSalary = CalculateBaseSalary(employee.HoursWorked, employee.Rate);
            double allowance = CalculateAllowance(employee.Grade, baseSalary);
            double deductions = CalculateDeductions(employee.Insurance, employee.TaxExempt, baseSalary);

            double netSalary = baseSalary + allowance - deductions;

            return netSalary;
        }
        private static double CalculateBaseSalary(int hoursWorked, double rate)
        {
            return hoursWorked * rate;
        }
        private static double CalculateAllowance(string grade, double baseSalary)
        {
            return grade switch
            {
                "A" => baseSalary * 0.2,
                "B" => baseSalary * 0.1,
                "C" => baseSalary * 0.05,
                _ => 0,
            };
        }
        private static double CalculateDeductions(bool insurance, bool taxExempt, double baseSalary)
        {
            double deductions = 0;

            if (insurance)
            {
                deductions += baseSalary * 0.05;
            }

            if (!taxExempt)
            {
                deductions += 0.1 * baseSalary;
            }

            return deductions;
        }
    }
}