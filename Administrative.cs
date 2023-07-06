namespace FoodCompanyProject
{
    public class Administrative : Employee
    {
        public double MonthlySalary { get; set; }

        public double HourlyWages { get; set; }

        public double ExtraHourlyWages { get; set; }


        // method to calculate monthly salary for  Administrative with  2 parameters 

        public double MonthlySalaryCalculate(int numberofworkhour, int numberofextrahour)
        {
            return MonthlySalary + (HourlyWages * numberofworkhour) + (ExtraHourlyWages * numberofextrahour);
        }

    }
}