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

            if (totalMoney.Contains("£")) totalMoney = totalMoney.Replace("£", "");
            double amountOfMoney = double.Parse(totalMoney);

            if (amountOfMoney < 0) throw new ArgumentOutOfRangeException();


            int totalAmount = (int)(amountOfMoney * 100);

            int totalTwoPound = totalAmount / 200;
            totalAmount %= 200;

            int totalOnePound = totalAmount / 100;
            totalAmount %= 100;

            int totalFiftyPence = totalAmount / 50;
            totalAmount %= 50;

            int totalTwentyPence = totalAmount / 20;
            totalAmount %= 20;

            int totalTenPence = totalAmount / 10;
            totalAmount %= 10;

            int totalFivePence = totalAmount / 5;
            totalAmount %= 5;

            int totalTwoPence = totalAmount / 2;
            totalAmount %= 2;

            int totalOnePence = totalAmount / 1;
            totalAmount %= 1;

            return ($"£2:{totalTwoPound} £1:{totalOnePound} £0.50:{totalFiftyPence} £0.20:{totalTwentyPence} £0.10:{totalTenPence} £0.05:{totalFivePence} £0.02:{totalTwoPence} £0.01:{totalOnePence}");

        }

        //public static double CheckIfValidDouble(string totalMoney)
        //{
        //    var RegExPattern = "/ ^[£] ? ([1 - 9]\\d{ 0,2}(,\\d{ 3})*| 0)?(\\.\\d{ 1,2})?$/";
        //    if (Regex.IsMatch(totalMoney, RegExPattern))

        //        totalMoney = totalMoney.Replace("£", "");
        //        return double.Parse(totalMoney);
        //}
    }

}
