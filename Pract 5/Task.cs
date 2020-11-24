using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract_5
{
   
        public class Pair
        {   // поля
            private int _first;
            private int _second;
            //конструктор
            public Pair(int one, int two)
            {
                _first = one;
                _second = two;
            }
            //Свойства
            public int First
            {
                get => _first;
                set
                {
                    if (value % 2 == 0)
                    {
                        _first = value;

                    }
                }
            }
            public int Second
            {
                get => _second;
                set
                {
                    if (value % 2 == 0)
                    {
                        _second = value;

                    }
                }
            }
            // Метод
            public static Pair Multiply(Pair firstPair, Pair secondPair)
            {
                return new Pair(firstPair.First * secondPair.First, firstPair.Second * secondPair.Second);
            }
            public static Pair Multiply2(Pair firstPair)
            {
                return new Pair(firstPair.First * 2, firstPair.Second * 2);
            }


        }

}
