using App1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1;
namespace App1
{
    class DaysInTheWeek : IPrinter
    {
        public void Print()
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine("День недели: " + dt.DayOfWeek);
        }
    }
}
