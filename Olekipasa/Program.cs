using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1;
namespace App1
{
    class Program
    {
        static void Main()
        {

            FunctionsForAllArrays[] allarr = new FunctionsForAllArrays[3];

            allarr[0] = new OnedimensionalArray(3, true);
            allarr[1] = new TwodimensionalArray(3, 3, true);
            allarr[2] = new StepArray(3, true);


            Console.WriteLine("Всё про одномерные массивы:");
            allarr[0].MakeArray();
            allarr[0].Print();
            allarr[0].FindMiddle();
            OnedimensionalArray one = (OnedimensionalArray)allarr[0];
            one.LowerHundred();
            one.NoRepeat();
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Всё про двумерные массивы:");
            allarr[1].MakeArray();
            allarr[1].Print();
            allarr[1].FindMiddle();
            TwodimensionalArray two = (TwodimensionalArray)allarr[1];
            two.ReverseWriting();
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Всё про ступенчатые массивы:");
            allarr[2].MakeArray();
            allarr[2].Print();
            allarr[2].FindMiddle();
            StepArray step = (StepArray)allarr[2];
            step.MultiArrayMaker();
            Console.WriteLine("");
            Console.WriteLine("");

            DaysInTheWeek day = new DaysInTheWeek();
            day.Print();
        }
    }
}