using MoreLinq;

namespace Hotels.Ru.Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание №1
            string comp28Name = ComputersCount.GetComputersCountName(28);
            Console.WriteLine(comp28Name);  //"28 компьютеров"
            Console.WriteLine();

            //Задание №2
            int[] input = [42, 12, 18];
            int[] output = CommonDividers.GetCommonDividers(input);
            Console.WriteLine(output.ToDelimitedString(", "));  //"2, 3, 6"
            Console.WriteLine();

            //Задание №3
            int numBegin = 11, numEnd = 20;
            List<int> simpleNumbers = SimpleNumbers.GetSimpleNumbers(numBegin, numEnd);
            Console.WriteLine(simpleNumbers.ToDelimitedString(", "));  //"11, 13, 17, 19"
            Console.WriteLine();

            //Задание №4
            int limit = 5;
            string multiplicationTable = MultiplicationTable.GetTable(limit);
            Console.WriteLine(multiplicationTable);    //Таблица умножения до числа 5
        }
    }
}
