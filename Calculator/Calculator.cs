using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace CalculatorApp
{
    public class Calculator<T>
    {
        public T Add(T value1, T value2)
        {
            dynamic nr1 = value1;
            dynamic nr2 = value2;
            dynamic result = nr1 + nr2;
            return result;
        }
        public T Sub(T value1, T value2)
        {
            dynamic nr1 = value1;
            dynamic nr2 = value2;
            dynamic result = nr1 - nr2;
            return result;
        }
        public T Mul(T value1, T value2)
        {
            dynamic nr1 = value1;
            dynamic nr2 = value2;
            dynamic result = nr1 * nr2;
            return result;
        }
        public T Div(T value1, T value2)
        {
            dynamic nr1 = value1;
            dynamic nr2 = value2;
            try
            {
                if (nr1 == 0 || nr2 == 0)
                {
                    throw new DivideByZeroException("Can't divide if a nr is '0'");
                }
            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine(ex);
            }
            dynamic result = nr1 / nr2;
            return result;
        }
    }
}
