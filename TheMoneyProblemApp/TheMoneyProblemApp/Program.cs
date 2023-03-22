using System.Text.RegularExpressions;
namespace TheMoneyProblemApp
{
    public class Program
    {
        static void Main(string[] args)
        {


        }

        public static string ReturnDenominations(string totalMoney)
        {
            //MULTIPLY BY 100
            //REGEX CHECK
            //TRY PARSE STRING TO DOUBLE

            double amountOfMoney = 0;
            int totalFivePound = 0;
            int totalTwoPound = 0;
            int totalOnePound = 0;
            int totalFiftyPence = 0;
            int totalTwentyPence = 0;
            int totalTenPence = 0;
            int totalFivePence = 0;
            int totalTwoPence = 0;
            int totalOnePence = 0;

            if (amountOfMoney / 5 >= 1)
            {
                totalFivePound = (int)amountOfMoney / 5;
                amountOfMoney = amountOfMoney % 5;
            }
            if (amountOfMoney / 2 > 1)
            {
                totalTwoPound = (int)amountOfMoney / 2;
                amountOfMoney = amountOfMoney % 2;
            }
            if (amountOfMoney / 1 > 1)
            {
                totalOnePound = (int)amountOfMoney / 1;
                amountOfMoney = amountOfMoney % 1;
            }
            //// TO BE COMPLETED
            //if (amountOfMoney / 0.5 > 1)
            //{
            //    totalFiftyPence = (int)amountOfMoney / 0.5;
            //    amountOfMoney = amountOfMoney % 0.5;
            //}
            //if (amountOfMoney / 0.2 > 1)
            //{
            //    totalTwentyPence = (int)amountOfMoney / 0.2;
            //    amountOfMoney = amountOfMoney % 0.2;
            //}
            //if (amountOfMoney / 0.1 > 1)
            //{
            //    totalTenPence = (int)amountOfMoney / 0.1;
            //    amountOfMoney = amountOfMoney % 0.1;
            //}
            //if (amountOfMoney / 0.05 > 1)
            //{
            //    totalFivePence = (int)amountOfMoney / 0.05;
            //    amountOfMoney = amountOfMoney % 0.05;
            //}
            //if (amountOfMoney / 0.02 > 1)
            //{
            //    totalTwoPence = (int)amountOfMoney / 0.02;
            //    amountOfMoney = amountOfMoney % 0.02;
            //}
            //if (amountOfMoney / 0.01 > 1)
            //{
            //    totalOnePence = (int)amountOfMoney / 0.01;
            //    amountOfMoney = amountOfMoney % 0.01;
            //}
            return totalMoney;
        }

        public static double CheckIfValidDouble(string totalMoney)
        {
            var RegExPattern = "/ ^[£] ? ([1 - 9]\\d{ 0,2}(,\\d{ 3})*| 0)?(\\.\\d{ 1,2})?$/";
            if (Regex.IsMatch(totalMoney, RegExPattern))
            {
                totalMoney = totalMoney.Replace("£", "");
                return double.Parse(totalMoney);
            }
            else
            {
                return 0;
            }

        }
        

    }


}
