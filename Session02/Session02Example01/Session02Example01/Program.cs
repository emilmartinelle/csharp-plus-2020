using System;
using System.Xml.Schema;

namespace Session02Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Binary operation
            var additionResult = 1 + 2;

            Console.WriteLine("additionalResult " + additionResult.ToString());

            var incrementResult = ++additionResult;

            Console.WriteLine("incrementResult " + incrementResult.ToString());

            var trueValue = true;

            var falseValue = false;

            var andResult = trueValue & falseValue;  // 0b0110
            var orResult = trueValue | falseValue;
            var xorResult = trueValue ^ falseValue;

            Console.WriteLine("andResult " + andResult);
            Console.WriteLine("orResult " + orResult);
            Console.WriteLine("xorResult " + xorResult);

            var moduloResult = 7 % 5;

            Console.WriteLine("moduloResult " + moduloResult);

            var highInteger = 1000;
            var IntegerDivisionResult = highInteger / 3;

            // Implicit värdekonvertering till double
            var doubleDivisionResult = highInteger / 3.0;

            Console.WriteLine("integerDivisionResult " + IntegerDivisionResult);
            Console.WriteLine("doubleDivisionResult " + doubleDivisionResult);

            var castIntDivisionResult = (int)(highInteger / 3.0);

            Console.WriteLine("castIntDivisionResults " + castIntDivisionResult);

            var conversionResult = Convert.ToInt32(doubleDivisionResult);

            Console.WriteLine("convertionResult " + conversionResult);

            var midpointDivisionResult = 10.0 / 3.0;

            Console.WriteLine("midpointDivisionResult " + midpointDivisionResult);
            Console.WriteLine("castToInt " + ((int)midpointDivisionResult).ToString());

            Console.WriteLine("ceiling " +Math.Ceiling(midpointDivisionResult));
            Console.WriteLine("floor " + Math.Floor(midpointDivisionResult));
            Console.WriteLine("round " + Math.Round(midpointDivisionResult));
            // Med decimaler
            Console.WriteLine("round " + Math.Round(midpointDivisionResult,3));

            
            additionResult += 2;
            additionResult -= 2;
            additionResult /= 2;
            additionResult *= 2;

            //^^ Smidigare sätt än det nedanför. Gör samma sak

            additionResult = additionResult + 2;

            var greaterResult = 5 > 3;
            var lessThanResult = 5 < 3;
            var greaterOrEqual = 5 >= 3;
            var lessOrEqual = 5 <= 3;

            Console.WriteLine("greaterResult " + greaterResult);
            Console.WriteLine("lessThanResult " + lessThanResult);
            Console.WriteLine("greaterOrEqual " + greaterOrEqual);
            Console.WriteLine("lessOrEqual " + lessOrEqual);

            var andOperationResult = true && false;
            var orOperationalResult = false || true;
            
            Console.WriteLine("andOperationalResult " + andOperationResult);
            Console.WriteLine("orOperationalResult " + orOperationalResult);



            Console.ReadKey();
            
        }
    }
}
