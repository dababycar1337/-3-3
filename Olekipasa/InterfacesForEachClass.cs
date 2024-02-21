using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1;
namespace App1
{
    public interface IPrinter
    {
        void Print();
    }

    public interface FunctionsForAllArrays : IPrinter
    {
        void MakeArray();
        void FindMiddle();
    }
}
