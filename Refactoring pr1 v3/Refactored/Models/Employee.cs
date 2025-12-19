namespace Refactoring.Models
{
    public class Employee
    {
        public string Id { get; set; }
        public int HoursWorked { get; set; }
        public double Rate { get; set; }
        public string Grade { get; set; }
        public bool Insurance { get;set; }
        public bool TaxExempt { get; set; }
        public string Department { get; set; }
        public int YearsOfExperience { get; set; }
    

        public Employee(string id, int hoursWorked, double rate, string grade, bool insurance, bool taxExempt, string department, int yearsOfExperience)
        {
            Id = id;
            HoursWorked = hoursWorked;
            Rate = rate;
            Grade = grade;
            Insurance = insurance; 
            TaxExempt = taxExempt;
            Department = department;
            YearsOfExperience = yearsOfExperience;
        }
    }
}