namespace Hotels.Ru.Tests
{
    public static class ComputersCount
    {
        public static string GetComputersCountName(int count)
        {
            int lastNumber = Convert.ToInt32(count.ToString()[^1].ToString());
            string numberEnding = GetNumberEnding(lastNumber);
            return $"{count} компьютер{numberEnding}";
        }

        private static string GetNumberEnding(int number)
        {
            string ending;
            switch (number)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    {
                        ending = "ов";
                        break;
                    }
                case 1:
                    {
                        ending = "";
                        break;
                    }
                case 2:
                case 3:
                case 4:
                    {
                        ending = "а";
                        break;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException(nameof(number), "Аргумент должен быть цифрой от 0 до 9");
                    }
            }
            return ending;
        }
    }
}
