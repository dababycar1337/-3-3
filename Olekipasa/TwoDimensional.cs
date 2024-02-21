using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using App1;
namespace App1
{
    public interface OnlyTwodimensionalFunctions : FunctionsForAllArrays
    {
        void ReverseWriting();
    }

    sealed class TwodimensionalArray : OnlyTwodimensionalFunctions
    {
        private int[,] _array;
        private int _length1;
        private int _length2;
        private float _middle;
        private int[,] _reversearray;
        private bool _want;
        public TwodimensionalArray(int n1, int n2, bool want)
        {
            _length1 = n1;
            _length2 = n2;
            _want = want;
        }
        public void MakeArray()
        {
            Random rnd = new Random();
            _array = new int[_length1, _length2];
            if (_want)
            {
                Console.WriteLine("Введите элементы массива");
                for (int i = 0; i < _length1; i++)
                {
                    for (int j = 0; j < _length2; j++)
                    {
                        _array[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            }
            else
            {
                for (int i = 0; i < _length1; i++)
                {
                    for (int j = 0; j < _length2; j++)
                    {
                        _array[i, j] = rnd.Next(0, 101);
                    }
                }
            }
        }

        public void FindMiddle()
        {
            Console.WriteLine("Среднее арифметическое массива:");
            int dop = 0;
            for (int i = 0; i < _length1; i++)
            {
                for (int j = 0; j < _length2; j++)
                {
                    _middle += _array[i, j];
                    dop++;
                }
            }
            _middle = _middle / dop;
            Console.WriteLine(_middle);
        }
        public void ReverseWriting()
        {
            _reversearray = new int[_length1, _length2];
            int w = 0;
            for (int i = 0; i < _length1; i++)
            {
                for (int j = 0; j < _length2; j++)
                {
                    if (w % 2 == 0)
                    {
                        _reversearray[i, j] = _array[i, j];
                    }
                    else
                    {
                        _reversearray[i, j] = _array[i, _length2 - 1 - j];
                    }
                }

                w++;
            }
            Console.WriteLine("Массив змейкой:");
            for (int i = 0; i < _length1; i++)
            {
                for (int j = 0; j < _length2; j++)
                {
                    if (_reversearray[i, j] != null)
                    {
                        Console.Write(_reversearray[i, j] + " ");
                    }

                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }


        public void Print()
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < _length1; i++)
            {
                for (int j = 0; j < _length2; j++)
                {
                    Console.Write(_array[i, j] + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
