using System.Text;

namespace Hotels.Ru.Tests
{
    public static class MultiplicationTable
    {
        public static string GetTable(int limit)
        {
            StringBuilder builder = new();
            builder.Append(GetHeadersRow(limit));

            for (int i = 1; i <= limit; i++)
            {
                string resultRow = GetResultsRow(i, limit);
                builder.Append($"\r\n{resultRow}");
            }

            return builder.ToString();
        }

        private static string GetHeadersRow(int limit)
        {
            StringBuilder builder = new(" ");

            for (int i = 1; i <= limit; i++)
            {
                builder.Append($" {i}");
            }

            return builder.ToString();
        }

        private static string GetResultsRow(int multilplier, int limit)
        {
            StringBuilder builder = new($"{multilplier}");

            for (int i = 1; i <= limit; i++)
            {
                builder.Append($" {i * multilplier}");
            }

            return builder.ToString();
        }
    }
}
