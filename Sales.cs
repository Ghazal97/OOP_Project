namespace FoodCompanyProject
{
    public class Sales  : Employee
    {
        public double SalesRate { get; set; }

        public double AchievementRate { get; set; }


        // method to calculate monthly salary for  Sales with 2 parameters 

        public double MonthlySalaryCalculate(double salesamount, double Achievementamount)
        {
            return (SalesRate * salesamount) + (AchievementRate * Achievementamount);
        }

    }
}