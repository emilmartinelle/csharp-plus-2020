using System;

namespace Session03Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] integerValues = new [] { 1, 2, 3 };
            var integerValueName = nameof(integerValues);

            for (var i = 0; i < integers.Length; i++)
            {
                var name = nameof(integers);
                var value = integers[i];

                Console.WriteLine($"Index {i} i arrayen {nameof(integers)} har värdet: {integers[i]}");
            }
            var doWhileIndex = 0;

            do
            {
                var value = integerValues[doWhileIndex];

                Console.WriteLine($"Index{doWhileIndex} i arrayen {integerValueName} har värdet: {value}");
                doWhileIndex++;
            }
            while (doWhileIndex < integerValues.Length);

            var whileIndex = 0;

            while (whileIndex++ < integersValues < whileIndex)

                Console.WriteLine($"While Index {whileIndex} i arrayen {integerValueName} har värdet: {value}");

            whileIndex++;
                
        }
    }
}
