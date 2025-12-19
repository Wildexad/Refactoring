namespace Refactoring.Services
{
    public static class GradeCalculator
    {
        public static string GetEmployeeGrade(string Department, int YearsOfExperience)
        {
           if (Department == "IT")
            {
                return GetGradeByExperience(YearsOfExperience, 10, 5);
            }

           if (Department == "HR")
            {
                return GetGradeByExperience(YearsOfExperience, 8, 4);
            }
            
           return "C";
        }
        private static string GetGradeByExperience(int years, int alevel, int bLevel)
        {
            if (years>alevel)
            {
                return "A";
            }
            if (years>bLevel)
            {
                return "B";
            }       
            return "C";       
        }  
    }
}