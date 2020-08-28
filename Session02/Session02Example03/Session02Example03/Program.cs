using System;

namespace Session02Example03
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var integer = Convert.ToInt32(input);

            string waterLabel = integer >= 27 ? "Går bra att bada" : "Går inte att bada";

            /*/if(integer >27)
            {
                waterLabel = "Går bra att bada";
            }
            else
            {
                waterLabel = "Går inte bra att bada";    
            }
            /*/

            //Om det är dessa exakta värden inträffar
            switch (integer)
            {
                case 1: waterLabel = "Går inte bra att bada alls"; break;
                case 3-: waterLabel = "Det är 3 minusgrader"; break;
                default: /*Här kan man göra något om inget träffar*/ break;
            }
            Console.WriteLine(waterLabel + " i havet");

        }
    }
}
