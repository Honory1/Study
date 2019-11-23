using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class ArrayScaling
    {
        private double _n;
        private double[] _m;

        public ArrayScaling(double N)
        {
            _n = N;
        }

        public ArrayScaling(double[] M)
        {
            _m = M;
        }

        public double[] Scaling(double[] array) //метод для масштабирования, зависимости от введеных при инициализации класса данных
        {
            if (_m.Length == 0) //значит, что при инициализации класса указали одно число N
            {
                for (var i = 0; i < array.Length; i++)
                {
                    array[i] *= _n;
                }
            }
            else
            {
                for (var i = 0; i < array.Length; i++)
                {
                    array[i] *= _m[i];
                }
            }

            return array;
        }
    }
}
