using App1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1;
using static System.Net.WebRequestMethods;
using System.Runtime.Intrinsics.Arm;
using System.Reflection;

namespace App1
{
    public interface OnlyStepArrayFunctions : FunctionsForAllArrays
    {
        void MultiArrayMaker();
    }

    sealed class StepArray : OnlyStepArrayFunctions
    {
        private int[][] _array;
        private int _length;
        private float _middle;
        private int[][] _multiarray;
        private bool _want;
        public StepArray(int n, bool want)
        {
            _length = n;
            _want = want;
        }
        public void MakeArray()
        {
            Random rnd = new Random();
            _array = new int[_length][];
            if(_want)
            {
                int dop = 0;;
                for (int i = 0; i < _length; i++)
                {
                    Console.WriteLine("Сколько элементов будет в " + (i + 1) + " строке?");
                    dop = int.Parse(Console.ReadLine());
                    _array[i] = new int[dop];
                    Console.WriteLine("Введите элементы");
                    for (int j = 0; j < dop; j++)
                    {
                        _array[i][j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            else
            {
                int dop = 0;
                for (int i = 0; i < _length; i++)
                {
                    dop = rnd.Next(1, 4);
                    _array[i] = new int[dop];
                    for (int j = 0; j < dop; j++)
                    {
                        _array[i][j] = rnd.Next(0, 101);
                    }
                }
            }
        }

        public void FindMiddle()
        {
            Console.WriteLine("Среднее арифметическое массива:");
            int dop = 0;
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < _array[i].Length; j++)
                {
                    _middle += _array[i][j];
                    dop++;
                }
            }
            _middle = _middle / dop;
            Console.WriteLine(_middle);
        }

        public void Print()
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < _length; i++)
            {
                Console.Write((i + 1) + " строка: ");
                for (int j = 0; j < _array[i].Length; j++)
                {
                    Console.Write(_array[i][j] + " ");
                }
                Console.WriteLine("");
            }
        }
        public void MultiArrayMaker()
        {
            _multiarray = new int[_length][];
            for (int i = 0; i < _length; i++)
            {
                _multiarray[i] = new int[_array[i].Length];
                for (int j = 0; j < _array[i].Length; j++)
                {
                    ;
                    if (_array[i][j] % 2 == 0)
                    {
                        _multiarray[i][j] = (i + 1) * (j + 1);
                    }
                    else
                    {
                        _multiarray[i][j] = _array[i][j];
                    }
                }
            }
            Console.WriteLine("Массив, в котором чётные по индексу элементы являются произведением их индексов:");
            for (int i = 0; i < _length; i++)
            {
                for (int j = 0; j < _multiarray[i].Length; j++)
                {
                    Console.Write(_multiarray[i][j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }

    }
}
