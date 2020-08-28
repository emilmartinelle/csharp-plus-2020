namespace Session03Numbers
{
    using System;

    namespace Session03Exercise02
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Ange ett antal siffror, separat med kommatecken");

                var input = Console.ReadLine();

                var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
                double[] numberArray = new double[inputArray.Length];

                for (int i = 0; i < inputArray.Length; i++)
                {
                    try
                    {
                        numberArray[i] = Convert.ToDouble(inputArray[i]);
                    }

                    catch (Exception)
                    {
                        numberArray[i] = 0;
                    }

                    finally  /*/Körs alltid ovasett vad som händer med koden
                              * Måste vara i en loop /*/
                    {

                    }
                    /*/throw new Exception("Provocerat fel") Är ett egenskapat fel/*/

                    foreach (var number in numberArray)
                    {
                        Console.WriteLine("Värde: " + number.ToString());
                    }



                }
            }

        }
    }
}
    

