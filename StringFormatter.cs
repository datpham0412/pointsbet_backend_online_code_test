using System;
using System.Text;
using System.Linq;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {
        public static string ToCommaSeparatedList(string[] items, string quote)
        {
            if (items == null || items.Length == 0)
            {
                return string.Empty;
            }
            var quoted_items = items
                .Where(item => !string.IsNullOrEmpty(item))
                .Select(item => $"{quote}{item}{quote}");

            return string.Join(", ", quoted_items);
        }
    }

    public class Program
    {
        public static void Main()
        {
            string[] items_1 = { "pham", "tien", "dat" };
            string result_1 = StringFormatter.ToCommaSeparatedList(items_1, "\"");
            Console.WriteLine($"Test 1: {result_1}");
            // Expected output: "pham", "tien", "dat"

            string[] items_2 = { "dat", "", "pham" };
            string result_2 = StringFormatter.ToCommaSeparatedList(items_2, "\"");
            Console.WriteLine($"Test 2: {result_2}");
            // Expected output: "dat", "pham"

            string[] items_3 = { "DatPham" };
            string result_3 = StringFormatter.ToCommaSeparatedList(items_3, "\"");
            Console.WriteLine($"Test 3: {result_3}");
            // Expected output: "DatPham"

            string[] items_4 = { };
            string result_4 = StringFormatter.ToCommaSeparatedList(items_4, "\"");
            Console.WriteLine($"Test 4: '{result_4}'");
            // Expected output: ''

            string[] items_5 = null;
            string result_5 = StringFormatter.ToCommaSeparatedList(items_5, "\"");
            Console.WriteLine($"Test 5: '{result_5}'");
            // Expected output: ''

            string[] items_6 = { "DAT", "pHaM" };
            string result_6 = StringFormatter.ToCommaSeparatedList(items_6, "'");
            Console.WriteLine($"Test 6: {result_6}");
            // Expected output: 'DAT', 'pHaM'

            string[] items_7 = { "tad", "pham" };
            string result_7 = StringFormatter.ToCommaSeparatedList(items_7, "");
            Console.WriteLine($"Test 7: {result_7}");
            // Expected output: tad, pham 
        }
    }
}
