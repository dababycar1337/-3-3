using App1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App1;
namespace App1
{
    public interface OnlyOnedimensionalFunctions : FunctionsForAllArrays
    {
        void LowerHundred();
        void NoRepeat();
    }

    sealed class OnedimensionalArray : OnlyOnedimensionalFunctions
    {
        private int[] _array;
        private float _middle;
        private int _length;
        private int[] _lowerarray;
        private int[] _norepeatarray;
        private bool _want;
        public OnedimensionalArray(int n, bool want)
        {
            _length = n;
            _want = want;
        }
        public void MakeArray()
        {
            Random rnd = new Random();
            _array = new int[_length];
            if(_want)
            {
                Console.WriteLine("Введите элементы массива");
                for (int i = 0; i < _length; i++)
                {
                    _array[i] = int.Parse(Console.ReadLine());
                }
            }
            else
            {
                for (int i = 0; i < _length; i++)
                {
                    _array[i] = rnd.Next(-150, 151);
                }
            }
        }
        public void FindMiddle()
        {
            Console.WriteLine("Среднее арифметическое массива:");
            for (int i = 0; i < _array.Length; i++)
            {
                _middle += _array[i];
            }
            _middle = _middle / _array.Length;
            Console.WriteLine(_middle);
        }

        public void Print()
        {
            Console.WriteLine("Массив:");
            for (int i = 0; i < _array.Length; i++)
            {
                Console.Write(_array[i] + " ");
            }
            Console.WriteLine("");
        }
        public void LowerHundred()
        {
            _lowerarray = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                if ((_array[i] < 100) && (_array[i] > -100))
                {
                    _lowerarray[i] = _array[i];
                }
            }
            Console.WriteLine("Массив, в котором все элементы меньше 100 по модулю:");
            for (int i = 0; i < _lowerarray.Length; i++)
            {
                Console.Write(_lowerarray[i] + " ");
            }
            Console.WriteLine("");
        }
        public void NoRepeat()
        {
            _norepeatarray = new int[_length];
            for (int i = 0; i < _length; i++)
            {
                int c = _array[i];
                for (int j = 0; j < _length; j++)
                {
                    if (i != j && c == _array[j])
                    {
                        _array[j] = 0;
                        _norepeatarray[i] = c;
                    }
                    else
                    {
                        _norepeatarray[i] = c;
                    }
                }
            }
            Console.WriteLine("Массив без повторений:");
            for (int i = 0; i < _norepeatarray.Length; i++)
            {
                Console.Write(_norepeatarray[i] + " ");
            }
            Console.WriteLine("");
        }
    }
}
