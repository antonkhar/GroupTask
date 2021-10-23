using System;
using System.Collections.Generic;
using System.Text;

namespace GroupTaskNext1._1
{
    public class QuantityTypesExcept : Exception
    {
       public QuantityTypesExcept()
        {
            Console.WriteLine("Введено неверное значение! Введите 1, 2 или 3.");
        }
    }
}
