namespace Hotels.Ru.Tests
{
    public static class SimpleNumbers
    {
        public static List<int> GetSimpleNumbers(int numBegin, int numEnd)
        {
            List<int> simpleNumbers = [];

            for (int i = numBegin; i <= numEnd; i++)
            {
                if (CheckNumberIsSimple(i))
                {
                    simpleNumbers.Add(i);
                }
            }

            return simpleNumbers;
        }

        private static bool CheckNumberIsSimple(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }
    }
}
