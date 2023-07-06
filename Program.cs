using System;

namespace FoodCompanyProject
{
    class Program
    {
        static void Main(string[] args)
        {

            // Enter Number Of Administrative 
            Console.WriteLine("Please Enter Administrative Number");
            int ad = int.Parse(Console.ReadLine());
            Administrative[] adminis = new Administrative[ad];

            // initialise adminis array with null value
            for (int i = 0; i < ad; i++)
            {
                adminis[i] = null;
            }
            
            
            for (int i = 0; i < adminis.Length; i++)
            {
            
                Console.WriteLine("Please Enter  adminis {0} information", i+1);
                adminis[i] = new Administrative();
                adminis[i].FirstName = Console.ReadLine();
                adminis[i].MiddleName = Console.ReadLine();
                adminis[i].LastName = Console.ReadLine();
                adminis[i].IDNumber = Double.Parse(Console.ReadLine());
                adminis[i].BirthDate = DateTime.Parse(Console.ReadLine());
                adminis[i].DateOfAppointment = DateTime.Parse(Console.ReadLine());
                adminis[i].HourlyWages = Double.Parse(Console.ReadLine());
                adminis[i].MonthlySalary = Double.Parse(Console.ReadLine());
                adminis[i].ExtraHourlyWages = Double.Parse(Console.ReadLine());
               
            }

            // Enter Number Of Sales 
            Console.WriteLine("Please Enter Sales Number");
            int sa = int.Parse(Console.ReadLine());
            Sales[] sales = new Sales[sa];

            // initialise sales array with null value
            for (int i = 0; i < ad; i++)
            {
                sales[i] = null;
            }
            for (int i = 0; i < sales.Length; i++)
            {

                Console.WriteLine("Please Enter  Sales {0} information", i + 1);
                sales[i] = new Sales();
                sales[i].FirstName = Console.ReadLine();
                sales[i].MiddleName = Console.ReadLine();
                sales[i].LastName = Console.ReadLine();
                sales[i].IDNumber = Double.Parse(Console.ReadLine());
                adminis[i].BirthDate = DateTime.Parse(Console.ReadLine());
                adminis[i].DateOfAppointment = DateTime.Parse(Console.ReadLine());
                sales[i].AchievementRate = Double.Parse(Console.ReadLine());
                sales[i].SalesRate = Double.Parse(Console.ReadLine());
                
            }

            var input = "";

            #region MyRegion
            //test cases for method
            /*Administrative a = new Administrative();
            a.MonthlySalary = 2000;
            a.HourlyWages = 29;
            a.ExtraHourlyWages = 2;
            double ans = a.MonthlySalaryCalculate(2, 8);
            Console.WriteLine(ans + "_");
            */
            #endregion

            do
            {
                Console.WriteLine(   " If you want to show Administrative info ? Please Enter A " + "\n"
                                   + " If you want to show Administrative Salary ? Please Enter AS " + "\n"
                                   + " If you want to show Sales info ? Please Enter S " + "\n"
                                   + " If you want to show Sales Salary ? Please Enter SS " + "\n"
                                   + " If you want to Exit  ? Please Enter E "
                                    );


                input = Console.ReadLine();
                switch (input)
                {
                    case "A":
                        Console.WriteLine("Please Enter Your Index");
                        int index = int.Parse(Console.ReadLine());
                        Console.WriteLine("FirstName is " + adminis[index].FirstName + "\n"
                                          + "MiddleName  is " + adminis[index].MiddleName + "\n"
                                          + "LastName  is " + adminis[index].LastName + "\n"
                                          + "IDNumber  is " + adminis[index].IDNumber + "\n"
                                          + "BirthDate  is " + adminis[index].BirthDate.ToString() + "\n"
                                          + "DateOfAppointment  is " + adminis[index].DateOfAppointment.ToString() + "\n"
                                          + "MonthlySalary  is " + adminis[index].MonthlySalary + "\n"
                                          + "HourlyWages  is " + adminis[index].HourlyWages + "\n"
                                          + "ExtraHourlyWages  is " + adminis[index].ExtraHourlyWages);
                        break;
                    case "AS":
                        Console.WriteLine("Please Enter Your Index");
                        int index1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please Enter Number of workhour ");
                        int workhour = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please Enter Number of extrahour ");
                        int extrahour = int.Parse(Console.ReadLine());
                        double salary = adminis[index1].MonthlySalaryCalculate(workhour, extrahour);
                        Console.WriteLine(salary);
                        break;
                    case "S":
                        Console.WriteLine("Please Enter Your Index");
                        int sindex = int.Parse(Console.ReadLine());
                        Console.WriteLine("FirstName is " + sales[sindex].FirstName + "\n"
                                          + "MiddleName  is " + sales[sindex].MiddleName + "\n"
                                          + "LastName  is " + sales[sindex].LastName + "\n"
                                          + "IDNumber  is " + sales[sindex].IDNumber + "\n"
                                          + "BirthDate  is " + adminis[sindex].BirthDate.ToString() + "\n"
                                          + "DateOfAppointment  is " + adminis[sindex].DateOfAppointment.ToString() + "\n"
                                          + "SalesRate  is " + sales[sindex].SalesRate + "\n"
                                          + "AchievementRate  is " + sales[sindex].AchievementRate);
                        break;
                    case "SS":
                        Console.WriteLine("Please Enter Your Index");
                        int index2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please Enter Salesamount ");
                        double salesamount = double.Parse(Console.ReadLine());
                        Console.WriteLine("Please Enter Achievementamount ");
                        double Achievementamount = double.Parse(Console.ReadLine());
                        double salarysales = sales[index2].MonthlySalaryCalculate(salesamount, Achievementamount);
                        Console.WriteLine(salarysales);
                        break;
                }
            } while (input != "E");

        }
      }
    }